using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Logic
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>


        static public Form_game fGame;
        static public Form1 f1;
        static public gameObjList gameList;

                [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            f1 = new Form1();
           
            Application.Run(f1);
        }
    }
}
