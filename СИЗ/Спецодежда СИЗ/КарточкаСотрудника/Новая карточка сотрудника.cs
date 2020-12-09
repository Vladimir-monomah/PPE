using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Спецодежда_СИЗ.Объекты.Enums;
using Спецодежда_СИЗ.СИЗDataSetTableAdapters;
using Спецодежда_СИЗ.Формы;
using static Спецодежда_СИЗ.СИЗDataSet;

namespace Спецодежда_СИЗ.КарточкаСотрудника
{
    public partial class Новая_карточка_сотрудника : Form
    {
        private Dictionary<string, string[]> sexToHeightMap = new Dictionary<string, string[]>
        {
            //{
            //    "Нет",
            //    new string[0]
            //},
            {
                "Мужской",
                new string[]
                {
                    "158",
                    "164",
                    "170",
                    "176",
                    "182",
                    "188",
                    "194",
                    "200",
                }
            },
            {
                "Женский",
                new string[]
                {
                    "146",
                    "152",
                    "158",
                    "164",
                    "170",
                    "176",
                    "182",
                    "188",
                }
            }
        };

        private Dictionary<ComboBox, SizeMapInfo> comboboxToSizeTypeMap;
        private Dictionary<string, int> stringKindSizeToIntKindSizeMap = new Dictionary<string, int>
        {
            { "РФ", 1 },
            { "Межд", 2 },
            { "EU", 3 }
        };

        private СотрудникиRow сотрудник;

        private РуководителиTableAdapter руководителиTableAdapter;
        private ДолжностиTableAdapter должностиTableAdapter;
        private СИЗDataSet parentсИЗDataSet;

        public Новая_карточка_сотрудника(ДолжностиTableAdapter должностиTableAdapter, РуководителиTableAdapter руководителиTableAdapter, СИЗDataSet сИЗDataSet)
        {
            this.InitializeComponent();

            this.руководителиTableAdapter = руководителиTableAdapter;
            this.должностиTableAdapter = должностиTableAdapter;
            this.parentсИЗDataSet = сИЗDataSet;

            var tooltipManager = new ToolTip();
            tooltipManager.SetToolTip(this.button62, "Ввод из справочника");
            tooltipManager.SetToolTip(this.button63, "Ввод из справочника");

            this.checkBoxAutomatically.Checked = true;
            this.textBoxNomer.Text = "0";

            this.comboboxToSizeTypeMap = new Dictionary<ComboBox, SizeMapInfo>
            {
                { this.comboBoxRazmOd, new SizeMapInfo(AccessoriesTypes.Clother, this.comboBox13) },
                { this.comboBoxRazmOb, new SizeMapInfo(AccessoriesTypes.Shoose, this.comboBox12) },
                { this.comboBoxRazmGolUb, new SizeMapInfo(AccessoriesTypes.Headdress, this.comboBox11) },
                { this.comboBoxZimOb, new SizeMapInfo(AccessoriesTypes.WinterShoose, this.comboBox10) },
                { this.comboBoxRazmPer,new SizeMapInfo( AccessoriesTypes.Gloves, this.comboBox9) },
            };
        }

        private void Новая_карточка_сотрудника_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Спецодежда_по_нормам". При необходимости она может быть перемещена или удалена.
            this.спецодежда_по_нормамTableAdapter.Fill(this.сИЗDataSet.Спецодежда_по_нормам);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сИЗDataSet.Размеры". При необходимости она может быть перемещена или удалена.
            this.размерыTableAdapter.Fill(this.сИЗDataSet.Размеры);
        }

