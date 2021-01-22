using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdleClickerEngine;

namespace Cookie_Clicker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyUnits.InitiateDictionary("MyUnits.txt");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CookieForm((int)Math.Pow(10,MyInfo.Level), (int)Math.Pow(10, MyInfo.Level-1)));
        }
    }
}
