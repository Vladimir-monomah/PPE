using System;
using System.Windows.Forms;

namespace Спецодежда_СИЗ
{
    public partial class Добавление_клиента : Form
    {
        public Добавление_клиента()
        {
            InitializeComponent();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxes())
            {
                MessageBox.Show("Заполните все поля!", "Информация");
                return;
            }

            var newUser = EntityManager.UserDataTable.NewПользователиRow();
            newUser.Фамилия = this.textBoxSurname.Text;
            newUser.Имя = this.textBoxName.Text;
            newUser.Отчество = this.textBoxPatronymic.Text;
            newUser.Логин = this.textBoxLogin.Text;
            newUser.Пароль = this.textBoxPassword.Text;
            EntityManager.UserDataTable.AddПользователиRow(newUser);
            EntityManager.UpdateUsers();

            MessageBox.Show("Клиент успешно добавлен!", "Информация");
            this.Close();
        }

        private bool CheckTextBoxes()
        {
            if (textBoxSurname.Text == "" || textBoxName.Text == "" ||
                textBoxPatronymic.Text == "" ||
                textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                return false;
            }
            return true;
        }

        //запрет на ввод цифр
        private void textBoxSername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
