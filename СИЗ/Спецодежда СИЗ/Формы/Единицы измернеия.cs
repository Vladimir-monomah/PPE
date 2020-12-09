using System;
using System.Windows.Forms;
using Спецодежда_СИЗ.СИЗDataSetTableAdapters;

namespace Спецодежда_СИЗ
{
    public partial class Единицы_измернеия : Form
    {
        private единицы_измеренияTableAdapter единицы_измеренияTableAdapter;
        private СИЗDataSet сИЗDataSet;

        public Единицы_измернеия()
        {
            InitializeComponent();
        }

        public Единицы_измернеия(единицы_измеренияTableAdapter единицы_измеренияTableAdapter, СИЗDataSet сИЗDataSet)
        {
            this.единицы_измеренияTableAdapter = единицы_измеренияTableAdapter;
            this.сИЗDataSet = сИЗDataSet;
        }

        //проверка заполненности полей
        private bool CheckTextBoxes()
        {
            if (textBoxUnits.Text == "")
            {
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxes())
            {
                MessageBox.Show("Название должно быть заполнено", "Информация",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            var newUnits = EntityManager.UnitsDataTable.Newединицы_измеренияRow();
            newUnits.Наименование = this.textBoxUnits.Text;
            EntityManager.UnitsDataTable.Addединицы_измеренияRow(newUnits);
            EntityManager.UpdateUnits();

            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

