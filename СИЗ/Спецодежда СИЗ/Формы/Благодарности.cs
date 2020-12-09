using System;
using System.Windows.Forms;

namespace Спецодежда_СИЗ
{
    public partial class Благодарности : Form
    {
        public Благодарности()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:vladimir-bykov-1999@mail.ru");
        }
    }
}
