using System;
using System.Windows.Forms;

namespace Спецодежда_СИЗ.Объекты
{
    public partial class Объекты
    {
        /// <summary>
        /// Добавить руководителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button37_Click(object sender, EventArgs e)
        {
            Новый_руководитель открыть = new Новый_руководитель();
            открыть.OnSaveEvent += () =>
            {
                this.руководителиTableAdapter.Fill(this.сИЗDataSet.Руководители);
            };
            открыть.ShowDialog();
        }

        ///// <summary>
        ///// Кнопка изменить руководителя
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void button36_Click(object sender, EventArgs e)
        //{
        //    this.setReadOnlyРуководители(false);
        //}

        //private void setReadOnlyРуководители(bool mode)
        //{
        //    this.ФИОDataGridViewTextBoxColumn.ReadOnly = mode;
        //}

        /// <summary>
        /// Кнопка сохранить руководителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button34_Click(object sender, EventArgs e)
        {
            this.руководителиTableAdapter.Update(this.сИЗDataSet);
            this.руководителиTableAdapter.Fill(this.сИЗDataSet.Руководители);
            //this.setReadOnlyРуководители(true);
        }

        /// <summary>
        /// Кнопка удалить руководителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button35_Click(object sender, EventArgs e)
        {
            var deleteHead = MessageBox.Show("Вы действительно хотите удалить данного руководителя?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteHead != DialogResult.Yes)
            {
                return;
            }
            int ind = this.dataGridView7.SelectedCells[0].RowIndex;
            this.dataGridView7.Rows.RemoveAt(ind);
        }

        /// <summary>
        /// Очистить текстовое поле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button38_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = "";
        }

        /// <summary>
        /// Фильтрация руководителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.руководителиЗапросBindingSource.Filter = "[Руководитель] Like'" + this.textBox7.Text + "%'";
        }
    }
}
