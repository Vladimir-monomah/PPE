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
    public partial class Руководители : Form
    {
        public Руководители()
        {
            InitializeComponent();
        }

        public string ПолучитьРуководителя()
        {
            return ((РуководителиRow)((DataRowView)this.headDataGridView.CurrentRow?.DataBoundItem)?.Row)?.ФИО;
        }

        private void Руководители_Load(object sender, EventArgs e)
        {
            this.руководителиTableAdapter.Fill(this.сИЗDataSet.Руководители);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.headFilterTextBox.Text = string.Empty;
        }

        private void positionFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            string resultFilterText = null;
            var filterText = this.headFilterTextBox.Text;
            if (!string.IsNullOrWhiteSpace(filterText))
            {
                resultFilterText = "[ФИО] LIKE '%{filterText}%'";
            }

            this.руководителиBindingSource.Filter = resultFilterText;
        }

        private void headDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}