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
    public partial class Должности : Form
    {
        public Должности()
        {
            InitializeComponent();
        }

        public string ПолучитьДолжность()
        {
            return ((ДолжностиRow)((DataRowView)this.positionDataGridView.CurrentRow?.DataBoundItem)?.Row)?.Название;
        }

        private void Должности_Load(object sender, EventArgs e)
        {
            this.должностиTableAdapter.Fill(this.сИЗDataSet.Должности);
        }

        private void positionDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.positionFilterTextBox.Text = string.Empty;
        }

        private void positionFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            string resultFilterText = null;
            var filterText = this.positionFilterTextBox.Text;
            if (!string.IsNullOrWhiteSpace(filterText))
            {
                resultFilterText = "[Название] LIKE '%{filterText}%'";
            }

            this.должностиBindingSource.Filter = resultFilterText;
        }
    }
}
