using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Спецодежда_СИЗ.СИЗDataSetTableAdapters;
using static Спецодежда_СИЗ.СИЗDataSet;

namespace Спецодежда_СИЗ.Формы
{
    public delegate void OnSave();

    public delegate void OnBeforeSave(ОтделыRow isRecordExists);

    public partial class Новый_отдел : Form
    {
        public Новый_отдел()
        {
            this.OnSaveEvent += () => { };
            this.OnBeforeSaveEvent += isRecordExists => { };
            InitializeComponent();
        }

        public event OnSave OnSaveEvent;

        public event OnBeforeSave OnBeforeSaveEvent;

        public void ЗагрузитьОтдел(string названиеОтдел)
        {
            this.textBoxDep.Text = названиеОтдел;
        }

        private bool CheckTextBoxes()
        {
            if (textBoxDep.Text == "")
            {
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxes())
            {
                MessageBox.Show("Название элемента справочника пустое и не будет сохранено.", "Информация",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            var departamentName = this.textBoxDep.Text;
            var adapter = new ОтделыTableAdapter();
            adapter.Fill(EntityManager.DepartamentsDataTable);
            ОтделыRow existingDepartaments = null;
            foreach (var departaments in EntityManager.DepartamentsDataTable)
            {
                if (departaments.Наименование == departamentName)
                {
                    existingDepartaments = departaments;
                    break;
                }
            }

            if (existingDepartaments != null)
            {
                this.OnBeforeSaveEvent(existingDepartaments);
                MessageBox.Show("Отдел с таким именем уже существует!", "Информация", MessageBoxButtons.OK);
                return;
            }

            var newDepartaments= EntityManager.DepartamentsDataTable.NewОтделыRow();
            newDepartaments.Наименование = departamentName;
            EntityManager.DepartamentsDataTable.AddОтделыRow(newDepartaments);
            EntityManager.UpdateDepartaments();
            this.OnSaveEvent();

            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK);
        }

        private void textBoxDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
