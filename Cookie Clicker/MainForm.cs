using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Cookie_Clicker
{
    public partial class Cookie : Form
    {
        public static int Count;
        private readonly ShopForm _shopForm;

        public Cookie()
        {
            InitializeComponent();
          
            _shopForm = new ShopForm();
            unitView.BackgroundColor = SystemColors.Control;

            RefreshDataGrid();
            RefreshValue();

            pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings["ImagePath"]);
   
        }

        /// <summary>
        /// Store units into data grid
        /// </summary>
        private void RefreshDataGrid()
        {
                unitView.DataSource = (from entry in _shopForm.UnitDictionary
                orderby entry.Key
                select new { entry.Key, entry.Value }).ToList();
                unitView.Columns[0].HeaderText = "Unit";
                unitView.Columns[1].HeaderText = "Count";
        }

        /// <summary>
        /// Refresh button label
        /// </summary>
        private void RefreshValue()
        {
            label1.Text = "Points: " + Count;
        }

        /// <summary>
        /// Adding 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Click(object sender, MouseEventArgs e)
        {
            Count++;
            RefreshValue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScoreTimer_Tick(object sender, EventArgs e)
        {
            Count +=  _shopForm.ReturnUnits();
            RefreshDataGrid();
            RefreshValue();
        }

        /// <summary>
        /// Opening another shopping form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShoppingFomrButtonClick(object sender, EventArgs e)
        {
            _shopForm.ShowDialog();
        }
    }
}
