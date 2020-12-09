using System;
using System.Data;
using System.Windows.Forms;

namespace Спецодежда_СИЗ.КарточкаСотрудника
{
    public partial class Типы_номенклатуры : Form
    {
        public Типы_номенклатуры()
        {
            InitializeComponent();
        }

        public DataRow GetChoosedRow()
        {
            return ((DataRowView)this.dataGridView8.CurrentRow?.DataBoundItem)?.Row;
        }

        private void Типы_номенклатуры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Типы_номенклатуры". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыTableAdapter.Fill(this.сИЗDataSet.Типы_номенклатуры);

        }

        private void dataGridView8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
                this.типыНоменклатурыBindingSource.Filter = "[Наименование] Like'" + this.textBox8.Text + "%'";
        }
    }
}
