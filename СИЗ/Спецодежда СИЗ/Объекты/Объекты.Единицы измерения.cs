using System;

namespace Спецодежда_СИЗ.Объекты
{
    public partial class Объекты
    {
        /// <summary>
        /// Кнопка изменить ед.Измерения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button30_Click(object sender, EventArgs e)
        {
            this.setReadOnlyединицыИзмерения(false);
        }

        private void setReadOnlyединицыИзмерения(bool mode)
        {
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = mode;
        }

        /// <summary>
        /// Кнопка удалить единицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button29_Click(object sender, EventArgs e)
        {
            int ind = this.dataGridView6.SelectedCells[0].RowIndex;
            this.dataGridView6.Rows.RemoveAt(ind);
        }

        /// <summary>
        /// Сохранение измерений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button33_Click(object sender, EventArgs e)
        {
            this.единицы_измеренияTableAdapter.Update(this.сИЗDataSet);
            this.единицы_измеренияTableAdapter.Fill(this.сИЗDataSet.единицы_измерения);
            this.setReadOnlyединицыИзмерения(true);
        }

        /// <summary>
        /// Очистить текстовое поле измерений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button32_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        /// <summary>
        /// Фильрация измерений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.единицыИзмеренияBindingSource.Filter = "[Наименование] Like'" + this.textBox1.Text + "%'";
        }

        /// <summary>
        /// Добавление единиц измерения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button31_Click(object sender, EventArgs e)
        {
            Единицы_измернеия открыть = new Единицы_измернеия();
            открыть.Show();

            открыть.FormClosed += (senderForm, args) =>
            {
                this.единицы_измеренияTableAdapter.Fill(this.сИЗDataSet.единицы_измерения);
            };
        }
    }
}
