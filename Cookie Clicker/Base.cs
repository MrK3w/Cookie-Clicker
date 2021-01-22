using IdleClickerEngine;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    public partial class Base : Form
    {
        /// <summary>
        /// Hidden form, reason for this form is that you have to have opened base form when you want dispose opened forms
        /// </summary>
        public Base()
        {
            
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            Load += BaseFormLoad;

        }

        private void Base_Load(object sender, EventArgs e)
        {
            CookieForm newCookie = new CookieForm((int)Math.Pow(10, MyInfo.Level), (int)Math.Pow(10, MyInfo.Level - 1));
            newCookie.ShowDialog();
        }

        private void BaseFormLoad(object sender, EventArgs e)
        {
            Size = new Size(0, 0);
        }
    }
}
