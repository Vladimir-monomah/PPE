using System;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Спецодежда_СИЗ.Properties;
using Спецодежда_СИЗ.РегистрацияАвторизацияАдминистратор;

namespace Спецодежда_СИЗ
{
    public partial class Авторизация : Form
    {
        private string password = "ntvHA2s1y+ryOZizPQ1WHQ==";

        int counter = 0;

        public Авторизация()
        {
            if(!CheckDBConnect())
            {
                this.Close();
            }

            InitializeComponent();
        }

        /// <summary>
        /// Проверяет возможность соединения с БД СИЗ,
        /// при необходимости, заменяет путь к резервной копии по указанию пользователя
        /// </summary>
        private bool CheckDBConnect()
        {
            while (true)
            {
                try
                {
                    using (var connection = new OleDbConnection(Settings.Default.СИЗConnectionString1))
                    {
                        connection.Open();
                        return true;
                    }
                }
                catch
                {
                    var reservDBFileQuestionResult = MessageBox.Show(
                        "Не найдена база данных СИЗ!\r\nХотите указать файл из резервной копии?",
                        "Информация",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (reservDBFileQuestionResult != DialogResult.Yes)
                    {
                        return false;
                    }

                    var openDialog = new OpenFileDialog
                    {
                        Title = "Укажите файл базы данных СИЗ",
                        Filter = "База данных СИЗ|*.mdb",
                        InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                    };
                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        Settings.Default["СИЗConnectionString1"] = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + openDialog.FileName;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Открытие формы регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRegistration_Click(object sender, EventArgs e)
        {
            Регистрация открыть = new Регистрация(this.password);
            открыть.Show();
        }

        /// <summary>
        /// Pакрытие программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Авторизация_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действиетльно хотите выйти?",
                    "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else e.Cancel = true;
            }
            else Application.Exit();
        }

        /// <summary>
        /// Проверка входа в программу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(tbLogin.Text=="" && tbPassword.Text == "")
            {
                MessageBox.Show("Вы не ввели логин или пароль! Пожалуйста, заполните поля!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.counter++;
            if(string.IsNullOrEmpty(tbLogin.Text))
            {
                this.tbLogin.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.tbPassword.Text))
            {
                this.tbPassword.Focus();
                return;
            }

            else if (this.counter >= 3)
            {
                this.tbLogin.Enabled = false;
                this.tbPassword.Enabled = false;
                MessageBox.Show("По всем вопросам восстановления пароля свяжитесь с Вашим администратором по номеру  " +
                    "+7 (939) 366-11-67!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            var user = this.FindUser(this.tbLogin.Text, this.tbPassword.Text);
            if (user != null)
            {
                MessageBox.Show($"Привет, {user.Имя}!");
                if (user.Является_администратором)
                {
                    Администратор формаАдминистратора = new Администратор();
                    this.Hide();
                    формаАдминистратора.Show();
                }
                else
                {
                    Работа_внутри_БД открыть = new Работа_внутри_БД(user.Id_user);
                    this.Hide();
                    открыть.Show();
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неверный логин или пароль!Пользователь в базе не найден!", "Сообщение",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            } 
        }

        private void pictureBoxRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void PasswordChangeLabel_Click(object sender, EventArgs e)
        {
            Смена_пароля открыть = new Смена_пароля();
            открыть.OnValidateUser += (login, oldPassword, newPassword) =>
            {
                var user = this.FindUser(открыть.GetLogin(), открыть.GetOldPassword());
                if (user == null)
                {
                    MessageBox.Show("Не найден пользователь с таким логином и паролем");
                    return false;
                }

                user.Пароль = Регистрация.Encrypt(открыть.GetNewPassword(), this.password);
                EntityManager.UpdateUsers();
                MessageBox.Show("Пароль изменён!");
                return true;
            };
            открыть.ShowDialog();
        }

        /// <summary>
        /// Выполняет поиск пользователя по логину и паролю
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private СИЗDataSet.ПользователиRow FindUser(string login, string password)
        {
            var loginCondition = $"Логин='{login}' AND Пароль='{Регистрация.Encrypt(password, this.password)}'";
            var user = EntityManager.FilterUsers(loginCondition).FirstOrDefault();
            return user;
        }
    }
}
