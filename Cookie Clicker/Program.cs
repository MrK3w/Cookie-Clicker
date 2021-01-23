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
        private static readonly MyUnits Units = MyUnits.GetInstance();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Units.InitiateDictionary("MyUnits.txt");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Base());
        }
    }
}
