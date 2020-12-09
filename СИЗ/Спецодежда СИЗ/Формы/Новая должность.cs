using System;
using System.Windows.Forms;
using Спецодежда_СИЗ.СИЗDataSetTableAdapters;
using static Спецодежда_СИЗ.СИЗDataSet;

namespace Спецодежда_СИЗ
{
    public delegate void OnSave();

    public delegate void OnBeforeSave(ДолжностиRow isRecordExists);

    public partial class Новая_должность : Form
    {
        public Новая_должность()
        {
            this.OnSaveEvent += () => { };
            this.OnBeforeSaveEvent += isRecordExists => { };
            InitializeComponent();
        }

        public event OnSave OnSaveEvent;

        public event OnBeforeSave OnBeforeSaveEvent;

        public void ЗагрузитьДолжность(string названиеДолжность)
        {
            this.textBoxDol.Text = названиеДолжность;
        }

        public string ПолучитьДолжность()
        {
            return this.textBoxDol.Text;
        }

        /// <summary>
        /// Проверка заполненности полей
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            if (textBoxDol.Text == "")
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Добавление новой должнсоти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxes())
            {
                MessageBox.Show("Название элемента справочника пустое и не будет сохранено.", "Информация",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            var positionName = this.textBoxDol.Text;
            var adapter = new ДолжностиTableAdapter();
            adapter.Fill(EntityManager.PositionDataTable);
            ДолжностиRow existingPosition = null;
            foreach (var position in EntityManager.PositionDataTable)
            {
                if(position.Название == positionName)
                {
                    existingPosition = position;
                    break;
                }
            }

            if (existingPosition != null)
            {
                this.OnBeforeSaveEvent(existingPosition);
                if (MessageBox.Show(
                    "Должность с таким именем уже существует!\r\nОбновить информацию по текущей должности?",
                    "Информация",
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                existingPosition.Отделы = (int)this.departmentComboBox.SelectedValue;
            }
            else
            {
                var newPosition = EntityManager.PositionDataTable.NewДолжностиRow();
                newPosition.Название = positionName;
                newPosition.Отделы = (int)this.departmentComboBox.SelectedValue;
                EntityManager.PositionDataTable.AddДолжностиRow(newPosition);
            }

            EntityManager.UpdatePosition();
            this.OnSaveEvent();

            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK);
        }

        private void textBoxDol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Новая_должность_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.сИЗDataSet.Отделы);

        }
    }
}
