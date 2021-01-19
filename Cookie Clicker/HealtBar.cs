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
    public partial class HealtBar : Form
    {
        public HealtBar()
        {
            InitializeComponent();
            Paint += HealtBar_Paint;

        }

        private Rectangle progressBar = new Rectangle(0,0,0,0);
        private Graphics gr;

        public void DrawBar(Brush color)
        {
            gr = CreateGraphics();
            gr.FillRectangle(Brushes.DarkRed, progressBar);
            gr.DrawRectangle(new Pen(color), progressBar);
            gr.FillRectangle(Brushes.DarkRed,
                new Rectangle(progressBar.X, progressBar.Y, (progressBar.Width * percent(1000, 1000)) / 100,
                    progressBar.Height));
        }


        public int percent(double total, double current)
        {
            return (int) ((current / total) * 100);
        }

        private void HealtBar_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            System.Drawing.Graphics formGraphics = e.Graphics; //this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
        }
    }
}
