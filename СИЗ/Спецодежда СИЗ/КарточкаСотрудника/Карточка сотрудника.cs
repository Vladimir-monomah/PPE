using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Спецодежда_СИЗ.СИЗDataSet;

namespace Спецодежда_СИЗ.КарточкаСотрудника
{
    public partial class Карточка_сотрудника : Form
    {
        public Карточка_сотрудника()
        {
            InitializeComponent();
        }

        public СотрудникиRow GetCurrentEmployee()
        {
            return (СотрудникиRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row;
        }

        private void Карточка_сотрудника_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.сИЗDataSet.Сотрудники);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
