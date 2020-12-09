using System;

namespace Спецодежда_СИЗ.Объекты
{
    public partial class Объекты
    {
        /// <summary>
        /// Кнопка изменить складские остатки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            this.setReadOnlyСкладскиеОстатки(false);
        }

        private void setReadOnlyСкладскиеОстатки(bool mode)
        {
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = mode;
            this.размерDataGridViewTextBoxColumn.ReadOnly = mode;
            this.ростDataGridViewTextBoxColumn.ReadOnly = mode;
            this.количествоDataGridViewTextBoxColumn.ReadOnly = mode;
        }

        /// <summary>
        /// Сохранить остатки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.складские_остаткиTableAdapter.Update(this.сИЗDataSet);
            this.складские_остаткиTableAdapter.Fill(this.сИЗDataSet.складские_остатки);
            this.setReadOnlyСкладскиеОстатки(true);
        }

        /// <summary>
        /// Отобразить остатки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.складскиеОстаткиBindingSource.Filter = null;
            this.textBox2.Text = "";
        }

        /// <summary>
        /// Удалить остатки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            int ind = this.dataGridView2.SelectedCells[0].RowIndex;
            this.dataGridView2.Rows.RemoveAt(ind);
        }

        /// <summary>
        /// Фильтрация складских остатков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.складскиеОстаткиBindingSource.Filter = "[Наименование] Like'" + this.textBox2.Text + "%'";
        }

        /// <summary>
        /// Очистить текстовое поле складских остатков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }
    }
}
