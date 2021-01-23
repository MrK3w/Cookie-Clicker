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
        private readonly MyUnits _units = MyUnits.GetInstance();

        public ShopForm()
        {
            InitializeComponent();
       
        }

        /// <summary>
        /// Add one unit and remove coins, which cost that unit.
        /// </summary>
        #region BuyOneUnit
        private void basicUnit_BuyOneClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("basic unit",1)) MessageBox.Show("You don't have enough coins!");
        }

        private void IntermediateUnit_BuyOneClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("intermediate unit",1)) MessageBox.Show("You don't have enough coins!");
        }

        private void HardUnit_BuyOneClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("hard unit",1)) MessageBox.Show("You don't have enough coins!");
        }

        private void ExtremeUnit_BuyOneClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit( "extreme unit",1)) MessageBox.Show("You don't have enough coins!");

        }
        #endregion

        /// <summary>
        /// Buy ten units with one click
        /// </summary>
        #region BuyTenUnits
        private void BasicUnit_BuyTenClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("basic unit", 10)) MessageBox.Show("You don't have enough coins!");
        }

        private void IntermediateUnit_BuyTenClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("intermediate unit", 10)) MessageBox.Show("You don't have enough coins!");
        }

        private void HardUnit_BuyTenClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("hard unit", 10)) MessageBox.Show("You don't have enough coins!");
        }

        private void ExtremeUnit_BuyTenClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("extreme unit", 10)) MessageBox.Show("You don't have enough coins!");

        }
        #endregion

        /// <summary>
        /// Buy one hundred units with one click
        /// </summary>
        #region BuyOneHundredUnits
        private void BasicUnit_BuyOneHundredClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("basic unit", 100)) MessageBox.Show("You don't have enough coins!");
        }

        private void IntermediateUnit_BuyOneHundredClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("intermediate unit", 100)) MessageBox.Show("You don't have enough coins!");
        }

        private void HardUnit_BuyOneHundredClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("hard unit", 100)) MessageBox.Show("You don't have enough coins!");
        }

        private void ExtremeUnit_BuyOneHundredClick(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("extreme unit", 100)) MessageBox.Show("You don't have enough coins!");
        }
        #endregion

        /// <summary>
        /// Buy units for all your coins
        /// </summary>
        #region BuyAllUnits
        private void BuyAllBasicUnit(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("basic unit")) MessageBox.Show("You don't have enough coins!");
        }

        private void BuyAllIntermediateUnit(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("intermediate unit")) MessageBox.Show("You don't have enough coins!");
        }

        private void BuyAllHardUnit(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("hard unit")) MessageBox.Show("You don't have enough coins!");
        }

        private void BuyAllExtremeUnit(object sender, EventArgs e)
        {
            if (!_units.BuyUnit("extreme unit")) MessageBox.Show("You don't have enough coins!");
        }
        #endregion

    }
}