        public void LoadКарточка_сотрудника(СотрудникиЗапросRow сотрудник)
        {
            this.сотрудник = EntityManager.FilterEmployees($"Id = {сотрудник.Id}").FirstOrDefault();
            this.textBoxNomer.Text = сотрудник.IsНомер_карточкиNull() ? "0" : сотрудник.Номер_карточки.ToString();
            this.textBoxFIO.Text = сотрудник.ФИО;
            this.textBoxDol.Text = сотрудник.IsДолжностьNull() ? string.Empty : сотрудник.Должность;
            this.textBoxHead.Text = сотрудник.IsРуководительNull() ? string.Empty : сотрудник.Руководитель;
            this.textBoxPersonalNumber.Text = сотрудник.Табельный_номер.ToString();
            this.ReceiptDateTimePicker.Enabled = false;
            this.ReceiptDateTimePicker.Value = сотрудник.Дата_поступления;
            this.DateJobChancheTimePicker.Enabled = false;
            this.DateJobChancheTimePicker.Value = сотрудник.Дата_изменения_должности;
            this.DateJobChancheTimePicker.Enabled = true;
            this.label22.Text = сотрудник.ФИО;
            this.firedCheckBox.Checked = !сотрудник.Работающий;

            if (!сотрудник.IsПолNull())
            {
                this.comboBoxPol.SelectedIndex = this.comboBoxPol.Items.IndexOf(сотрудник.Пол);
            }

            if (!сотрудник.IsРостNull())
            {
                this.comboBoxRost.SelectedIndex = this.comboBoxRost.Items.IndexOf(сотрудник.Рост.ToString());
            }
            
            if (!сотрудник.IsРазмер_одеждыNull())
            {
                var currentSizeKind = this.GetSizeKindMap(сотрудник.Размер_одежды);
                this.comboBoxRazmOd.SelectedIndex = this.comboBoxRazmOd.Items.IndexOf(currentSizeKind.Key);
                var selectingItem = this.GetSelectingItem(this.comboBox13, сотрудник.Размер_одежды);
                this.comboBox13.SelectedIndex = this.comboBox13.Items.IndexOf(selectingItem);
            }

            if (!сотрудник.IsРазмер_обувиNull())
            {
                var currentSizeKind = this.GetSizeKindMap(сотрудник.Размер_обуви);
                this.comboBoxRazmOb.SelectedIndex = this.comboBoxRazmOb.Items.IndexOf(currentSizeKind.Key);
                var selectingItem = this.GetSelectingItem(this.comboBox12, сотрудник.Размер_обуви);
                this.comboBox12.SelectedIndex = this.comboBox12.Items.IndexOf(selectingItem);
            }

            if (!сотрудник.IsРазмер_зимней_обувиNull())
            {
                var currentSizeKind = this.GetSizeKindMap(сотрудник.Размер_зимней_обуви);
                this.comboBoxZimOb.SelectedIndex = this.comboBoxZimOb.Items.IndexOf(currentSizeKind.Key);
                var selectingItem = this.GetSelectingItem(this.comboBox10, сотрудник.Размер_зимней_обуви);
                this.comboBox10.SelectedIndex = this.comboBox10.Items.IndexOf(selectingItem);
            }

            if (!сотрудник.IsРазмер_головного_убораNull())
            {
                var currentSizeKind = this.GetSizeKindMap(сотрудник.Размер_головного_убора);
                this.comboBoxRazmGolUb.SelectedIndex = this.comboBoxRazmGolUb.Items.IndexOf(currentSizeKind.Key);
                var selectingItem = this.GetSelectingItem(this.comboBox11, сотрудник.Размер_головного_убора);
                this.comboBox11.SelectedIndex = this.comboBox11.Items.IndexOf(selectingItem);
            }

            if (!сотрудник.IsРазмер_перчатокNull())
            {
                var currentSizeKind = this.GetSizeKindMap(сотрудник.Размер_перчаток);
                this.comboBoxRazmPer.SelectedIndex = this.comboBoxRazmPer.Items.IndexOf(currentSizeKind.Key);
                var selectingItem = this.GetSelectingItem(this.comboBox9, сотрудник.Размер_перчаток);
                this.comboBox9.SelectedIndex = this.comboBox9.Items.IndexOf(selectingItem);
            }

            this.спецодежда_по_нормам_запросTableAdapter.Fill(this.сИЗDataSet.Спецодежда_по_нормам_запрос, сотрудник.Id);
            this.история_выдач_запросTableAdapter.Fill(this.сИЗDataSet.История_выдач_запрос, this.сотрудник.Id);
        }

