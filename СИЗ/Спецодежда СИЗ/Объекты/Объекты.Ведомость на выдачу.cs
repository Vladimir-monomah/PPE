using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Windows.Forms;
using Спецодежда_СИЗ.КарточкаСотрудника;
using static Спецодежда_СИЗ.СИЗDataSet;

namespace Спецодежда_СИЗ.Объекты
{
    public partial class Объекты
    {
        private СотрудникиRow сотрудник;

        private void button47_Click(object sender, EventArgs e)
        {
            var карточкаСотрудника = new Карточка_сотрудника();
            if (карточкаСотрудника.ShowDialog() == DialogResult.OK)
            {
                var выбранныйСотрудник = карточкаСотрудника.GetCurrentEmployee();
                this.textBox9.Text = выбранныйСотрудник.ФИО;
                this.сотрудник = выбранныйСотрудник;
            }
        }

        /// <summary>
        /// Сформировать отчёт на выдачу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button44_Click(object sender, EventArgs e)
        {
            DateTime dateBegin;
            DateTime dateEnd;
            if (string.IsNullOrWhiteSpace(this.textBox9.Text))
            {
                this.сотрудник = null;
            }

            if (this.onMonthRadioButton.Checked)
            {
                var choosedDate = DateTime.ParseExact(
                    this.onMonthDateTimePicker.Value.ToString("dd.MM.yyyy"),
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                dateBegin = choosedDate.AddDays(1 - choosedDate.Day);
                dateEnd = choosedDate.AddDays(
                    DateTime.DaysInMonth(choosedDate.Year, choosedDate.Month) - choosedDate.Day)
                    .AddHours(23)
                    .AddMinutes(59)
                    .AddSeconds(59)
                    .AddMilliseconds(999);
            }
            else if (this.onPeriodRadioButton.Checked)
            {
                dateBegin = DateTime.ParseExact(
                    this.onPeriodBeginDateTimePicker.Value.ToString("dd.MM.yyyy"),
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                dateEnd = DateTime.ParseExact(
                        this.onPeriodEndDateTimePicker.Value.ToString("dd.MM.yyyy"),
                        "dd.MM.yyyy",
                        CultureInfo.InvariantCulture)
                    .AddHours(23)
                    .AddMinutes(59)
                    .AddSeconds(59)
                    .AddMilliseconds(999);
            }
            else
            {
                MessageBox.Show("Выберите период формирования отчёта!");
                return;
            }

            try
            {
                this.ведомость_на_выдачуTableAdapter.Fill(this.сИЗDataSet.Ведомость_на_выдачу,
                    dateBegin,
                    dateEnd,
                    dateBegin,
                    dateEnd,
                    this.сотрудник?.Id ?? -1,
                    this.сотрудник == null ? "0" : "1",
                    this.onlyWorkingReportCheckBox.Checked.ToString());
                //var resultTable = this.getВедомостьНаВыдачуTable(dateBegin, dateEnd, this.onlyWorkingReportCheckBox.Checked);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter(
                    "IsDataNull",
                    (this.сИЗDataSet.Ведомость_на_выдачу.Rows.Count == 0).ToString()));
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)this.сИЗDataSet.Ведомость_на_выдачу));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception exception)
            {

            }
        }

        private DataTable getВедомостьНаВыдачуTable(DateTime beginDate, DateTime endDate, bool onlyWorking)
        {
            var dateFormat = "MM/dd/yyyy HH:mm:ss";
            var selectCommand = this.connection.CreateCommand();
            selectCommand.CommandText = string.Format(@"SELECT
	[Сотрудники].ФИО as ФИО,
	[Сотрудники].Должность as Должность,
	[Типы номенклатуры].Наименование as Наименование_ном,
	[карточки сотрудников].[Дата ввода в эксплуатацию] AS Дата_ввода_в_эксплуатацию,
	[карточки сотрудников].[Дата конца эксплуатации] AS Дата_конца_эксплуатации,
	[Типы номенклатуры].[Срок полезного использования] AS Срок_полезного_использования,
	[единицы измерения].Наименование as Наименование_ед_изм,
	[Сотрудники].Размер as Размер,
	[Сотрудники].Рост as Рост,
	COUNT(*) as Количество
FROM
	(((([карточки сотрудников]
		INNER JOIN [Сотрудники] ON [карточки сотрудников].[Id_сотрудника] = [Сотрудники].Id)
		INNER JOIN номенклатура ON [карточки сотрудников].[Id_Номенклатуры] = номенклатура.[Id])
		INNER JOIN [Типы номенклатуры] ON [Типы номенклатуры].[Id_номенклатуры] = номенклатура.[Id])
		LEFT JOIN [единицы измерения] ON [единицы измерения].[Id_едИзмер] = [Типы номенклатуры].[едИзмер])
WHERE ([карточки сотрудников].[Дата ввода в эксплуатацию] BETWEEN DateValue(""{0}"") AND DateValue(""{1}"") OR
                  [карточки сотрудников].[Дата конца эксплуатации] BETWEEN DateValue(""{0}"") AND DateValue(""{1}""))
 AND ([Сотрудники].[Работающий]=-1 OR NOT(""{2}""=""True""))
GROUP BY
    [Сотрудники].ФИО,
    [Сотрудники].Должность,
	[Типы номенклатуры].Наименование,
	[карточки сотрудников].[Дата ввода в эксплуатацию],
	[карточки сотрудников].[Дата конца эксплуатации],
	[Типы номенклатуры].[Срок полезного использования],
	[единицы измерения].Наименование,
	[Сотрудники].Размер,
	[Сотрудники].Рост",
    beginDate.ToString(dateFormat),
    endDate.ToString(dateFormat),
    onlyWorking.ToString());
            /*selectCommand.Parameters.Add(new OleDbParameter("ввод_в_эксплуатацию_до", beginDate));
            selectCommand.Parameters.Add(new OleDbParameter("ввод_в_эксплуатацию_после", endDate));
            selectCommand.Parameters.Add(new OleDbParameter("конец_эксплуатации_до", beginDate));
            selectCommand.Parameters.Add(new OleDbParameter("конец_эксплуатации_после", endDate));
            selectCommand.Parameters.Add(new OleDbParameter("только_работающие", onlyWorking.ToString()));
            */
            var resultDataTable = new DataTable();
            var tableAdapter = new OleDbDataAdapter(selectCommand);
            tableAdapter.Fill(resultDataTable);

            return resultDataTable;
        }
    }
}