using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdleClickerEngine;

namespace Cookie_Clicker
{
    public partial class Base : Form
    {
        public Base()
        {
            
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.Load += new EventHandler(Form1_Load);

        }

        private void Base_Load(object sender, EventArgs e)
        {
            CookieForm newCookie = new CookieForm((int)Math.Pow(10, MyInfo.Level), (int)Math.Pow(10, MyInfo.Level - 1));
            newCookie.ShowDialog();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(0, 0);
        }
    }
}
