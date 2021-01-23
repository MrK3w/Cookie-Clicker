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
        private void basicUnit_BuyOneClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("basic unit",1)) MessageBox.Show("You don't have enough coins!");
        }


        /// <summary>
        /// Add one intermediate unit and remove coins, which cost that unit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IntermediateUnit_BuyOneClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("intermediate unit",1)) MessageBox.Show("You don't have enough coins!");
        }

        private void HardUnit_BuyOneClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("hard unit",1)) MessageBox.Show("You don't have enough coins!");
        }

        private void ExtremeUnit_BuyOneClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit( "extreme unit",1)) MessageBox.Show("You don't have enough coins!");

        }

        private void BasicUnit_BuyTenClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("basic unit", 10)) MessageBox.Show("You don't have enough coins!");
        }

        private void IntermediateUnit_BuyTenClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("intermediate unit", 10)) MessageBox.Show("You don't have enough coins!");
        }

        private void HardUnit_BuyTenClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit( "hard unit", 10)) MessageBox.Show("You don't have enough coins!");
        }

        private void ExtremeUnit_BuyTenClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit( "extreme unit", 10)) MessageBox.Show("You don't have enough coins!");

        }

        private void BasicUnit_BuyOneHundredClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("basic unit", 100)) MessageBox.Show("You don't have enough coins!");
        }

        private void IntermediateUnit_BuyOneHundredClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("intermediate unit",100)) MessageBox.Show("You don't have enough coins!");
        }

        private void HardUnit_BuyOneHundredClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("hard unit",100)) MessageBox.Show("You don't have enough coins!");
        }

        private void ExtremeUnit_BuyOneHundredClick(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("extreme unit",100)) MessageBox.Show("You don't have enough coins!");

        }

        private void BuyAllBasicUnit(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("basic unit")) MessageBox.Show("You don't have enough coins!");
        }

        private void BuyAllIntermediateUnit(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("intermediate unit")) MessageBox.Show("You don't have enough coins!");
        }

        private void BuyAllHardUnit(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("hard unit")) MessageBox.Show("You don't have enough coins!");
        }

        private void BuyAllExtremeUnit(object sender, EventArgs e)
        {
            if (!MyUnits.NewUnit("extreme unit")) MessageBox.Show("You don't have enough coins!");
        }
    }
}
