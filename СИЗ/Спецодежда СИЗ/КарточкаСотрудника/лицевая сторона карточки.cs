using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Спецодежда_СИЗ.КарточкаСотрудника
{
    public partial class лицевая_сторона_карточки : Form
    {
        private DataTable история_выдач_запрос;

        public лицевая_сторона_карточки(СИЗDataSet.История_выдач_запросDataTable история_выдач_запрос)
        {
            this.история_выдач_запрос = история_выдач_запрос;
            InitializeComponent();
        }

        public void InitReport(Dictionary<string, string> сотрудник)
        {
            var localReport = this.reportViewer2.LocalReport;
            foreach(var kvpInfo in сотрудник)
            {
                localReport.SetParameters(new ReportParameter(
                   kvpInfo.Key,
                   kvpInfo.Value));
            }

            this.reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", this.история_выдач_запрос));
            this.reportViewer2.RefreshReport();
        }
    }
}
