using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Numerics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace Cookie_Clicker
{
    public partial class Cookie : Form
    {
        public static BigInteger Count = 999999999999;
        private readonly ShopForm _shopForm;

        public Cookie()
        {
            InitializeComponent();
          
            _shopForm = new ShopForm();
            RefreshValue();

            pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings["ImagePath"]);
   
        }


        /// <summary>
        /// Refresh button label
        /// </summary>
        private void RefreshValue()
        {
            label1.Text = "Points: " + BigIntegerFormatter.FormatWithSuffix(Count);
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
            RefreshValue();
        }

        /// <summary>
        /// Opening another shopping form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShoppingFormButtonClick(object sender, EventArgs e)
        {
            _shopForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyUnit form = new MyUnit(_shopForm);
            form.ShowDialog();
        }

        private void Cookie_FormClosed(object sender, FormClosedEventArgs e)
        {
            string output = JsonConvert.SerializeObject(_shopForm.UnitDictionary);
            StreamWriter writer = new StreamWriter("MyUnits.txt");
            writer.WriteLine(output);
            writer.Close();

        }

    }
}
