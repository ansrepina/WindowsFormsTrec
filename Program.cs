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
           // TransactionDataBase dataBase = new TransactionDataBase("Test");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new LoginForm());

            string accName = "Test";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, $"{accName}{DateTime.Today.Year}DataBase.xlsx");

            TransactionDataBase dataBase;

            if (!File.Exists(filePath))
                dataBase = new TransactionDataBase(accName, 1); //Если файл не существует
            else
                dataBase = new TransactionDataBase(accName); //Если файл существует
           // Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new LoginForm());
            //  TransactionDataBase dataBase = new TransactionDataBase("Test");
            //  Application.EnableVisualStyles();
            //  Application.SetCompatibleTextRenderingDefault(false);
            FormMain formMain = new FormMain();
            formMain.accName = accName;
            Application.Run(formMain);
            //dataBase.OpenFile();
            //double[,] lineDiag1 = dataBase.incomePlanFactDiagramData();
            //double[,] lineDiag2 = dataBase.outcomePlanFactDiagramData();
            //object[,] circDiag = dataBase.rangeCircleDiagramData("01.05.2024", "30.06.2024");
            //dataBase.CloseFile();
        }
    }
}