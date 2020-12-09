using System;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;
using Спецодежда_СИЗ.Формы;

namespace Спецодежда_СИЗ.Объекты
{
    public partial class Объекты : Form
    {
        private OleDbConnection connection;

        public Объекты()
        {
            this.InitializeComponent();
            this.InitConnection();
            this.Объекты_Load();
            Timer timer = new Timer();
        }

        public TabPage GetTabByName(string tabName)
        {
            return (TabPage)this.GetType()
                .GetField(tabName, BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(this);
        }

        private void InitConnection()
        {
            this.connection = new global::System.Data.OleDb.OleDbConnection();
            this.connection.ConnectionString = global::Спецодежда_СИЗ.Properties.Settings.Default.СИЗConnectionString1;
        }

        public void Объекты_Load()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.РуководителиЗапрос". При необходимости она может быть перемещена или удалена.
            this.руководителиЗапросTableAdapter.Fill(this.сИЗDataSet.РуководителиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.ДолжностиЗапрос". При необходимости она может быть перемещена или удалена.
            this.должностиЗапросTableAdapter.Fill(this.сИЗDataSet.ДолжностиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.сИЗDataSet.Отделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.СотрудникиЗапрос". При необходимости она может быть перемещена или удалена.
            this.сотрудникиЗапросTableAdapter.Fill(this.сИЗDataSet.СотрудникиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Нормы_выдачи". При необходимости она может быть перемещена или удалена.
            this.нормы_выдачиTableAdapter.Fill(this.сИЗDataSet.Нормы_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.сИЗDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Ведомость_на_выдачу". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыTableAdapter.Fill(this.сИЗDataSet.Типы_номенклатуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Руководители". При необходимости она может быть перемещена или удалена.
            this.руководителиTableAdapter.Fill(this.сИЗDataSet.Руководители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.единицы_измерения". При необходимости она может быть перемещена или удалена.
            this.единицы_измеренияTableAdapter.Fill(this.сИЗDataSet.единицы_измерения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Приходная_наклодная". При необходимости она может быть перемещена или удалена.
            this.приходная_наклоднаяTableAdapter.Fill(this.сИЗDataSet.Приходная_наклодная);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.номенклатура". При необходимости она может быть перемещена или удалена.
            this.номенклатураTableAdapter.Fill(this.сИЗDataSet.номенклатура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.сИЗDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.складские_остатки". При необходимости она может быть перемещена или удалена.
            this.складские_остаткиTableAdapter.Fill(this.сИЗDataSet.складские_остатки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.журнал_документов". При необходимости она может быть перемещена или удалена.
            this.журнал_документовTableAdapter.Fill(this.сИЗDataSet.журнал_документов);

            this.сотрудникиЗапросBindingSource.Filter = this.BuildWorkerCardFilter();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.карточки_сотрудников". При необходимости она может быть перемещена или удалена.
            this.карточки_сотрудниковTableAdapter.Fill(this.сИЗDataSet.карточки_сотрудников);
        }

        private void Объекты_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            string time = "";

            if (h < 10)
            {
                time += "0" + h;
            }
            else
            {
                time += h;
            }

            time += ":";

            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }

            time += ":";

            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }

            label22.Text = time;
            label27.Text = time;
            label29.Text = time;
            label31.Text = time;
            label35.Text = time;
            label37.Text = time;
            label39.Text = time;
            label8.Text = time;

            string data = "";

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            if (day < 10)
            {
                data += "0" + day;
            }
            else
            {
                data += day;
            }
            data += ".";
            if (month < 10)
            {
                data += "0" + month;
            }
            else
            {
                data += month;
            }
            data += ".";
            data += year;
            label23.Text = data;
            label26.Text = data;
            label28.Text = data;
            label30.Text = data;
            label34.Text = data;
            label36.Text = data;
            label38.Text = data;
            label7.Text = data;
        }
    }
}
