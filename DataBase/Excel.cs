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

        public Excel() { } //Для новых файлов
        public Excel(string path) //Для существующего файла
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[1];
        }

        // Работа с файлом и листами
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
        public void ChangeSheetName(string newName) //Смена имени листа
        {
            ws.Name = newName;
        }

        public void Save() //Сохранить
        {
            wb.Save();
        }
        public void SaveAs(string path) //Сохранить как
        {
            wb.SaveAs(path);
        }

        public void Close() //Закрыть файл
        {
            wb.Close();
        }


        // Формулы
        public void WriteSumFormula(int i, int j, int starti, int startj, int endi, int endj) //Сумма диапазона в ячейку
        {
            string formula = $"=SUM({ws.Cells[starti, startj].Address}:{ws.Cells[endi, endj].Address})";
            ws.Cells[i, j].Formula = formula;
        }
        public void WriteSumFormulaToRange(int startR, int startC, int endR, int endC, int starti, int startj, int endi, int endj) //Cуммы диапазонов в диапазон
        {
            for (int i = startR; i <= endR; i++)
            {
                for (int j = startC; j <= endC; j++)
                {
                    string formula = $"=SUM({ws.Cells[starti + i - startR, startj + j - startC].Address}:{ws.Cells[endi + i - startR, endj + j - startC].Address})";
                    ws.Cells[i, j].Formula = formula;
                }
            }
        }

        public void WriteLinkFormula(string listName, int i, int j,int linki, int linkj) //Запись ссылки в ячейку
        {
            string formula = $"='{listName}'!{ws.Cells[linki, linkj].Address}";
            ws.Cells[i, j].Formula = formula;
        }
        public void WriteLinkFormulaToRange(string listName, int startR, int startC, int endR, int endC, int starti, int startj, int endi, int endj) //Запись ссылки в диапазон
        {
            for (int i = startR; i <= endR; i++)
            {
                for (int j = startC; j <= endC; j++)
                {
                    WriteLinkFormula(listName, i, j, starti + i - startR, startj + j - startC);
                }
            }
        }


        // Чтение
        public string ReadCell(int i, int j) //Чтение из клетки (текст)
        {
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2.ToString();
            return "";
        }
        public string[] ReadLine(int i, int startj, int endj)
        {
            string[] values = new string[endj - startj + 1];
            for (int j = 0; j < endj - startj + 1; j++)
            {
                values[j] = ReadCell(i, j + startj);
            }
            return values;
        }
        public string[,] ReadRange(int starti, int startj, int endi, int endj) //Чтение целого диапазона клеток
        {
            Range range = ws.Range[ws.Cells[starti, startj], ws.Cells[endi, endj]];
            object[,] rangeValues = range.Value2;
            string[,] values = new string[rangeValues.GetLength(0), rangeValues.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    values[i, j] = rangeValues[i + 1, j + 1] != null ? rangeValues[i + 1, j + 1].ToString() : "";
                }
            }
            return values;
        }
        public double[,] ReadDoubleRange(int starti, int startj, int endi, int endj) //Чтение целого диапазона клеток с ЧИСЛАМИ!!!
        {
            var range = ws.Range[ws.Cells[starti, startj], ws.Cells[endi, endj]];
            object[,] rangeValues = range.Value2;
            double[,] values = new double[rangeValues.GetLength(0), rangeValues.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    values[i, j] = rangeValues[i + 1, j + 1] != null ? double.Parse(rangeValues[i + 1, j + 1].ToString()) : 0;
                }
            }
            return values;
        }

        // Запись
        public void WriteToCell(int i, int j, string str) //Запись в клетку (текст)
        {
            ws.Cells[i, j].Value2 = str;
        }
        public void WriteRange(int starti, int startj, int endi, int endj, string[,] data) //Запись массива в диапазон клеток
        {
            var range = ws.Range[ws.Cells[starti, startj], ws.Cells[endi, endj]];
            range.Value2 = data;
        }


        //Редактирование
        public void AddToCell(int i, int j, double value) //Увеличить значение ячейки на величину value
        {
            double cellValue = 0;
            string stringCellValue = ReadCell(i, j);
            if (stringCellValue != "")
            {
                cellValue = double.Parse(stringCellValue);
                cellValue += value;
                WriteToCell(i, j, cellValue.ToString());
            }
        }
        public void MoveCell(int i, int j, int newi, int newj) //Сдвиг одной клетки
        {
            WriteToCell(newi, newj, ReadCell(i, j));
            WriteToCell(i, j, "");
        }
        public void MoveRange(int starti, int startj, int endi, int endj, int newStarti, int newStartj) //Сдвиг диапазона
        {
            int newEndi = newStarti + endi - starti;
            int newEndj = newStartj + endj - startj;
            string[,] str = ReadRange(starti, startj, endi, endj);
            ClearRange(starti, startj, endi, endj);
            WriteRange(newStarti, newStartj, newEndi, newEndj, str);
        }
        public void FillRange(int starti, int startj, int endi, int endj, string str) //Заполнение всех клеток
        {
            string[,] Filler = new string[endi - starti + 1, endj - startj + 1];
            for (int i = 0; i < Filler.GetLength(0); i++)
            {
                for (int j = 0; j < Filler.GetLength(1); j++)
                {
                    Filler[i, j] = str;
                }
            }
            WriteRange(starti, startj, endi, endj, Filler);
        }
        public void ClearRange(int starti, int startj, int endi, int endj) //Очистка диапазона
        {
            FillRange(starti, startj, endi, endj, "");
        }
    }
}
