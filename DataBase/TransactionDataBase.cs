using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

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
        private List<string> categorys;

        public TransactionDataBase(string accName) //Временное решение для конструктора
        {
            this.accName = accName;
            incomeBegining = 2;
            incomeEnding = 7;
            outcomeBegining = 9;
            outcomeEnding = 14;
            categorys = new List<string>{ "Доходы", "1", "2", "3", "4", "Другое", "", "Расходы", "1", "2", "3", "4", "Другое" };
            CreateDataBase();
        }

        public void CreateDataBase() //Втавить в процесс создания аккаунта
        {
            dataBase = new Excel();
            dataBase.CreateNewFile();
            Blank();
            dataBase.SaveAs($@"{accName}{DateTime.Today.Year}DataBase.xlsx");
            dataBase.Close();
        }
        public void OpenFile() //Втавить в процесс авторизации
        {
            dataBase = new Excel($@"{accName}{DateTime.Today.Year}DataBase.xlsx");
        }
        public void CloseFile() //Вставить в завершение работы
        {
            dataBase.Close();
        }


        //Взаимодействие с пользователем
        public void AddNewCategory(string name, int option) //Добавление новой категории доходов/расходов - 1/2
        {
            switch (option)
            {
                case 1:
                    {
                        AddNewIncome(name);
                        dataBase.Save();
                        break;
                    }
                case 2:
                    {
                        AddNewOutcome(name);
                        dataBase.Save();
                        break;
                    }
            }
        }

        //Действия с БД
        public void AddNewIncome(string name) //Добавление статьи ДОХОДОВ
        {
            SwitchDataBaseSheet(1);
            dataBase.MoveRange(1, incomeEnding, 13, outcomeEnding, 1, incomeEnding + 1);
            dataBase.FillRange(2, incomeEnding, 13, incomeEnding, "0");
            WriteData(1, incomeEnding, name);
            //Первый лист

            SwitchDataBaseSheet(2);
            dataBase.MoveRange(1, incomeEnding, 13, outcomeEnding, 1, incomeEnding + 1);
            dataBase.FillRange(2, incomeEnding, 13, incomeEnding, "0");
            WriteData(1, incomeEnding, name);
            //Второй лист

            SwitchDataBaseSheet(3);
            dataBase.MoveRange(1, incomeEnding, 379, outcomeEnding, 1, incomeEnding + 1);
            dataBase.FillRange(1, incomeEnding, 378, incomeEnding, "0");
            WriteData(1, incomeEnding, name);
            //Третий лист

            if (DateTime.Today.Year % 4 == 0)
            {
                WriteData(379, incomeEnding, "0");
            }
            //Учет високосного года

            incomeEnding++; outcomeBegining++; outcomeEnding++;
            //Сдвиг позиций

            List<string> newList = new List<string>();
            for (int i = 0; i < categorys.Count; i++)
            {
                if (i < categorys.Count - 1 && categorys[i+1] == "")
                    newList.Add(name);
                newList.Add(categorys[i]);
            }
            categorys = newList;
            //Запоминание нового списка
        }
        public void AddNewOutcome(string name) //Добавление статьи РАСХОДОВ
        {
            SwitchDataBaseSheet(1);
            dataBase.MoveRange(1, outcomeEnding, 13, outcomeEnding, 1, outcomeEnding + 1);
            dataBase.FillRange(2, outcomeEnding, 13, outcomeEnding, "0");
            WriteData(1, outcomeEnding, name);
            //Первый лист

            SwitchDataBaseSheet(2);
            dataBase.MoveRange(1, outcomeEnding, 13, outcomeEnding, 1, outcomeEnding + 1);
            dataBase.FillRange(2, outcomeEnding, 13, outcomeEnding, "0");
            WriteData(1, outcomeEnding, name);
            //Второй лист

            SwitchDataBaseSheet(3);
            dataBase.MoveRange(1, outcomeEnding, 379, outcomeEnding, 1, outcomeEnding + 1);
            dataBase.FillRange(1, outcomeEnding, 378, outcomeEnding, "0");
            WriteData(1, outcomeEnding, name);
            //Третий лист

            if (DateTime.Today.Year % 4 == 0)
            {
                WriteData(379, outcomeEnding, "0");
            }
            //Учет високосного года

            outcomeEnding++;
            //Сдвиг позиций

            List<string> newList = new List<string>();
            for (int i = 0; i < categorys.Count; i++)
            {
                if (categorys.Count - 2 == i)
                    newList.Add(name);
                newList.Add(categorys[i]);
            }
            categorys = newList;
            //Новый список
        }
        public void Blank() //Автозаполнение базы данных (только для первого входа в году)
        {
            dataBase.FillRange(2, incomeBegining, 13, incomeEnding, "0");
            dataBase.FillRange(2, outcomeBegining, 13, outcomeEnding, "0");
            dataBase.ChangeName("План на год");
            //Заготовка под первый лист

            dataBase.CreateNewSheet();
            SwitchDataBaseSheet(2);
            dataBase.FillRange(2, incomeBegining, 13, incomeEnding, "0");
            dataBase.FillRange(2, outcomeBegining, 13, outcomeEnding, "0");
            dataBase.ChangeName("Факт на год");
            //Заготовка под второй лист

            dataBase.CreateNewSheet();
            SwitchDataBaseSheet(3);
            dataBase.FillRange(2, incomeBegining, 378, incomeEnding, "0");
            dataBase.FillRange(2, outcomeBegining, 378, outcomeEnding, "0");
            if (DateTime.Today.Year % 4 == 0)
            {
                dataBase.FillRange(379, incomeBegining, 379, incomeEnding, "0");
                dataBase.FillRange(379, outcomeBegining, 379, outcomeEnding, "0");
            }
            dataBase.ChangeName("Факт (детально)");
            //Заготовка под третий лист

            dataBase.CreateNewSheet();
            SwitchDataBaseSheet(4);
            dataBase.ChangeName("История");
            //Заготовка под четвёртый лист

            WriteHeadLines(); //Заголовки к листам
        }
        public void WriteHeadLines() //Написание заголовков, только для создания файла
        {
            string[,] column = { { "Январь" }, { "Февраль" }, { "Март" }, { "Апрель" }, { "Май" }, { "Июнь" }, { "Июль" }, { "Август" }, { "Сентябрь" }, { "Октябрь" }, { "Ноябрь" }, { "Декабрь" } };
            string[,] historyHead = { { "Тип операции", "Категория", "Дата", "Сумма", "Комментарий" } };
            string[,] head = new string[1, categorys.Count];
            for (int i = 0; i < categorys.Count; i++)
            {
                head[0, i] = categorys[i];
            }

            SwitchDataBaseSheet(1);
            dataBase.WriteRange(1, incomeBegining, 1, outcomeEnding, head);
            dataBase.WriteRange(2, 1, 13, 1, column);
            //Заголовки для первого листа

            SwitchDataBaseSheet(2);
            dataBase.WriteRange(1, incomeBegining, 1, outcomeEnding, head);
            dataBase.WriteRange(2, 1, 13, 1, column);
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
            dataBase.WriteRange(1, 1, 1, 5, historyHead);
            //Заголовки для четвертого листа
        }

        //Действия с листами
        public void SwitchDataBaseSheet(int sheet) //Переключение текущего листа
        {
            dataBase.SwitchWorkSheet(sheet);
        }

        //Действия с ячейками
        public string ReadData(int i, int j) //Чтение из ячейки БД
        {
            string result = dataBase.ReadCell(i, j);
            dataBase.Close();
            return result;
        }
        public void WriteData(int i, int j, string str) //Запись в ячейку БД
        {
            dataBase.WriteToCell(i, j, str);
            dataBase.Save();
        }
    }
}
