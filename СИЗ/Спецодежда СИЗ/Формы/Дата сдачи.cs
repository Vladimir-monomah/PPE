using System;
using System.Windows.Forms;

namespace Спецодежда_СИЗ.Формы
{
    public partial class Дата_сдачи : Form
    {
        public Дата_сдачи()
        {
            InitializeComponent();
        }

        public DateTime GetDateValue()
        {
            return this.dateTimePicker1.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.Enabled
                && (dateTimePicker.Value < DateTime.Now.Date
                    || dateTimePicker.Value > DateTime.Now.Date.AddDays(1).AddMilliseconds(-1)))
            {
                MessageBox.Show("Нельзя выбрать предыдующую или последующую даты", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker.Value = DateTime.Now.Date;
                return;
            }
        }
    }
}