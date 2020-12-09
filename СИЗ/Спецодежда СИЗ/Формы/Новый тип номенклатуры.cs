using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Спецодежда_СИЗ
{
    public partial class Новый_тип_номенклатуры : Form
    {
        private Dictionary<string, double> koefficientsByPeriodName = new Dictionary<string, double>
        {
            { "дней", 1 },
            { "месяцев", 30.4 },
            { "лет", 365.25 }
        };

        public Новый_тип_номенклатуры()
        {
            InitializeComponent();
        }

        public ТипНоменклатуры GetТипНоменклатуры()
        {
            return new ТипНоменклатуры
            {
                GroupName = this.groupNameTextBox.Text,
                UsageDaysCount = this.ConvertToDays(this.countPeriodNumericUpDown.Value, (string)this.periodComboBox.SelectedItem)
            };
        }

        private int ConvertToDays(decimal value, string periodName)
        {
            if(!this.koefficientsByPeriodName.TryGetValue(periodName, out var koefficient))
            {
                throw new Exception("Не выбран период");
            }

            return (int)Math.Round(((double)value) * koefficient, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var validateResult = this.ValidateFields();
            if (!string.IsNullOrEmpty(validateResult))
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show(validateResult);
            }
        }

        private string ValidateFields()
        {
            var periodName = (string)this.periodComboBox.SelectedItem;
            if(string.IsNullOrEmpty(periodName)
                || !this.koefficientsByPeriodName.ContainsKey(periodName))
            {
                return "Не выбран период";
            }

            if(string.IsNullOrEmpty(this.groupNameTextBox.Text))
            {
                return "Не заполнено наименование";
            }

            return null;
        }
    }

    public class ТипНоменклатуры
    {
        public string GroupName { get; set; }

        public int UsageDaysCount { get; set; }
    }
}
