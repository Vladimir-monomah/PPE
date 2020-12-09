﻿namespace Спецодежда_СИЗ.Объекты
{
    using System.Data;
    using System.Data.OleDb;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System;
    using System.Linq;
    using System.IO;
    using Спецодежда_СИЗ.СИЗDataSetTableAdapters;

    using static Спецодежда_СИЗ.СИЗDataSet;

    public partial class Объекты
    {
        /// <summary>
        /// Импортирует данные из Excel-файла в таблицу
        /// </summary>
        private void ImportDataFromExcel(string sourceFileName, DataTable destinationTable, IEnumerable<string> keyFields)
        {
            if (!File.Exists(sourceFileName))
            {
                MessageBox.Show("Введите имя существующего файла");
                return;
            }

            // Загрузка данных в память из файла
            var connectionString = string.Format(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\";",
                    sourceFileName);
            using (var connection = new OleDbConnection(connectionString))
            using (var adapter = new OleDbDataAdapter("SELECT * FROM [Лист1$]", connection))
            using (var excelTable = new DataTable())
            {
                adapter.Fill(excelTable);

                // Определяем общий набор полей для excel-файла и целевой таблицы
                var commonColumns = new List<string>();
                foreach (DataColumn destinationColumn in destinationTable.Columns)
                {
                    if (excelTable.Columns.Contains(destinationColumn.ColumnName))
                    {
                        commonColumns.Add(destinationColumn.ColumnName);
                    }
                }

                var nonExistingFields = keyFields
                    .Where(column => !commonColumns.Exists(keyField => keyField == column))
                    .ToList();
                if (nonExistingFields.Count > 0)
                {
                    var missingKeyFieldsMessage = "Поля \"" + string.Join("\", \"", nonExistingFields) + " \" " +
                        "обязательно должны присутствовать в импортируемых данных!";
                    throw new Exception(missingKeyFieldsMessage);
                }

                // Создание кэша строк по ключевым полям для быстрого поиска
                var destinationRowsCache = new Dictionary<string, DataRow>();
                var buildKeyFunc = new Func<DataRow, string>(
                    importingRow => string.Join("→", keyFields.Select(keyField => importingRow[keyField].ToString())));
                foreach (DataRow row in destinationTable.Rows)
                {
                    var key = buildKeyFunc(row);
                    destinationRowsCache[key] = row;
                }

                // Добавление новых строк или обновление существующих по ключевым полям
                foreach (DataRow importingRow in excelTable.Rows)
                {
                    var key = buildKeyFunc(importingRow);
                    var isNeedAdd = false;
                    if (!destinationRowsCache.TryGetValue(key, out var destinationRow))
                    {
                        destinationRow = destinationTable.NewRow();
                        isNeedAdd = true;
                    }

                    foreach (var columnName in commonColumns)
                    {
                        this.HandleColumnWithValue(columnName, destinationRow, importingRow);
                    }

                    if (isNeedAdd)
                    {
                        destinationTable.Rows.Add(destinationRow);
                    }
                }
            }
        }

        /// <summary>
        /// Обрабатывает определённым образом некоторые поля
        /// Например, если поле в целевой таблице является ссылочным,
        /// то пытаемся найти запись с импортируемым значением в другой таблице.
        /// Если не находим - создаём
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="destinationRow"></param>
        /// <param name="importingRow"></param>
        private void HandleColumnWithValue(string columnName, DataRow destinationRow, DataRow importingRow)
        {
            switch (columnName)
            {
                /*case "Работающий":
                    destinationRow[columnName] = importingRow[columnName].ToString() == "ИСТИНА";
                    break;
                    */
                case "Должность":
                    var positionValue = importingRow[columnName].ToString();
                    var positionsTable = EntityManager.FilterPosition($"[Название] = '{positionValue}'");
                    if(positionsTable.Rows.Count == 0 && !string.IsNullOrEmpty(positionValue))
                    {
                        var newPosition = positionsTable.NewДолжностиRow();
                        newPosition.Название = importingRow[columnName].ToString();
                        positionsTable.AddДолжностиRow(newPosition);
                        EntityManager.UpdatePosition();
                    }

                    destinationRow[columnName] = importingRow[columnName];
                    break;

                case "Руководитель":
                    var headValue = importingRow[columnName].ToString();
                    var headsTable = EntityManager.FilterHead($"[ФИО] = '{headValue}'");
                    if (headsTable.Rows.Count == 0 && !string.IsNullOrEmpty(headValue))
                    {
                        var newHead = headsTable.NewРуководителиRow();
                        newHead.ФИО = importingRow[columnName].ToString();
                        headsTable.AddРуководителиRow(newHead);
                        EntityManager.UpdateHead();
                    }

                    destinationRow[columnName] = importingRow[columnName];
                    break;

                case "Размер одежды":
                case "Размер обуви":
                case "Размер зимней обуви":
                case "Размер головного убора":
                case "Размер перчаток":
                    var sizeTableAdapter = new РазмерыTableAdapter();
                    var sizeTable = this.сИЗDataSet.Размеры;
                    sizeTableAdapter.Fill(sizeTable);
                    var sizeValue = importingRow[columnName].ToString();
                    var sizeBingingSource = new BindingSource
                    {
                        DataMember = "Размеры",
                        DataSource = this.сИЗDataSet,
                        Filter = $"[Значение размера] = '{sizeValue}' " +
                        $"AND [Тип принадлежности] = {importingRow[columnName + " принадлежность"]} " +
                        $"AND [Вид размера] = {importingRow[columnName + " вид"]}"
                    };
                    if (sizeBingingSource.List.Count == 0 && !string.IsNullOrEmpty(sizeValue))
                    {
                        var newSize = sizeTable.NewРазмерыRow();
                        newSize.Вид_размера = Convert.ToInt32(importingRow[columnName]);
                        newSize.Значение_размера = importingRow[columnName].ToString();
                        newSize.Тип_принадлежности = Convert.ToInt32(importingRow[columnName + " принадлежность"]);

                        sizeTableAdapter.Update(sizeTable);
                    }
                    else if (sizeBingingSource.List.Count > 0) {
                        destinationRow[columnName] = ((РазмерыRow)((DataRowView)sizeBingingSource[0]).Row).Id;
                    }

                    break;

                default:
                    destinationRow[columnName] = importingRow[columnName];
                    break;
            }
        }

        /// <summary>
        /// Отображает диалоговое окно для выбора файла
        /// </summary>
        /// <returns>Полный путь выбранного файла, либо Null, если файл не выбран</returns>
        private string GetImportingExcelFileName()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Файл Excel|*.XLSX;*.XLS";
            return dialog.ShowDialog() == DialogResult.OK
                ? dialog.FileName
                : null;
        }
    }
}