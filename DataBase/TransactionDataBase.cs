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
            dataBase.SaveAs($@"C\Desctop\{accName}{DateTime.Today.Year}DataBase.xlsx");
            dataBase.Close();
        }
        public void OpenFile() //Втавить в процесс авторизации
        {
            dataBase = new Excel($@"C\Desctop\{accName}{DateTime.Today.Year}DataBase.xlsx");
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
            dataBase.WriteToCell(1, incomeEnding, name);
            //Первый лист

            SwitchDataBaseSheet(2);
            dataBase.MoveRange(1, incomeEnding, 13, outcomeEnding, 1, incomeEnding + 1);
            dataBase.FillRange(2, incomeEnding, 13, incomeEnding, "0");
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

            GlobalSumCalculator();
            // Пересчёт глобальных сумм 

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
            dataBase.WriteToCell(1, outcomeEnding, name);
            //Первый лист

            SwitchDataBaseSheet(2);
            dataBase.MoveRange(1, outcomeEnding, 13, outcomeEnding, 1, outcomeEnding + 1);
            dataBase.FillRange(2, outcomeEnding, 13, outcomeEnding, "0");
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

            GlobalSumCalculator();
            //Пересчёт гдобальных сумм

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
            dataBase.FillRange(3, incomeBegining + 1, 13, incomeEnding, "0");
            dataBase.FillRange(3, outcomeBegining + 1, 13, outcomeEnding, "0");
            dataBase.ChangeName("План на год");
            //Заготовка под первый лист

            dataBase.CreateNewSheet();
            SwitchDataBaseSheet(2);
            dataBase.FillRange(2, incomeBegining + 1, 13, incomeEnding, "0");
            dataBase.FillRange(2, outcomeBegining + 1, 13, outcomeEnding, "0");
            dataBase.ChangeName("Факт на год");
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
            dataBase.ChangeName("Факт (детально)");
            //Заготовка под третий лист

            dataBase.CreateNewSheet();
            SwitchDataBaseSheet(4);
            dataBase.ChangeName("История");
            //Заготовка под четвёртый лист

            WriteHeadLines(); //Заголовки к листам
            GlobalSumCalculator(); //Пересчет сумм
        }
        public void WriteHeadLines() //Написание заголовков, только для создания файла
        {
            string[,] column = new string[,] { { "Год" }, { "Январь" }, { "Февраль" }, { "Март" }, { "Апрель" }, { "Май" }, { "Июнь" }, { "Июль" }, { "Август" }, { "Сентябрь" }, { "Октябрь" }, { "Ноябрь" }, { "Декабрь" } };
            string[,] historyHead = new string[,] { { "Тип операции", "Категория", "Дата", "Сумма" } };
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
            dataBase.WriteRange(1, 1, 1, 4, historyHead);
            //Заголовки для четвертого листа
        }
        public void GlobalSumCalculator() //Пересчет глобальных сумм
        {
            SwitchDataBaseSheet(1);
            //Доходы ПЛАН на год
            dataBase.WriteSumFormulaToRange(3, incomeBegining, 13, incomeBegining, 3, incomeBegining + 1, 3, incomeEnding);
            dataBase.WriteSumFormulaToRange(2, incomeBegining, 2, incomeEnding, 3, incomeBegining, 13, incomeBegining);

            //Расходы ПЛАН на год
            dataBase.WriteSumFormulaToRange(3, outcomeBegining, 13, outcomeBegining, 3, outcomeBegining + 1, 3, outcomeEnding);
            dataBase.WriteSumFormulaToRange(2, outcomeBegining, 2, outcomeEnding, 3, outcomeBegining, 13, outcomeBegining);

            SwitchDataBaseSheet(2);
            //Доходы ФАКТ на год
            dataBase.WriteSumFormulaToRange(3, incomeBegining, 13, incomeBegining, 3, incomeBegining + 1, 3, incomeEnding);
            dataBase.WriteSumFormulaToRange(2, incomeBegining, 2, incomeEnding, 3, incomeBegining, 13, incomeBegining);

            //Расходы ФАКТ на год
            dataBase.WriteSumFormulaToRange(3, outcomeBegining, 13, outcomeBegining, 3, outcomeBegining + 1, 3, outcomeEnding);
            dataBase.WriteSumFormulaToRange(2, outcomeBegining, 2, outcomeEnding, 3, outcomeBegining, 13, outcomeBegining);

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