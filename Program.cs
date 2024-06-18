using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using DataBase;

namespace WindowsFormsTrec
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TransactionDataBase dataBase = new TransactionDataBase("Test");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginFormNew());

            //string accName = "Test";
            //string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //Путь к документам
            //string filePath = Path.Combine(documentsPath, $"{accName}{DateTime.Today.Year}DataBase.xlsx"); //Путь к файлу

            //TransactionDataBase dataBase;

            //if (!File.Exists(filePath))
            //    dataBase = new TransactionDataBase("Test", 1); //Если файл не существует
            //else 
            //    dataBase = new TransactionDataBase("Test"); //Если файл существует

            //dataBase.OpenFile();
            //dataBase.CloseFile();

            //dataBase.OpenFile();
            //dataBase.AddNewTransaction(1, "1", DateTime.Today.ToShortDateString(), 1500);
            //dataBase.AddNewTransaction(2, "6", DateTime.Today.ToShortDateString(), 1500);
            //dataBase.AddNewTransaction(1, "4", DateTime.Today.ToShortDateString(), 1500);
            //dataBase.AddNewTransaction(2, "Прочие Р.", DateTime.Today.ToShortDateString(), 1500);
            //dataBase.AddNewTransaction(1, "4", DateTime.Today.ToShortDateString(), 1500);
            ////dataBase.AddNewCategory("Новая", 1);
            //dataBase.AddNewTransaction(1, "Новая", "01.01.2024", 1000);
            //dataBase.SaveAndExit();

            //dataBase.OpenFile();
            //dataBase.AddNewCategory("Новая", 1);
            //dataBase.AddNewCategory("Последняя", 2);
            //dataBase.AddNewCategory("НЕПоследняя)", 2);
            //dataBase.SaveAndExit();

            //  Application.EnableVisualStyles();
            //  Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new LoginForm());
            //  TransactionDataBase dataBase = new TransactionDataBase("Test");
            //  Application.EnableVisualStyles();
            //  Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new FormMain());
        }
    }
}