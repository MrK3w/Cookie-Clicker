using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using IdleClickerEngine;

namespace Cookie_Clicker
{
    public partial class ShopForm : Form
    { 
        public ShopForm()
        {
            InitializeComponent();
       
        }

        /// <summary>
        /// Add one basic unit and remove coins, which cost that unit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void basicUnit_Click(object sender, EventArgs e)
        {
            if (!MyUnits.BuyBasicUnit()) MessageBox.Show("You don't have enough coins!");
        }


        /// <summary>
        /// Add one intermediate unit and remove coins, which cost that unit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IntermediateUnit_Click(object sender, EventArgs e)
        {
            if (!MyUnits.BuyIntermediateUnit()) MessageBox.Show("You don't have enough coins!");
        }

    }
}
