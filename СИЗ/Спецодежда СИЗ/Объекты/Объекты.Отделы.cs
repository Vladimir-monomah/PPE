using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Спецодежда_СИЗ.Формы;

namespace Спецодежда_СИЗ.Объекты
{
    public partial class Объекты
    {
        private void button4_Click_1(object sender, EventArgs e)
        {
            Новый_отдел открыть = new Новый_отдел();
            открыть.OnSaveEvent += () =>
            {
                this.отделыTableAdapter.Fill(this.сИЗDataSet.Отделы);
            };
            открыть.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.отделыTableAdapter.Update(this.сИЗDataSet);
            this.отделыTableAdapter.Fill(this.сИЗDataSet.Отделы);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = this.dataGridView1.SelectedCells[0].RowIndex;
            this.dataGridView1.Rows.RemoveAt(ind);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.отделыBindingSource.Filter = "[Наименование] Like'" + textBox4.Text + "%'";
        }
    }
}
