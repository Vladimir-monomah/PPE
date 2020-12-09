using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Спецодежда_СИЗ.КарточкаСотрудника;
using Спецодежда_СИЗ.Формы;

namespace Спецодежда_СИЗ
{
    public partial class Администратор : Form
    {
        const string FilterNonAdministrators = "([Является администратором]=FALSE)";

        public Администратор()
        {
            InitializeComponent();
        }

        private void Администратор_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.сИЗDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.сИЗDataSet.Пользователи);
        }

        ///<summary>
        ///Фильтрация пользователей
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="e"</param>
        private void clientFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "Фамилия", "Имя", "Отчество" };
            var filterString = EntityManager.GetFilterStringByFields(findFields, clientFilterTextBox.Text).Trim();

            this.пользователиBindingSource.Filter = FilterNonAdministrators;
            if (!string.IsNullOrEmpty(filterString))
            {
                this.пользователиBindingSource.Filter += $"AND ({filterString})";
            }
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            (new Добавление_клиента()).ShowDialog();
            this.пользователиTableAdapter.Fill(this.сИЗDataSet.Пользователи);
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.Filter = null;
            clientFilterTextBox.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            int ind = dataGridViewClient.SelectedCells[0].RowIndex;
            dataGridViewClient.Rows.RemoveAt(ind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.пользователиTableAdapter.Adapter.Update(this.сИЗDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dataBasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\СИЗ.mdb";
            var saveDialog = new SaveFileDialog
            {
                Filter = "AccessDB files|*.mdb"
            };
            try
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(dataBasePath, saveDialog.FileName, true);
                    MessageBox.Show("Резервное копирование прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не удаётся скопировать файл из-за исключения: " + exception.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dataBasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\СИЗ.mdb";
            var openDialog = new OpenFileDialog
            {
                Filter = "AccessDB files|*.mdb"
            };
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openDialog.FileName, dataBasePath, true);
                    MessageBox.Show("Восстановление прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                пользователиTableAdapter.Adapter.Fill(сИЗDataSet.Пользователи);
                пользователиTableAdapter.Adapter.Update(сИЗDataSet.Пользователи);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Новая_должность открыть = new Новая_должность();
            открыть.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Новый_руководитель открыть = new Новый_руководитель();
            открыть.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Новый_отдел открыть = new Новый_отдел();
            открыть.ShowDialog();
        }

        private void Администратор_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
