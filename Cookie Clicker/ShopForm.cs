using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    public partial class ShopForm : Form
    {
        /// <summary>
        /// Defining a dictionary for saving a units
        /// </summary>
        public Dictionary<string, Unit> UnitDictionary { get; private set; }

        public ShopForm()
        {
            InitializeComponent();
            InitiateDictionary("MyUnits.txt");
        }

        /// <summary>
        /// Every second count your passive points
        /// </summary>
        /// <returns></returns>
        public int GetDpsOfYourUnits()
        {
            int sum = 0;
            foreach (KeyValuePair<string, Unit> unit in UnitDictionary)
            {
                if (unit.Key == "basic unit")
                {
                    sum += unit.Value.countOfUnit * unit.Value.damageDealt;
                }

                if (unit.Key == "intermediate unit")
                {
                    sum += unit.Value.countOfUnit * unit.Value.damageDealt;
                }
            }

            return sum;
        }

        /// <summary>
        /// Add one basic unit and remove coins, which cost that unit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void basicUnit_Click(object sender, EventArgs e)
        {
            if(CookieForm.Coins >= UnitDictionary["basic unit"].price)
            {
                UnitDictionary["basic unit"].countOfUnit += 1;
                CookieForm.Coins -= UnitDictionary["basic unit"].price;
            }
            else
            {
                MessageBox.Show("You don't have enough coins!");
            }
        }


        /// <summary>
        /// Add one intermediate unit and remove coins, which cost that unit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void intermediateUnit_Click(object sender, EventArgs e)
        {
            if (CookieForm.Coins >= UnitDictionary["intermediate unit"].price)
            {
                UnitDictionary["intermediate unit"].countOfUnit += 1;
                CookieForm.Coins -= UnitDictionary["intermediate unit"].price;
            }
            else
            {
                MessageBox.Show("You don't have enough coins!");
            }
        }

        //Prepare your dictionary on start of the program
        private void InitiateDictionary(string path)
        {
            if (!File.Exists(path))
            {
                InitiateDictionaryWithoutFile();
            }
            else
            {
                InitiateDictionaryFromFile(path);
            }
        }

        /// <summary>
        /// Initiate dictionary from file
        /// </summary>
        private void InitiateDictionaryWithoutFile()
        {
            UnitDictionary = new Dictionary<string, Unit>
            {
                {"basic unit", new Unit(0, TypeOfUnit.MeleePower, 10, 1)},
                {"intermediate unit", new Unit(0, TypeOfUnit.MagicalPower, 100, 10)},
            };
        }


        private void InitiateDictionaryFromFile(string path)
        {
            FileWorker worker = new FileWorker(path);
            UnitDictionary = worker.LoadUnits();
        }
    }
}
