using System;
using System.Windows.Forms;
using static Спецодежда_СИЗ.СИЗDataSet;

namespace Спецодежда_СИЗ.Объекты
{
    public partial class Объекты
    {
        private bool ExistsТипНоменклатуры(Типы_номенклатурыRow типы_НоменклатурыRow)
        {
            foreach(Типы_номенклатурыRow row in this.сИЗDataSet.Типы_номенклатуры.Rows)
            {
                if(row.Наименование == типы_НоменклатурыRow.Наименование)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Добавить типы номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button42_Click(object sender, EventArgs e)
        {
            Новый_тип_номенклатуры открыть = new Новый_тип_номенклатуры();
            if (открыть.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var типНоменклатуры = открыть.GetТипНоменклатуры();
            var типыНоменклатурыTable = this.сИЗDataSet.Типы_номенклатуры;
            var newТипыНоменклатурыRow = типыНоменклатурыTable.NewТипы_номенклатурыRow();

            newТипыНоменклатурыRow.Наименование = типНоменклатуры.GroupName;
            newТипыНоменклатурыRow.Срок_полезного_использования = типНоменклатуры.UsageDaysCount;

            if(this.ExistsТипНоменклатуры(newТипыНоменклатурыRow))
            {
                MessageBox.Show($"Тип номенклатуры с названием \"{типНоменклатуры.GroupName}\" существует");
                return;
            }

            типыНоменклатурыTable.AddТипы_номенклатурыRow(newТипыНоменклатурыRow);
            this.типы_номенклатурыTableAdapter.Update(типыНоменклатурыTable);
            this.типы_номенклатурыTableAdapter.Fill(типыНоменклатурыTable);
        }

        /// <summary>
        /// Кнопка изменить тип номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button41_Click(object sender, EventArgs e)
        {
            this.setReadOnlyТип_номенклатуры(false);
        }

        private void setReadOnlyТип_номенклатуры(bool mode)
        {
            this.названиеDataGridViewTextBoxColumn.ReadOnly = mode;
            this.срокПолезногоИспользованияDataGridViewTextBoxColumn.ReadOnly = mode;
        }
        /// <summary>
        /// Кнопка сохранить тип номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button39_Click(object sender, EventArgs e)
        {
            this.типы_номенклатурыTableAdapter.Update(this.сИЗDataSet.Типы_номенклатуры);
            this.типы_номенклатурыTableAdapter.Fill(this.сИЗDataSet.Типы_номенклатуры);
            this.setReadOnlyТип_номенклатуры(true);
        }
        /// <summary>
        /// Удалить тип номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button40_Click(object sender, EventArgs e)
        {
            var deleteNomen = MessageBox.Show("Вы действительно хотите удалить тим номенклатуры?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteNomen != DialogResult.Yes)
            {
                return;
            }
            int ind = this.dataGridView8.SelectedCells[0].RowIndex;
            this.dataGridView8.Rows.RemoveAt(ind);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.типыНоменклатурыBindingSource.Filter = "[Наименование] Like'" + this.textBox8.Text + "%'";
        }
        /// <summary>
        /// Очистить текстовое поле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button43_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }
    }
}
