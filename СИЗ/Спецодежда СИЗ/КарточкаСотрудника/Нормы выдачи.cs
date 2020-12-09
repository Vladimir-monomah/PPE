using System;
using System.Windows.Forms;

namespace Спецодежда_СИЗ
{
    public partial class Нормы_выдачи : Form
    {
        public Нормы_выдачи()
        {
            InitializeComponent();
        }

        private void Нормы_выдачи_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Нормы_выдачи". При необходимости она может быть перемещена или удалена.
            this.нормы_выдачиTableAdapter.Fill(this.сИЗDataSet.Нормы_выдачи);

        }
    }
}
