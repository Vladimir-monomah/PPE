using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Спецодежда_СИЗ.СИЗDataSet;

namespace Спецодежда_СИЗ.Объекты
{
    public partial class Объекты
    {
        private bool ExistsДолжности(ДолжностиRow должностьRow)
        {
            foreach (ДолжностиRow row in this.сИЗDataSet.Должности.Rows)
            {
                if (row.Название == должностьRow.Название)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Кнопка изменить должность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            this.setReadOnlyДолжность(false);
        }

        private void setReadOnlyДолжность(bool mode)
        {
            this.названиеDataGridViewTextBoxColumn.ReadOnly = mode;
        }

        /// <summary>
        /// Сохранить должность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            this.должностиTableAdapter.Update(this.сИЗDataSet.Должности);
            this.должностиTableAdapter.Fill(this.сИЗDataSet.Должности);
           // this.setReadOnlyДолжность(true);
        }

        /// <summary>
        /// Отобразить должность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            this.складскиеОстаткиBindingSource.Filter = null;
            this.textBox5.Text = "";
        }

        /// <summary>
        /// Удаление должности из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            var deleteDol = MessageBox.Show("Вы действительно хотите удалить данную должность?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDol != DialogResult.Yes)
            {
                return;
            }
            int ind = this.dataGridView4.SelectedCells[0].RowIndex;
            this.dataGridView4.Rows.RemoveAt(ind);
        }

        /// <summary>
        /// Фильтрация должности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.textBox5.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("[Название] Like '%{0}%'", fieldFilter));
            }

            this.должностиЗапросBindingSource.Filter = "[Название] Like'" + this.textBox5.Text + "%'";
        }

        /// <summary>
        /// Очистить текстовое поле должностей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = "";
        }

        /// <summary>
        /// Добавить новую должность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            Новая_должность открыть = new Новая_должность();
            открыть.OnSaveEvent += () =>
            {
                this.должностиTableAdapter.Fill(this.сИЗDataSet.Должности);
            };
            открыть.ShowDialog();
        }
    }
}