        private DataRowView GetSelectingItem(ComboBox dataComponent, int id)
        {
            foreach(var dataRow in dataComponent.Items)
            {
                var currentDataRow = dataRow as DataRowView;
                var sizesRow = currentDataRow?.Row as РазмерыЗапросRow;
                if (sizesRow?.Id == id)
                {
                    return currentDataRow;
                }
            }

            return null;
        }

        private KeyValuePair<string, int> GetSizeKindMap(int idSize)
        {
            var selectRazmByIdCommand = this.размерыЗапросTableAdapter.Connection.CreateCommand();
            var sizesAdapter = this.размерыЗапросTableAdapter.Adapter;
            selectRazmByIdCommand.CommandText = "SELECT * from " +
                $"`Размеры` " +
                $"WHERE Id = {idSize}";
            var sizesDataTable = new РазмерыЗапросDataTable();
            sizesAdapter.SelectCommand = selectRazmByIdCommand;
            sizesAdapter.Fill(sizesDataTable);
            var clotherSize = sizesDataTable.First();
            return this.stringKindSizeToIntKindSizeMap
                .FirstOrDefault(stringIntKindSize => stringIntKindSize.Value == clotherSize.Вид_размера);
        }

        private bool CheckTextBoxes()
        {
            if (this.textBoxNomer.Text == "" || this.textBoxFIO.Text == "" || this.textBoxDol.Text == "" ||
                this.textBoxPersonalNumber.Text == "" || this.ReceiptDateTimePicker.Value.ToString() == "")
            {
                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните необходимые поля!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idEmployee = this.сотрудник?.Id;
            var adapter = new СотрудникиTableAdapter();
            adapter.Fill(EntityManager.EmployeesDataTable);
            var savingEmployee = EntityManager.EmployeesDataTable.FindById(idEmployee ?? -1)
                ?? EntityManager.EmployeesDataTable.NewСотрудникиRow();
            var cardNumber = Convert.ToInt32(this.textBoxNomer.Text);
            var personalNumber = Convert.ToInt32(this.textBoxPersonalNumber.Text);
            if (this.IsEmployeeNumbersExists(savingEmployee, cardNumber, personalNumber))
            {
                MessageBox.Show("Неверно введены данные! Проверте номер карточки или табельный номер",
                    "Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            if (!this.checkBoxAutomatically.Checked)
            {
                savingEmployee.Номер_карточки = cardNumber;
            }

            savingEmployee.ФИО = this.textBoxFIO.Text;
            savingEmployee.Должность = this.textBoxDol.Text;
            savingEmployee.Руководитель = this.textBoxHead.Text;
            savingEmployee.Табельный_номер = personalNumber;
            savingEmployee.Дата_поступления = this.ReceiptDateTimePicker.Value
                .AddHours(-this.ReceiptDateTimePicker.Value.Hour)
                .AddMinutes(-this.ReceiptDateTimePicker.Value.Minute)
                .AddSeconds(-this.ReceiptDateTimePicker.Value.Second)
                .AddMilliseconds(-this.ReceiptDateTimePicker.Value.Millisecond);
            savingEmployee.Дата_изменения_должности = this.DateJobChancheTimePicker.Value
                .AddHours(-this.DateJobChancheTimePicker.Value.Hour)
                .AddMinutes(-this.DateJobChancheTimePicker.Value.Minute)
                .AddSeconds(-this.DateJobChancheTimePicker.Value.Second)
                .AddMilliseconds(-this.DateJobChancheTimePicker.Value.Millisecond);
            savingEmployee.Пол = (string)this.comboBoxPol.SelectedItem;
            if (this.comboBoxRost.SelectedIndex > -1)
            {
                savingEmployee.Рост = Convert.ToInt32(this.comboBoxRost.SelectedItem);
            }

            savingEmployee.Работающий = !this.firedCheckBox.Checked;

            var sizeValue = ((this.comboBox13.SelectedItem as DataRowView)?.Row as РазмерыЗапросRow)?.Id;
            if (sizeValue.HasValue)
            {
                savingEmployee.Размер_одежды = sizeValue.Value;
            }

            sizeValue = ((this.comboBox12.SelectedItem as DataRowView)?.Row as РазмерыЗапросRow)?.Id;
            if (sizeValue.HasValue)
            {
                savingEmployee.Размер_обуви = sizeValue.Value;
            }

            sizeValue = ((this.comboBox11.SelectedItem as DataRowView)?.Row as РазмерыЗапросRow)?.Id;
            if (sizeValue.HasValue)
            {
                savingEmployee.Размер_головного_убора = sizeValue.Value;
            }

            sizeValue = ((this.comboBox10.SelectedItem as DataRowView)?.Row as РазмерыЗапросRow)?.Id;
            if (sizeValue.HasValue)
            {
                savingEmployee.Размер_зимней_обуви = sizeValue.Value;
            }

            sizeValue = ((this.comboBox9.SelectedItem as DataRowView)?.Row as РазмерыЗапросRow)?.Id;
            if (sizeValue.HasValue)
            {
                savingEmployee.Размер_перчаток = sizeValue.Value;
            }

            try
            {
                if (this.сотрудник == null)
                {
                    EntityManager.EmployeesDataTable.AddСотрудникиRow(savingEmployee);
                    if (savingEmployee.IsНомер_карточкиNull())
                    {
                        var сотрудникиTableAdapter = new СотрудникиTableAdapter();
                        сотрудникиTableAdapter.Connection.Open();
                        var nextNumberComand = сотрудникиTableAdapter.Connection.CreateCommand();
                        nextNumberComand.CommandText = "SELECT MAX([Номер карточки]) FROM Сотрудники";
                        var nextNumber =(int) nextNumberComand.ExecuteScalar();
                           savingEmployee.Номер_карточки = nextNumber + 1;
                    }
                    EntityManager.UpdateEmployees();
                }
                else
                {
                    var сотрудникиTableAdapter = new СотрудникиTableAdapter();
                    сотрудникиTableAdapter.Adapter.Update(savingEmployee.Table);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(
                    "Ошибка при добавлении/изменении! \r\n" + exception.ToString(),
                    "Ошибка",
                    MessageBoxButtons.OK);
                return;
            }

            var message = this.сотрудник == null
                ? "Добавление прошло успешно!"
                : "Изменение завершено успешно!";

            MessageBox.Show(message, "Информация", MessageBoxButtons.OK);
            this.Close();
        }

        private bool IsEmployeeNumbersExists(СотрудникиRow savingEmployee, int cardNumber, int personalNumber)
        {
            foreach (var employee in EntityManager.EmployeesDataTable)
            {
                if((employee.Номер_карточки == cardNumber || employee.Табельный_номер == personalNumber)
                    && (savingEmployee.IsNull(0) || employee.Id != savingEmployee.Id))
                {
                    return true;
                }
            }

            return false;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!this.sexToHeightMap.TryGetValue(this.comboBoxPol.SelectedItem.ToString(), out var heightArray))
            {
                throw new Exception("Выбран неправильный пол");
            }

            this.comboBoxRost.Items.Clear();
            this.comboBoxRost.Items.AddRange(heightArray);
        }

        private void comboBoxRazm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboboxSender = (ComboBox)sender;
            if (!this.comboboxToSizeTypeMap.TryGetValue(comboboxSender, out var sizeMapInfo))
            {
                MessageBox.Show("Неправильно выбран тип принадлежности размера", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.stringKindSizeToIntKindSizeMap.TryGetValue(comboboxSender.SelectedItem.ToString(), out var sizeKind))
            {
                MessageBox.Show("Неправильно выбран вид размера", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var intAccessoryType = (int)sizeMapInfo.AccessoryType;
            var sizeDataTable = this.размерыЗапросTableAdapter.GetData(intAccessoryType, sizeKind);
            sizeMapInfo.SizeValueComboBox.DataSource = sizeDataTable;
            sizeMapInfo.SizeValueComboBox.SelectedIndex = -1;
        }

        private class SizeMapInfo
        {
            public SizeMapInfo(AccessoriesTypes accessoryType, ComboBox sizeValueComboBox)
            {
                this.AccessoryType = accessoryType;
                this.SizeValueComboBox = sizeValueComboBox;
            }

            public AccessoriesTypes AccessoryType { get; }

            public ComboBox SizeValueComboBox { get; }
        }

        private void checkBoxAutomatically_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxNomer.Enabled = !this.checkBoxAutomatically.Checked;
            if(this.сотрудник != null)
            {
                this.textBoxNomer.Text = this.сотрудник.Номер_карточки.ToString();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действиетльно хотите закрыть данную вкладку?",
                "Закрытие вкладки", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var историяВыдачЗапрос = this.сИЗDataSet.История_выдач_запрос;
            лицевая_сторона_карточки открыть = new лицевая_сторона_карточки(историяВыдачЗапрос);
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните необходимые поля!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.история_выдач_запросTableAdapter.Fill(историяВыдачЗапрос, this.сотрудник.Id);

            var fio = this.сотрудник.ФИО.Split(' ');
            var сотрудникInfo = new Dictionary<string, string>()
            {
                { "Surname", fio[0] },
                { "Name", fio[1] },
                { "Patronymic", fio[2] },
                { "Height", this.comboBoxRost.SelectedItem?.ToString() },
                { "Sex", this.comboBoxPol.SelectedItem?.ToString() },
                { "ClotherSize", this.comboBox13.Text },
                { "ShoseSize", this.comboBox12.Text },
                { "WinterShoseSize", this.comboBox11.Text },
                { "HeadwearSize", this.comboBox10.Text },
                { "GloveSize", this.comboBox9.Text },
                { "Nomer", this.textBoxNomer.Text },
                { "TabNomer", this.textBoxPersonalNumber.Text },
                { "Dol", this.textBoxDol.Text },
                { "Picker", this.ReceiptDateTimePicker.Text },
                { "IsHistoryEmpty", (историяВыдачЗапрос.Rows.Count == 0).ToString() }
            };
            сотрудникInfo = сотрудникInfo.Where(kvp => !string.IsNullOrEmpty(kvp.Value))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            открыть.InitReport(сотрудникInfo);
            открыть.Show();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            var окноДолжности = new Должности();
            if(окноДолжности.ShowDialog() == DialogResult.OK)
            {
                this.textBoxDol.Text = окноДолжности.ПолучитьДолжность();
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            var открыть = new Руководители();
            if (открыть.ShowDialog() == DialogResult.OK)
            {
                this.textBoxHead.Text = открыть.ПолучитьРуководителя();
            }
        }

        private void buttonAddRate_Click(object sender, EventArgs e)
        {
            Нормы_выдачи открыть = new Нормы_выдачи();
            открыть.Show();
        }

        private void buttonPickUpWarehouse_Click(object sender, EventArgs e)
        {
            Типы_номенклатуры открыть = new Типы_номенклатуры();
            if (открыть.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (this.сотрудник == null || this.сотрудник.IsNull("Id"))
            {
                MessageBox.Show("Сотрудник должен быть сохранён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var newSpecialClother = this.сИЗDataSet.Спецодежда_по_нормам.NewСпецодежда_по_нормамRow();

            var choosedNomencl = (Типы_номенклатурыRow)открыть.GetChoosedRow();
            if(choosedNomencl == null)
            {
                MessageBox.Show("Не была выбрана строка с номенклатурой", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            newSpecialClother.Наименование = choosedNomencl.Наименование;
            var now = DateTime.Now;
            newSpecialClother.Дата_получения_спецодежды = now;
            int срокПолезногоИспользования = choosedNomencl.IsСрок_полезного_использованияNull()
                ? 0
                : choosedNomencl.Срок_полезного_использования;
            newSpecialClother.Следующее_получение = now.AddDays(срокПолезногоИспользования);
            newSpecialClother.Срок_полезного_использования = срокПолезногоИспользования;
            newSpecialClother.Сотрудник = this.сотрудник.Id;

            this.сИЗDataSet.Спецодежда_по_нормам.AddСпецодежда_по_нормамRow(newSpecialClother);
            this.UpdateСпецОдежды();
        }

        private void ReceiptDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.Enabled
                && (dateTimePicker.Value < DateTime.Now.Date
                    || dateTimePicker.Value > DateTime.Now.Date.AddDays(1).AddMilliseconds(-1)))
            {
                MessageBox.Show("Нельзя выбрать предыдующую или последующую даты","Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker.Value = DateTime.Now.Date;
                return;
            }
        }

        private void UpdateСпецОдежды()
        {
            this.спецодежда_по_нормамTableAdapter.Update(this.сИЗDataSet.Спецодежда_по_нормам);
            this.спецодежда_по_нормамTableAdapter.Fill(this.сИЗDataSet.Спецодежда_по_нормам);
            this.спецодежда_по_нормам_запросTableAdapter.Fill(this.сИЗDataSet.Спецодежда_по_нормам_запрос, this.сотрудник.Id);
            this.история_выдач_запросTableAdapter.Fill(this.сИЗDataSet.История_выдач_запрос, this.сотрудник.Id);
        }

        private void dateDeliveryButton_Click(object sender, EventArgs e)
        {
            Дата_сдачи формаИзмененияДатыСледующегоПолучения = new Дата_сдачи();
            var строкаСпецОдеждыПоНормамЗапрос = (Спецодежда_по_нормам_запросRow)((DataRowView)dataGridView10.CurrentRow.DataBoundItem).Row;
            var строкаСпецОдеждыПоНормам = this.сИЗDataSet.Спецодежда_по_нормам.FindById(строкаСпецОдеждыПоНормамЗапрос.Id);
            if (формаИзмененияДатыСледующегоПолучения.ShowDialog() == DialogResult.OK)
            {
                строкаСпецОдеждыПоНормам.Дата_сдачи = формаИзмененияДатыСледующегоПолучения.GetDateValue();
                this.UpdateСпецОдежды();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var строкаСпецОдеждыПоНормамЗапрос = (Спецодежда_по_нормам_запросRow)((DataRowView)dataGridView10.CurrentRow.DataBoundItem).Row;
            var deleteстрокаСпецОдеждыПоНормам = MessageBox.Show("Вы действиельно хотите удалить СИЗ?", "Иинформация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteстрокаСпецОдеждыПоНормам != DialogResult.Yes)
            {
                return;
            }
            using (var command = this.спецодежда_по_нормамTableAdapter.Connection.CreateCommand())
            {
                command.CommandText = $"DELETE FROM `Спецодежда по нормам` WHERE `Id` = {строкаСпецОдеждыПоНормамЗапрос.Id}";
                this.спецодежда_по_нормамTableAdapter.Connection.Open();
                command.ExecuteNonQuery();
            }

            this.UpdateСпецОдежды();
        }

        private void textBoxNomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void DateJobChancheTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.Enabled
                && (dateTimePicker.Value < DateTime.Now.Date))
            {
                MessageBox.Show("Нельзя выбрать предыдующую дату", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker.Value = DateTime.Now.Date;
                return;
            }
        }

        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
