namespace Спецодежда_СИЗ.Объекты
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Windows.Forms;
    using Спецодежда_СИЗ.Properties;
    using Спецодежда_СИЗ.КарточкаСотрудника;
    using Спецодежда_СИЗ.СИЗDataSetTableAdapters;
    using static Спецодежда_СИЗ.СИЗDataSet;

    public partial class Объекты
    {
        /// <summary>
        /// Добавить нового сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Новая_карточка_сотрудника открыть = new Новая_карточка_сотрудника(this.должностиTableAdapter, this.руководителиTableAdapter, this.сИЗDataSet);
            открыть.ShowDialog();

            this.сотрудникиЗапросTableAdapter.Fill(this.сИЗDataSet.СотрудникиЗапрос);
        }

        /// <summary>
        /// Импортирует данные из Exel-файла, выбранного в окне диалога
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImport_Click(object sender, EventArgs e)
        {
            СотрудникиDataTable employes = this.сИЗDataSet.Сотрудники;
            this.сотрудникиTableAdapter.Fill(employes);
            this.ImportDataFromExcel(
                this.GetImportingExcelFileName(),
                employes,
                new[] { "Табельный_номер" });
            this.сотрудникиTableAdapter.Update(employes);
            this.Объекты_Load();
        }

        /// <summary>
        /// Экспорт файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int i = 0; i < this.dataGridView.Columns.Count; i++)
            {
                var cellCaption = this.dataGridView.Columns[i].HeaderText;
                var bracketIndex = cellCaption.IndexOf('(') - 1;
                if (bracketIndex > -1)
                {
                    cellCaption = cellCaption.Substring(0, bracketIndex);
                }

                cellCaption = cellCaption.Replace("Табельный номер", "Табельный_номер");

                ExcelWorkSheet.Cells[1, i + 1] = cellCaption;
            }
            for (int i = 0; i < this.dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < this.dataGridView.Columns.Count; j++)
                {
                    ExcelWorkSheet.Cells[i + 2, j + 1] = this.dataGridView.Rows[i].Cells[j].Value.ToString();
                    if(!this.dataGridView.Columns[j].Visible)
                    {
                        ExcelWorkSheet.Cells[i + 2, j + 1].ColumnWidth = 0;
                    }
                }
            }

            for (int j = 0; j < this.dataGridView.Columns.Count; j++)
            {
                if (this.dataGridView.Columns[j].Visible)
                {
                    ExcelWorkSheet.Columns[j + 1].AutoFit();
                }
            }
            ExcelApp.Visible = true;
        }


        /// <summary>
        /// Кнопка удалить строку сотрудника из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var idEmployee = ((СотрудникиЗапросRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.Id;
            if (!idEmployee.HasValue)
            {
                return;
            }

            var deleteEmployeeQuestionResult = MessageBox.Show("Вы действительно хотите удалить сотрудника?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteEmployeeQuestionResult != DialogResult.Yes)
            {
                return;
            }

            using (var connection = new OleDbConnection(Settings.Default.СИЗConnectionString1))
            {
                connection.Open();
                using (var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = $"DELETE FROM Сотрудники WHERE Id = {idEmployee.Value}";
                    sqlCommand.ExecuteNonQuery();
                }
            }

            this.Объекты_Load();
        }

        /// <summary>
        /// Открывает окно на редактирование сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Новая_карточка_сотрудника открыть = new Новая_карточка_сотрудника(this.должностиTableAdapter, this.руководителиTableAdapter, this.сИЗDataSet);
            открыть.LoadКарточка_сотрудника(
                (СотрудникиЗапросRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row);
            открыть.ShowDialog();

            this.сотрудникиЗапросTableAdapter.Fill(this.сИЗDataSet.СотрудникиЗапрос);
        }

        /// <summary>
        /// Кнопка изменить сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.setReadOnlyсотрудники(false);
        }

        private void setReadOnlyсотрудники(bool mode)
        {
            // this.фИОDataGridViewTextBoxColumn.ReadOnly = mode;
            // this.должностьDataGridViewTextBoxColumn.ReadOnly = mode;
            // this.номенклатураDataGridViewTextBoxColumn.ReadOnly = mode;
            // this.датаВводаВЭксплуатациюDataGridViewTextBoxColumn.ReadOnly = mode;
            // this.датаКонцаЭксплуатацииDataGridViewTextBoxColumn.ReadOnly = mode;
            // this.срокПолезногоИспользованияDataGridViewTextBoxColumn.ReadOnly = mode;
        }

        /// <summary>
        /// Очистить текстовое поле сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
        }

        #region Фильтрация отображаемых
        /// <summary>
        /// фильтрация сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.сотрудникиЗапросBindingSource.Filter = this.BuildWorkerCardFilter();
        }

        /// <summary>
        /// Кнопка отобразить сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.сотрудникиЗапросBindingSource.Filter = null;
            this.textBox3.Text = "";
        }

        internal void onlyWorkingFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.сотрудникиЗапросBindingSource.Filter = this.BuildWorkerCardFilter();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            var deltaCoordinates = this.onlyWorkingFilterCheckBox.Height;
            if (this.onlyWorkingFilterCheckBox.Visible)
            {
                this.buttonFilter.BackColor = Color.Transparent;
                deltaCoordinates = -deltaCoordinates;
            }
            else
            {
                this.buttonFilter.BackColor = Color.LightSlateGray;
            }

            this.onlyWorkingFilterCheckBox.Visible = !this.onlyWorkingFilterCheckBox.Visible;

            this.dataGridView.Top += deltaCoordinates;
            this.dataGridView.Height -= deltaCoordinates;
            this.label5.Top += deltaCoordinates;
            this.textBox3.Top += deltaCoordinates;
            this.button11.Top += deltaCoordinates;
        }

        private string BuildWorkerCardFilter()
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.textBox3.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("(([ФИО] Like '%{0}%') OR ([Должность] Like '%{0}%'))", fieldFilter));
            }

            if (this.onlyWorkingFilterCheckBox.Checked)
            {
                filterExpressionList.Add("[Работающий]");
            }

            return string.Join(" AND ", filterExpressionList);
        }
        #endregion
    }
}