using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class TransactionDataBase
    {
        private Excel dataBase; //Файл excel
        private string accName; //Имя аккаунта, привязанного к БД
        private int incomeBegining;
        private int incomeEnding;
        private int outcomeBegining;
        private int outcomeEnding;
        private string[] mainHeadLine;
        //public string[] IncomeCategories { get => mainHeadLine.Split[]; }
        private int newAdd;
        public TransactionDataBase(string accName)
        {
            this.accName = accName;
            OpenFile();

            incomeBegining = 2;
            incomeEnding = incomeBegining;
            for (int i = incomeBegining; dataBase.ReadCell(1, i + 1) != ""; i++) //Поиск абсциссы конца доходов
            {
                incomeEnding++;
            }

            outcomeBegining = incomeEnding + 2; //Начало расходов через клетку от конца Доходов
            outcomeEnding = outcomeBegining;
            for (int i = outcomeBegining; dataBase.ReadCell(1, i + 1) != ""; i++) //Поиск абсциссы конца расходов
            {
                outcomeEnding++;
            }
            mainHeadLine = dataBase.ReadLine(1, incomeBegining, outcomeEnding);

            SwitchDataBaseSheet(4);
            newAdd = 2;
            for (int i = 2; dataBase.ReadCell(i,1) != ""; i++)
            {
                newAdd++;
            }
            CloseFile();
        }

        public TransactionDataBase(string accName, int dif) //Конструктор для создания новой базы данных
        {
            this.accName = accName;
            incomeBegining = 2;
            incomeEnding = 7;
            outcomeBegining = 9;
            outcomeEnding = 14;
            newAdd = 2;
            mainHeadLine = new string[] { "Доходы", "1", "2", "3", "4", "Прочие Д.", "", "Расходы", "5", "6", "7", "8", "Прочие Р." };
            CreateDataBase();
        }
        
        public void CreateDataBase() //Втавить в процесс создания аккаунта
        {
            dataBase = new Excel();
            dataBase.CreateNewFile();
            Blank();

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, $"{accName}{DateTime.Today.Year}DataBase.xlsx");
            dataBase.SaveAs(filePath);
            CloseFile();
        }
        public void OpenFile() //Втавить в процесс авторизации
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, $"{accName}{DateTime.Today.Year}DataBase.xlsx");

            FileAttributes attributes = File.GetAttributes(filePath);
            attributes &= ~FileAttributes.ReadOnly;
            dataBase = new Excel(filePath);
        }
        public void Save() //После каждого действия с файлом
        {
            dataBase.Save();
        }
        public void CloseFile() //Вставить в завершение работы
        {
            dataBase.Close();
        }
        public void SaveAndExit() //Сохранить и закрыть файл
        {
            Save();
            CloseFile();
        }

        //Данные для диаграмм
        public double[,] ReadDoubleRange(int starti, int startj, int endi, int endj)
        {
            return dataBase.ReadDoubleRange(starti, startj, endi, endj);
        }


        //Взаимодействие с пользователем
        public void AddNewCategory(string name, int option) //Добавление новой категории доходов/расходов - 1/2
        {
            switch (option)
            {
                case 1:
                    {
                        AddNewIncome(name);
                        break;
                    }
                case 2:
                    {
                        AddNewOutcome(name);
                        break;
                    }
            }
        }
        public void AddNewTransaction(int type, string category, string date, double value) 
        {
            SwitchDataBaseSheet(4);
            switch (type)
            {
                case 1:
                {
                    AddIncomeTransaction(category, date, value);
                    break;
                }
                case 2:
                {
                    AddOutcomeTransaction(category, date, value);
                    break;
                }
            }
            newAdd++;
        } //Добавление новой операции доходов/расходов - 1/2


        //Действия с БД
        public void AddIncomeTransaction(string category, string date, double value)
        {
            string[,] line = new string[,] { { "Поступление", $"{category}", $"{date}", $"{value}"} };
            dataBase.WriteRange(newAdd, 1, newAdd, 4, line);
            SwitchDataBaseSheet(3);
            dataBase.AddToCell(FindDate(date), FindCategory(category), value);
        } //Добавить ДОХОД
        public void AddOutcomeTransaction(string category, string date, double value)
        {
            string[,] line = new string[,] { { "Списание", $"{category}", $"{date}", $"{value}" } };
            dataBase.WriteRange(newAdd, 1, newAdd, 4, line);
            SwitchDataBaseSheet(3);
            dataBase.AddToCell(FindDate(date), FindCategory(category), value);
        } //Добавить РАСХОД

        public void AddNewIncome(string name) //Добавление статьи ДОХОДОВ
        {

            List<string> newList = new List<string>();
            for (int i = 0; i < mainHeadLine.Length; i++)
            {
                if (i < mainHeadLine.Length - 1 && mainHeadLine[i + 1] == "")
                    newList.Add(name);
                newList.Add(mainHeadLine[i]);
            }
            mainHeadLine = newList.ToArray();
            //Запоминание нового списка

            SwitchDataBaseSheet(1);
            dataBase.MoveRange(1, incomeEnding, 14, outcomeEnding, 1, incomeEnding + 1);
            dataBase.FillRange(2, incomeEnding, 14, incomeEnding, "0");
            dataBase.WriteToCell(1, incomeEnding, name);
            //Первый лист

            SwitchDataBaseSheet(2);

            dataBase.MoveRange(1, incomeEnding, 1, outcomeEnding, 1, incomeEnding + 1);
            dataBase.ClearRange(2, incomeEnding, 14, outcomeEnding);
            dataBase.WriteToCell(1, incomeEnding, name);
            //Второй лист

            SwitchDataBaseSheet(3);
            dataBase.MoveRange(1, incomeEnding, 379, outcomeEnding, 1, incomeEnding + 1);
            dataBase.FillRange(3, incomeEnding, 378, incomeEnding, "0");
            dataBase.WriteToCell(1, incomeEnding, name);
            //Третий лист

            if (DateTime.Today.Year % 4 == 0)
            {
                dataBase.WriteToCell(379, incomeEnding, "0");
            }
            //Учет високосного года

            incomeEnding++; outcomeBegining++; outcomeEnding++;
            //Сдвиг позиций

            MakeLinks();
            //Переназначение ссылок на 2 листе (Факт на год)

            GlobalSumCalculator();
            // Пересчёт глобальных сумм
        }
        public void AddNewOutcome(string name) //Добавление статьи РАСХОДОВ
        {
            List<string> newList = new List<string>();
            for (int i = 0; i < mainHeadLine.Length; i++)
            {
                if (mainHeadLine.Length - 2 == i)
                    newList.Add(name);
                newList.Add(mainHeadLine[i]);
            }
            mainHeadLine = newList.ToArray();
            //Новый список

            SwitchDataBaseSheet(1);
            dataBase.MoveRange(1, outcomeEnding, 13, outcomeEnding, 1, outcomeEnding + 1);
            dataBase.FillRange(2, outcomeEnding, 13, outcomeEnding, "0");
            dataBase.WriteToCell(1, outcomeEnding, name);
            //Первый лист

            SwitchDataBaseSheet(2);
            dataBase.MoveCell(1, outcomeEnding, 1, outcomeEnding + 1);
            dataBase.WriteToCell(1, outcomeEnding, name);
            //Второй лист

            SwitchDataBaseSheet(3);
            dataBase.MoveRange(1, outcomeEnding, 379, outcomeEnding, 1, outcomeEnding + 1);
            dataBase.FillRange(3, outcomeEnding, 378, outcomeEnding, "0");
            dataBase.WriteToCell(1, outcomeEnding, name);
            //Третий лист

            if (DateTime.Today.Year % 4 == 0)
            {
                dataBase.WriteToCell(379, outcomeEnding, "0");
            }
            //Учет високосного года

            outcomeEnding++;
            //Сдвиг позиций

            MakeLinks();
            //Переназначение ссылок на 2 листе (Факт на год)

            GlobalSumCalculator();
            //Пересчёт гдобальных сумм
        }

        public void Blank() //Автозаполнение базы данных (только для первого входа в году)
        {
            dataBase.FillRange(3, incomeBegining + 1, 14, incomeEnding, "0");
            dataBase.FillRange(3, outcomeBegining + 1, 14, outcomeEnding, "0");
            dataBase.ChangeSheetName("План на год");
            //Заготовка под первый лист

            dataBase.CreateNewSheet();
            SwitchDataBaseSheet(2);
            dataBase.FillRange(2, incomeBegining + 1, 14, incomeEnding, "0");
            dataBase.FillRange(2, outcomeBegining + 1, 14, outcomeEnding, "0");
            dataBase.ChangeSheetName("Факт на год");
            //Заготовка под второй лист

            dataBase.CreateNewSheet();
            SwitchDataBaseSheet(3);
            dataBase.FillRange(2, incomeBegining + 1, 378, incomeEnding, "0");
            dataBase.FillRange(2, outcomeBegining + 1, 378, outcomeEnding, "0");
            if (DateTime.Today.Year % 4 == 0)
            {
                dataBase.FillRange(379, incomeBegining + 1, 379, incomeEnding, "0");
                dataBase.FillRange(379, outcomeBegining + 1, 379, outcomeEnding, "0");
            }
            dataBase.ChangeSheetName("Факт (детально)");
            //Заготовка под третий лист

            dataBase.CreateNewSheet();
            SwitchDataBaseSheet(4);
            dataBase.ChangeSheetName("История");
            //Заготовка под четвёртый лист

            WriteHeadLines(); //Заголовки к листам
            GlobalSumCalculator(); //Пересчет сумм
            MakeLinks();
        }
        public void WriteHeadLines() //Написание заголовков, только для создания файла
        {
            string[,] column = new string[,] { { "Год" }, { "Январь" }, { "Февраль" }, { "Март" }, { "Апрель" }, { "Май" }, { "Июнь" }, { "Июль" }, { "Август" }, { "Сентябрь" }, { "Октябрь" }, { "Ноябрь" }, { "Декабрь" } };
            string[,] historyHead = new string[,] { { "Тип операции", "Категория", "Дата", "Сумма" } };
            string[,] head = new string[1, mainHeadLine.Length];
            for (int i = 0; i < mainHeadLine.Length; i++)
            {
                head[0, i] = mainHeadLine[i];
            }

            SwitchDataBaseSheet(1);
            dataBase.WriteRange(1, incomeBegining, 1, outcomeEnding, head);
            dataBase.WriteRange(2, 1, 14, 1, column);
            //Заголовки для первого листа

            SwitchDataBaseSheet(2);
            dataBase.WriteRange(1, incomeBegining, 1, outcomeEnding, head);
            dataBase.WriteRange(2, 1, 14, 1, column);
            //Заголовки для второго листа

            DateTime date = new DateTime(DateTime.Today.Year, 1, 1);
            column = new string[379, 1];
            for (int i = 0; i < column.GetLength(0) - 1; i++)
            {
                if (date.Day == 1)
                {
                    column[i++, 0] = "";
                }
                column[i, 0] = date.ToShortDateString();
                date = date.AddDays(1);
            }
            //Массив с датами на целый год

            SwitchDataBaseSheet(3);
            dataBase.WriteRange(1, incomeBegining, 1, outcomeEnding, head);
            dataBase.WriteRange(2, 1, 379, 1, column);
            //Заголовки для третьего листа

            SwitchDataBaseSheet(4);
            dataBase.WriteRange(1, 1, 1, 4, historyHead);
            //Заголовки для четвертого листа
        }
        public void GlobalSumCalculator() //Пересчет глобальных сумм
        {
            SumCalculatorOnSheet(1);
            SumCalculatorOnSheet(2);
            SumCalculatorOnSheet(3);
        }
        public void SumCalculatorOnSheet(int sheet) //Пересчёт сумм на листе
        {
            switch (sheet)
            {
                case 1:
                {
                    SwitchDataBaseSheet(1);
                    //Доходы ПЛАН на год
                    dataBase.WriteSumFormulaToRange(3, incomeBegining, 14, incomeBegining, 3, incomeBegining + 1, 3, incomeEnding);
                    dataBase.WriteSumFormulaToRange(2, incomeBegining, 2, incomeEnding, 3, incomeBegining, 14, incomeBegining);

                    //Расходы ПЛАН на год
                    dataBase.WriteSumFormulaToRange(3, outcomeBegining, 14, outcomeBegining, 3, outcomeBegining + 1, 3, outcomeEnding);
                    dataBase.WriteSumFormulaToRange(2, outcomeBegining, 2, outcomeEnding, 3, outcomeBegining, 14, outcomeBegining);

                    break;
                }
                case 2:
                {
                    SwitchDataBaseSheet(2);
                    //Доходы ФАКТ на год
                    dataBase.WriteSumFormulaToRange(2, incomeBegining, 2, incomeEnding, 3, incomeBegining, 14, incomeBegining); //Сумма

                    //Расходы ФАКТ на год
                    dataBase.WriteSumFormulaToRange(2, outcomeBegining, 2, outcomeEnding, 3, outcomeBegining, 14, outcomeBegining); //Сумма

                    break;
                }
                case 3:
                {
                    SwitchDataBaseSheet(3);
                    //Доходы факт ДЕТАЛЬНО
                    dataBase.WriteSumFormulaToRange(2, incomeBegining, 379, incomeBegining, 2, incomeBegining + 1, 2, incomeEnding);
                    dataBase.WriteSumFormulaToRange(2, incomeBegining, 2, incomeEnding, 3, incomeBegining, 33, incomeBegining);        //01
                    dataBase.WriteSumFormulaToRange(34, incomeBegining, 34, incomeEnding, 35, incomeBegining, 63, incomeBegining);     //02
                    dataBase.WriteSumFormulaToRange(64, incomeBegining, 64, incomeEnding, 65, incomeBegining, 95, incomeBegining);     //03
                    dataBase.WriteSumFormulaToRange(96, incomeBegining, 96, incomeEnding, 97, incomeBegining, 126, incomeBegining);    //04
                    dataBase.WriteSumFormulaToRange(127, incomeBegining, 127, incomeEnding, 128, incomeBegining, 158, incomeBegining); //05
                    dataBase.WriteSumFormulaToRange(159, incomeBegining, 159, incomeEnding, 160, incomeBegining, 189, incomeBegining); //06
                    dataBase.WriteSumFormulaToRange(190, incomeBegining, 190, incomeEnding, 191, incomeBegining, 221, incomeBegining); //07
                    dataBase.WriteSumFormulaToRange(222, incomeBegining, 222, incomeEnding, 223, incomeBegining, 253, incomeBegining); //08
                    dataBase.WriteSumFormulaToRange(254, incomeBegining, 254, incomeEnding, 255, incomeBegining, 284, incomeBegining); //09
                    dataBase.WriteSumFormulaToRange(285, incomeBegining, 285, incomeEnding, 286, incomeBegining, 316, incomeBegining); //10
                    dataBase.WriteSumFormulaToRange(317, incomeBegining, 317, incomeEnding, 318, incomeBegining, 347, incomeBegining); //11
                    dataBase.WriteSumFormulaToRange(348, incomeBegining, 348, incomeEnding, 349, incomeBegining, 379, incomeBegining); //12

                    //Расходы факт ДЕТАЛЬНО
                    dataBase.WriteSumFormulaToRange(2, outcomeBegining, 379, outcomeBegining, 2, outcomeBegining + 1, 2, outcomeEnding);
                    dataBase.WriteSumFormulaToRange(2, outcomeBegining, 2, outcomeEnding, 3, outcomeBegining, 33, outcomeBegining);        //01
                    dataBase.WriteSumFormulaToRange(34, outcomeBegining, 34, outcomeEnding, 35, outcomeBegining, 63, outcomeBegining);     //02
                    dataBase.WriteSumFormulaToRange(64, outcomeBegining, 64, outcomeEnding, 65, outcomeBegining, 95, outcomeBegining);     //03
                    dataBase.WriteSumFormulaToRange(96, outcomeBegining, 96, outcomeEnding, 97, outcomeBegining, 126, outcomeBegining);    //04
                    dataBase.WriteSumFormulaToRange(127, outcomeBegining, 127, outcomeEnding, 128, outcomeBegining, 158, outcomeBegining); //05
                    dataBase.WriteSumFormulaToRange(159, outcomeBegining, 159, outcomeEnding, 160, outcomeBegining, 189, outcomeBegining); //06
                    dataBase.WriteSumFormulaToRange(190, outcomeBegining, 190, outcomeEnding, 191, outcomeBegining, 221, outcomeBegining); //07
                    dataBase.WriteSumFormulaToRange(222, outcomeBegining, 222, outcomeEnding, 223, outcomeBegining, 253, outcomeBegining); //08
                    dataBase.WriteSumFormulaToRange(254, outcomeBegining, 254, outcomeEnding, 255, outcomeBegining, 284, outcomeBegining); //09
                    dataBase.WriteSumFormulaToRange(285, outcomeBegining, 285, outcomeEnding, 286, outcomeBegining, 316, outcomeBegining); //10
                    dataBase.WriteSumFormulaToRange(317, outcomeBegining, 317, outcomeEnding, 318, outcomeBegining, 347, outcomeBegining); //11
                    dataBase.WriteSumFormulaToRange(348, outcomeBegining, 348, outcomeEnding, 349, outcomeBegining, 379, outcomeBegining); //12

                    break;
                }
            }
        }
        public void MakeLinks() //Cсылки для таблицы факта
        {
            SwitchDataBaseSheet(2);
            //Доходы ФАКТ на год
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 3, incomeBegining, 3, incomeEnding, 2, incomeBegining, 2, incomeEnding);        //01
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 4, incomeBegining, 4, incomeEnding, 34, incomeBegining, 34, incomeEnding);      //01
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 5, incomeBegining, 5, incomeEnding, 64, incomeBegining, 64, incomeEnding);      //03
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 6, incomeBegining, 6, incomeEnding, 96, incomeBegining, 96, incomeEnding);      //04
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 7, incomeBegining, 7, incomeEnding, 127, incomeBegining, 127, incomeEnding);    //05
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 8, incomeBegining, 8, incomeEnding, 159, incomeBegining, 159, incomeEnding);    //06
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 9, incomeBegining, 9, incomeEnding, 190, incomeBegining, 190, incomeEnding);    //07
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 10, incomeBegining, 10, incomeEnding, 222, incomeBegining, 222, incomeEnding);  //08
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 11, incomeBegining, 11, incomeEnding, 254, incomeBegining, 254, incomeEnding);  //09
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 12, incomeBegining, 12, incomeEnding, 285, incomeBegining, 285, incomeEnding);  //10
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 13, incomeBegining, 13, incomeEnding, 317, incomeBegining, 317, incomeEnding);  //11
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 14, incomeBegining, 14, incomeEnding, 348, incomeBegining, 348, incomeEnding);  //12

            //Расходы ФАКТ на год
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 3, outcomeBegining, 3, outcomeEnding, 2, outcomeBegining, 2, outcomeEnding);        //01
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 4, outcomeBegining, 4, outcomeEnding, 34, outcomeBegining, 34, outcomeEnding);      //01
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 5, outcomeBegining, 5, outcomeEnding, 64, outcomeBegining, 64, outcomeEnding);      //03
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 6, outcomeBegining, 6, outcomeEnding, 96, outcomeBegining, 96, outcomeEnding);      //04
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 7, outcomeBegining, 7, outcomeEnding, 127, outcomeBegining, 127, outcomeEnding);    //05
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 8, outcomeBegining, 8, outcomeEnding, 159, outcomeBegining, 159, outcomeEnding);    //06
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 9, outcomeBegining, 9, outcomeEnding, 190, outcomeBegining, 190, outcomeEnding);    //07
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 10, outcomeBegining, 10, outcomeEnding, 222, outcomeBegining, 222, outcomeEnding);  //08
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 11, outcomeBegining, 11, outcomeEnding, 254, outcomeBegining, 254, outcomeEnding);  //09
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 12, outcomeBegining, 12, outcomeEnding, 285, outcomeBegining, 285, outcomeEnding);  //10
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 13, outcomeBegining, 13, outcomeEnding, 317, outcomeBegining, 317, outcomeEnding);  //11
            dataBase.WriteLinkFormulaToRange("Факт (детально)", 14, outcomeBegining, 14, outcomeEnding, 348, outcomeBegining, 348, outcomeEnding);  //12
        }

        //Поиск
        public int FindDate(string date)
        {
            string[] Date = date.Split('.');
            switch (Date[1])
            {
                case "01": //Январь
                {
                    return 2 + int.Parse(Date[0]);
                }
                case "02": //Февраль
                {
                    return 34 + int.Parse(Date[0]);
                }
                case "03": //Март
                {
                    return 64 + int.Parse(Date[0]);
                }
                case "04": //Апрель
                {
                    return 96 + int.Parse(Date[0]);
                }
                case "05": //Май
                {
                    return 127 + int.Parse(Date[0]);
                }
                case "06": //Июнь
                {
                    return 159 + int.Parse(Date[0]);
                }
                case "07": //Июль
                {
                    return 190 + int.Parse(Date[0]);
                }
                case "08": //Август
                {
                    return 222 + int.Parse(Date[0]);
                }
                case "09": //Сентябрь
                {
                    return 254 + int.Parse(Date[0]);
                }
                case "10": //Октябрь
                {
                    return 285 + int.Parse(Date[0]);
                }
                case "11": //Ноябрь
                {
                    return 317 + int.Parse(Date[0]);
                }  
                default: //Остался только Декабрь
                {
                    return 348 + int.Parse(Date[0]);
                }
            }
        } //Поиск строки по дате
        public int FindCategory(string category) //Поиск столбца по категории
        {
            return mainHeadLine.ToList().IndexOf(category) + 2;
        }

        //Действия с книгами
        public void DeleteDataBase() { }

        //Действия с листами
        public void SwitchDataBaseSheet(int sheet) //Переключение текущего листа
        {
            dataBase.SwitchWorkSheet(sheet);
        }
    }
}