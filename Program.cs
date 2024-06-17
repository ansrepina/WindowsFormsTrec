using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataBase;

namespace WindowsFormsTrec
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // TransactionDataBase dataBase = new TransactionDataBase("Test3");
           // dataBase.OpenFile();
            Application.Run(new FormMain());
           // dataBase.OpenFile();


           // string[] aboba = { "hfpd", "asd", "bang" };

            //Application.Run(new LoginForm());
            // TransactionDataBase dataBase = new TransactionDataBase("Test");
            /* dataBase.AddNewCategory("Новая", 1);
             dataBase.AddNewCategory("Последняя", 2);
             dataBase.AddNewCategory("НЕПоследняя)", 2);*/


            // dataBase.CloseFile();
        }
    }
}