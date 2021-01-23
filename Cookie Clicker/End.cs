using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
        }

        /// <summary>
        /// End of game application will be closed after 5 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndTimer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
