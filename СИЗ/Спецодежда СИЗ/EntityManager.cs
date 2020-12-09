using System;
using System.Collections.Generic;
using Спецодежда_СИЗ.СИЗDataSetTableAdapters;
using static Спецодежда_СИЗ.СИЗDataSet;
using System.Data.OleDb;
using System.Data;

namespace Спецодежда_СИЗ
{
    public class EntityManager
    {
        static СИЗDataSet СИЗDataSet = new СИЗDataSet();

        private static ПользователиTableAdapter пользователиTableAdapter = new ПользователиTableAdapter();
        private static СотрудникиTableAdapter сотрудникиTableAdapter = new СотрудникиTableAdapter();
        private static ДолжностиTableAdapter ДолжностиTableAdapter = new ДолжностиTableAdapter();
        private static единицы_измеренияTableAdapter единицы_ИзмеренияTableAdapter = new единицы_измеренияTableAdapter();
        private static номенклатураTableAdapter номенклатураTableAdapter = new номенклатураTableAdapter();
        private static РуководителиTableAdapter РуководителиTableAdapter = new РуководителиTableAdapter();
        private static ОтделыTableAdapter ОтделыTableAdapter = new ОтделыTableAdapter();

        public static ПользователиDataTable UserDataTable
        {
            get
            {
                return СИЗDataSet.Пользователи;
            }
        }

        public static СотрудникиDataTable EmployeesDataTable
        {
            get
            {
                return СИЗDataSet.Сотрудники;
            }
        }

        public static ДолжностиDataTable PositionDataTable
        {
            get
            {
                return СИЗDataSet.Должности;
            }
        }

        public static единицы_измеренияDataTable UnitsDataTable
        {
            get
            {
                return СИЗDataSet.единицы_измерения;
            }
        }

        public static номенклатураDataTable NomenclatureDataTable
        {
            get
            {
                return СИЗDataSet.номенклатура;
            }
        }

        public static РуководителиDataTable HeadDataTable
        {
            get
            {
                return СИЗDataSet.Руководители;
            }
        }

        public static ОтделыDataTable DepartamentsDataTable
        {
            get
            {
                return СИЗDataSet.Отделы;
            }
        }

        public static void UpdateUsers()
        {
            пользователиTableAdapter.Adapter.Update(UserDataTable);
        }

        public static void UpdateEmployees()
        {
            сотрудникиTableAdapter.Update(EmployeesDataTable);
        }

        public static void UpdatePosition()
        {
            ДолжностиTableAdapter.Update(PositionDataTable);
        }

        public static void UpdateUnits()
        {
            единицы_ИзмеренияTableAdapter.Adapter.Update(UnitsDataTable);
        }

        public static void UpdateNomenclature()
        {
            номенклатураTableAdapter.Fill(NomenclatureDataTable);
        }

        public static void UpdateHead()
        {
            РуководителиTableAdapter.Update(HeadDataTable);
        }

        public static void UpdateDepartaments()
        {
            ОтделыTableAdapter.Update(DepartamentsDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу пользователей по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ПользователиDataTable FilterUsers(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = пользователиTableAdapter.Connection,
                CommandText = "SELECT Id_user, Фамилия, Имя, Отчество, Логин, Пароль, " +
                $"[Является администратором] FROM Пользователи {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(пользователиTableAdapter.Adapter, filterUserCommand, UserDataTable);

            return UserDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу сотрудники по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static СотрудникиDataTable FilterEmployees(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterEmployeesCommand = new OleDbCommand()
            {
                Connection = сотрудникиTableAdapter.Connection,
                CommandText = "SELECT Id, [Номер карточки], ФИО, Пол, Должность, Руководитель, Работающий," +
                " [Табельный_номер], Рост, [Размер одежды], [Размер обуви], [Размер зимней обуви]," +
                " [Размер головного убора], [Размер перчаток], [Дата поступления], [Дата изменения должности] " +
                 $"FROM Сотрудники {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(сотрудникиTableAdapter.Adapter, filterEmployeesCommand, EmployeesDataTable);

            return EmployeesDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу должности по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ДолжностиDataTable FilterPosition(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterPositionCommand = new OleDbCommand()
            {
                Connection = ДолжностиTableAdapter.Connection,
                CommandText = "SELECT Id_дожности, Название " +
                 $"FROM Должности {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(ДолжностиTableAdapter.Adapter, filterPositionCommand, PositionDataTable);

            return PositionDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу единиц измернеия по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static единицы_измеренияDataTable FilterUnits(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUnitsCommand = new OleDbCommand()
            {
                Connection = единицы_ИзмеренияTableAdapter.Connection,
                CommandText = "SELECT Наименование" +
                 "FROM единицы измерения {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(единицы_ИзмеренияTableAdapter.Adapter, filterUnitsCommand, UnitsDataTable);

            return UnitsDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу номенклатура по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static номенклатураDataTable FilterNomenclature(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterNomenclatureCommand = new OleDbCommand()
            {
                Connection = номенклатураTableAdapter.Connection,
                CommandText = "SELECT Наименование, Размер, Рост" +
                 "FROM номенклатура {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(номенклатураTableAdapter.Adapter, filterNomenclatureCommand, NomenclatureDataTable);

            return NomenclatureDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу руководитель по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static РуководителиDataTable FilterHead(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterHeadCommand = new OleDbCommand()
            {
                Connection = РуководителиTableAdapter.Connection,
                CommandText = "SELECT Id_руководителя, ФИО " +
                 $"FROM Руководители {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(номенклатураTableAdapter.Adapter, filterHeadCommand, HeadDataTable);

            return HeadDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу отделы по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ОтделыDataTable FilterDepartaments(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterDepartamentsCommand = new OleDbCommand()
            {
                Connection = ОтделыTableAdapter.Connection,
                CommandText = "SELECT № отдела, Наименование " +
                 $"FROM Отделы {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(ОтделыTableAdapter.Adapter, filterDepartamentsCommand, DepartamentsDataTable);

            return DepartamentsDataTable;
        }

        /// <summary>
        /// Создает строку для фильтрации: всевозможные комбинации по сравнению предоставленных полей с текстом поиска
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public static string GetFilterStringByFields(string[] fields, string searchText)
        {
            var findValues = string.IsNullOrEmpty(searchText)
                ? new string[] { }
                : searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filterStrings = new List<string>();
            foreach (var findingField in fields)
            {
                foreach (var findingValue in findValues)
                {
                    filterStrings.Add($"{findingField} LIKE '%{findingValue}%'");
                }
            }

            return string.Join(" OR ", filterStrings);
        }

        /// <summary>
        /// Заполняет таблицу по фильтрующей команде выбора строк
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="selectCommand"></param>
        /// <param name="table"></param>
        private static void FillFilteredTable(OleDbDataAdapter adapter, OleDbCommand selectCommand, DataTable table)
        {
            var oldSelectComand = adapter.SelectCommand;
            adapter.SelectCommand = selectCommand;

            table.Clear();

            adapter.Fill(table);
            adapter.SelectCommand = oldSelectComand;
        }
    }
}
