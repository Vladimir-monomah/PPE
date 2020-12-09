using System;

namespace Спецодежда_СИЗ.Объекты
{
    public partial class Объекты
    {
        /// <summary>
        /// Кнопка изменить номенклатуру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button25_Click(object sender, EventArgs e)
        {
            this.setReadOnlyноменклатура(false);
        }

        private void setReadOnlyноменклатура(bool mode)
        {
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = mode;
            this.размерDataGridViewTextBoxColumn.ReadOnly = mode;
            this.ростDataGridViewTextBoxColumn.ReadOnly = mode;
        }

        /// <summary>
        /// Кнопка сохранить номенклатуру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button23_Click(object sender, EventArgs e)
        {
            this.номенклатураTableAdapter.Update(this.сИЗDataSet);
            this.номенклатураTableAdapter.Fill(this.сИЗDataSet.номенклатура);
            this.setReadOnlyноменклатура(true);
        }

        /// <summary>
        /// Отобразить номенклатуру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button21_Click(object sender, EventArgs e)
        {
            this.номенклатураBindingSource.Filter = null;
            this.textBox6.Text = "";
        }

        /// <summary>
        /// Удаление номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button24_Click(object sender, EventArgs e)
        {
            int ind = this.dataGridView5.SelectedCells[0].RowIndex;
            this.dataGridView5.Rows.RemoveAt(ind);
        }

        /// <summary>
        /// Фильтрация номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.номенклатураBindingSource.Filter = "[Наименование] Like'" + this.textBox6.Text + "%'";
        }

        /// <summary>
        /// Очистить текстовое поле номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button22_Click(object sender, EventArgs e)
        {
            this.textBox6.Text = "";
        }

        /// <summary>
        /// Добавление новой номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button26_Click(object sender, EventArgs e)
        {
            Новая_номенклатура открыть = new Новая_номенклатура();
            открыть.Show();

            открыть.FormClosed += (senderForm, args) =>
            {
                this.номенклатураTableAdapter.Adapter.Fill(this.сИЗDataSet.номенклатура);
            };
        }
    }
}
