using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace DataBase
{
    public class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb; //Текущий документ
        Worksheet ws; //Текущий лист

        public Excel() { }
        public Excel(string path)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[1];
        }

        public void CreateNewFile() //Создание нового файла
        {
            wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            ws = wb.Worksheets[1];
        }
        public void CreateNewSheet() //Создание нового листа после текущего
        {
            Worksheet temptSheet = wb.Worksheets.Add(After: ws);
        }

        public void SwitchWorkSheet(int sheet) //Переключение на лист по номеру
        {
            this.ws = wb.Worksheets[sheet];
        }

        public string ReadCell(int i, int j) //Чтение из клетки (текст)
        {
            i++; j++;
            if (ws.Cells[i,j].Value2 != null)
                return ws.Cells[i,j].Value2;
            return "";
        }

        public string[,] ReadRange(int starti, int startj, int endi, int endj) //Чтение целого диапазона клеток
        {
            string[,] result = new string[endi - starti, endj - startj];
            for (int i = starti; i <= endi; i++)
            {
                for (int j = startj; j <= endj - startj; j++)
                {
                    result[i - starti, j - startj] = ws.Cells[i, j].ToString();
                }
            }
            return result;
        }

        public void WriteToCell(int i, int j, string str) //Запись в клетку (текст)
        {
            i++; j++;
            ws.Cells[i, j].Value2 = str;
        }

        public void WriteRange(int starti, int startj, int endi, int endj, string[,] data)
        {
            for (int i = starti; i <= endi; i++)
            {
                for (int j = startj; j <= endj; j++)
                {
                    string str = data[i - starti, j - startj].ToString();
                    ws.Cells[i, j].Value2 = str;
                }
            }
        }

        public void Save() //Сохранить
        {
            wb.Save();
        }
        
        public void SaveAs(string path) //Сохранить как
        {
            wb.SaveAs(path);
        }

        public void Open()
        {
            wb = excel.Workbooks.Open(path);
        }

        public void Close() //Закрыть файл
        {
            wb.Close();
        }
    }
}
