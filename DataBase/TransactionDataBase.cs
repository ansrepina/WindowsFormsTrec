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
        private Excel dataBase;
        private string accName;

        public TransactionDataBase(string accName) { this.accName = accName; CreateDataBase(); }

        public void CreateDataBase()
        {
            dataBase = new Excel();
            dataBase.CreateNewFile();
            WriteHeadLines();
            dataBase.SaveAs($@"{accName}DataBase.xlsx");
            dataBase.Close();
        }

        public void WriteHeadLines()
        {
            string[,] head = { { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"} };
            dataBase.WriteRange(1, 2, 1, 13, head);
            dataBase.CreateNewSheet();
            dataBase.SwitchWorkSheet(2);
            dataBase.WriteRange(1, 2, 1, 13, head);
        }

        public void OpenFile()
        {
            dataBase = new Excel($@"{accName}DataBase.xlsx");
        }

        public void SwitchDataBaseSheet(int sheet)
        {
            dataBase.SwitchWorkSheet(sheet);
        }

        public string ReadData(int sheet, int i, int j, string str)
        {
            OpenFile();
            string result = dataBase.ReadCell(i, j);
            dataBase.Close();
            return result;
        }

        public void WriteData(int sheet, int i, int j, string str)
        {
            OpenFile();
            dataBase.WriteToCell(i, j, str);
            dataBase.Save();
            dataBase.Close();
        }
    }
}
