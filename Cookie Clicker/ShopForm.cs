using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    public partial class ShopForm : Form
    {
        /// <summary>
        /// Defining a dictionary for saving a units
        /// </summary>
        public Dictionary<string, int> UnitDictionary = new Dictionary<string, int> 
        {
            { "basic unit", 0 },
            { "intermediate unit", 0 },
        };

        public ShopForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Every second count your passive points
        /// </summary>
        /// <returns></returns>
        public int ReturnUnits()
        {
            int sum = 0;
            foreach (var unit in UnitDictionary)
            {
                if (unit.Key == "basic unit") sum += unit.Value * 1;
                if (unit.Key == "intermediate unit") sum += unit.Value * 100;
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
            if(Cookie.Count >= 10)
            {
                UnitDictionary["basic unit"] += 1;
                Cookie.Count -= 10;
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
            if (Cookie.Count >= 100)
            {
                UnitDictionary["intermediate unit"] += 1;
                Cookie.Count -= 100;
            }
            else
            {
                MessageBox.Show("You don't have enough clicks!");
            }
        }
    }
}
