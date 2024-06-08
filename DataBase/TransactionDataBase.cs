using System;
using System.Collections.Generic;
using System.Linq;
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
        private int incomeBegining = 2;
        private int outcomeBegining = 9;

        public TransactionDataBase(string accName) { this.accName = accName; CreateDataBase(); }

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

        public void Blank() //Автозаполнение базы данных
        {
            string[,] column = { { "Январь" }, { "Февраль" }, { "Март" }, { "Апрель" }, { "Май" }, { "Июнь" }, { "Июль" }, { "Август" }, { "Сентябрь" }, { "Октябрь" }, { "Ноябрь" }, {"Декабрь"} };
            string[,] head = { { "Доходы", "1", "2", "3", "4", "5", "", "Расходы", "1", "2", "3", "4", "5"} };
            dataBase.WriteRange(1, 2, 1, 14, head);
            dataBase.WriteRange(2, 1, 13, 1, column);
            dataBase.ChangeName("План на год");
            dataBase.CreateNewSheet();
            dataBase.SwitchWorkSheet(2);
            dataBase.WriteRange(1, 2, 1, 14, head);
            dataBase.WriteRange(2, 1, 13, 1, column);
            dataBase.ChangeName("Факт на год");
            DateTime date = new DateTime(DateTime.Today.Year, 1, 1);
            column = new string[379, 1];
            column[366, 0] = "";
            for (int i = 0; i < column.GetLength(0) - 1;  i++)
            {
                if (date.Day == 1)
                {
                    column[i++, 0] = "";
                }
                column[i, 0] = date.ToShortDateString();
                date = date.AddDays(1);
            }

            dataBase.CreateNewSheet();
            dataBase.SwitchWorkSheet(3);
            dataBase.WriteRange(1, 2, 1, 14, head);
            dataBase.WriteRange(2, 1, 379, 1, column);
            dataBase.ChangeName("Факт (детально)");
            //dataBase.CreateNewSheet();
            //dataBase.SwitchWorkSheet(4);
            //dataBase.WriteRange(, , , , head);
            //dataBase.ChangeName("История");
        }

        public void SwitchDataBaseSheet(int sheet) //Переключение текущего листа
        {
            OpenFile();
            dataBase.SwitchWorkSheet(sheet);
            dataBase.Close();
        }

        public string ReadData(int i, int j) //Чтение из ячейки бд
        {
            OpenFile();
            string result = dataBase.ReadCell(i, j);
            dataBase.Close();
            return result;
        }

        public void WriteData(int i, int j, string str) //Запись в ячейку БД
        {
            OpenFile();
            dataBase.WriteToCell(i, j, str);
            dataBase.Save();
            dataBase.Close();
        }
    }
}
