using System;
using System.Windows.Forms;

namespace Спецодежда_СИЗ
{
    public partial class О_программе : Form
    {
        public О_программе()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Благодарности открыть = new Благодарности();
            открыть.ShowDialog();
        }
    }
}
