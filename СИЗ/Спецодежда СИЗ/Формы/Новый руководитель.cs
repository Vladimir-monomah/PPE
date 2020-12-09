using System;
using System.Windows.Forms;
using Спецодежда_СИЗ.СИЗDataSetTableAdapters;
using static Спецодежда_СИЗ.СИЗDataSet;

namespace Спецодежда_СИЗ
{
    public partial class Новый_руководитель : Form
    {
        public delegate void OnSave();

        public delegate void OnBeforeSave(РуководителиRow isRecordExists);

        public Новый_руководитель()
        {
            this.OnSaveEvent += () => { };
            this.OnBeforeSaveEvent += existingDirector => { };
            this.InitializeComponent();
        }

        public event OnSave OnSaveEvent;

        public event OnBeforeSave OnBeforeSaveEvent;

        /// <summary>
        /// Проверка заполненности полей
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            if (this.textBoxHead.Text == "")
            {
                return false;
            }
            return true;
        }

        public string ПолучитьРуководителя()
        {
            return this.textBoxHead.Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Название элемента справочника пустое и не будет сохранено.", "Информация",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            var headName = this.textBoxHead.Text;
            РуководителиRow existingHead = null;
            var adapter = new РуководителиTableAdapter();
            adapter.Fill(EntityManager.HeadDataTable);
            foreach(var head in EntityManager.HeadDataTable)
            {
                if(headName == head.ФИО)
                {
                    existingHead = head;
                    break;
                }
            }

            if (existingHead != null)
            {
                this.OnBeforeSaveEvent(existingHead);
                if (MessageBox.Show("Руководитель уже существует! Изменить информацию о нём?", "Информация", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                existingHead.Должности = (int)this.positionComboBox.SelectedValue;
                existingHead.Отдел = (int)this.departmentComboBox.SelectedValue;
            }
            else
            {
                var newHead = EntityManager.HeadDataTable.NewРуководителиRow();
                newHead.ФИО = this.textBoxHead.Text;
                newHead.Должности = (int)this.positionComboBox.SelectedValue;
                newHead.Отдел = (int)this.departmentComboBox.SelectedValue;

                EntityManager.HeadDataTable.AddРуководителиRow(newHead);
            }

            EntityManager.UpdateHead();
            this.OnSaveEvent();
            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxHead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Новый_руководитель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.сИЗDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.сИЗDataSet.Отделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Руководители". При необходимости она может быть перемещена или удалена.
            this.руководителиTableAdapter.Fill(this.сИЗDataSet.Руководители);

        }
    }
}
