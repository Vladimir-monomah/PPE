//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Спецодежда_СИЗ.Объекты
//{
//    public partial class Объекты
//    {
//        /// <summary>
//        /// Кнопка изменить журнал документов
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void button20_Click(object sender, EventArgs e)
//        {
//            this.setReadOnlyЖурналДокументов(false);
//        }

//        private void setReadOnlyЖурналДокументов(bool mode)
//        {
//            this.номерDataGridViewTextBoxColumn.ReadOnly = mode;
//            this.типДокументаDataGridViewTextBoxColumn.ReadOnly = mode;
//            this.операцияDataGridViewTextBoxColumn.ReadOnly = mode;
//            this.датаDataGridViewTextBoxColumn.ReadOnly = mode;
//        }

//        /// <summary>
//        /// Кнопка сохранить журнал документов
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void button17_Click(object sender, EventArgs e)
//        {
//            this.журнал_документовTableAdapter.Update(this.сИЗDataSet);
//            this.журнал_документовTableAdapter.Fill(this.сИЗDataSet.журнал_документов);
//            this.setReadOnlyЖурналДокументов(true);
//        }

//        /// <summary>
//        /// Отобразить документы
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void button2_Click(object sender, EventArgs e)
//        {
//            this.журналДокументовBindingSource.Filter = null;
//            this.textBox4.Text = "";
//        }

//        /// <summary>
//        /// Удалить строки из журналов документов
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void button19_Click(object sender, EventArgs e)
//        {
//            int ind = this.dataGridView3.SelectedCells[0].RowIndex;
//            this.dataGridView3.Rows.RemoveAt(ind);
//        }

//        /// <summary>
//        /// Фильрация документов
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void textBox4_TextChanged(object sender, EventArgs e)
//        {
//            this.журналДокументовBindingSource.Filter = "[Операция] Like'" + this.textBox4.Text + "%'";
//        }

//        /// <summary>
//        /// Очистить текстовое поле журнала документов
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void button18_Click(object sender, EventArgs e)
//        {
//            this.textBox4.Text = "";
//        }
//    }
//}
