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
        public Dictionary<string, Unit> UnitDictionary;

        public ShopForm()
        {
            InitializeComponent();
            InitiateDictionary();
        }
        /// <summary>
        /// Every second count your passive points
        /// </summary>
        /// <returns></returns>
        public int ReturnUnits()
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
        /// Add one basic unit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void basicUnit_Click(object sender, EventArgs e)
        {
            if(Cookie.Count >= UnitDictionary["basic unit"].price)
            {
                UnitDictionary["basic unit"].countOfUnit += 1;
                Cookie.Count -= UnitDictionary["basic unit"].price;
            }
            else
            {
                MessageBox.Show("You don't have enough clicks!");
            }
        }

        /// <summary>
        ///  Add one unit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Cookie.Count >= UnitDictionary["intermediate unit"].price)
            {
                UnitDictionary["intermediate unit"].countOfUnit += 1;
                Cookie.Count -= UnitDictionary["intermediate unit"].price;
            }
            else
            {
                MessageBox.Show("You don't have enough clicks!");
            }
        }

        private void InitiateDictionary()
        {
            if (File.Exists("MyUnits.txt"))
            {
                StreamReader reader = new StreamReader("MyUnits.txt");
                string text = reader.ReadLine();
                UnitDictionary = JsonConvert.DeserializeObject<Dictionary<string, Unit>>(text);
                reader.Close();
            }
            else{
                UnitDictionary = new Dictionary<string, Unit>
                {
                    { "basic unit", new Unit(0,TypeOfUnit.MeleePower,10,1) },
                    { "intermediate unit", new Unit(0,TypeOfUnit.MagicalPower,1000,10) },
                };
            }
        }
    }
}
