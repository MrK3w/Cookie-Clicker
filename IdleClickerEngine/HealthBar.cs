using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace IdleClickerEngine
{
    public class HealthBar
    {
            private Rectangle _progressBar;

            public HealthBar(Rectangle progressBar)
            {
                _progressBar = progressBar;
            }

            public int PercentOfHealth(double total, double current)
            {
                return (int)(current / total * 100);
            }

            public void DrawHealth(PaintEventArgs e, BigInteger remainingHealth, BigInteger monsterHealth)
            {
                e.Graphics.DrawRectangle(new Pen(Brushes.Red), _progressBar);
                e.Graphics.FillRectangle(Brushes.Red,
                    new Rectangle(_progressBar.X, _progressBar.Y,
                        (_progressBar.Width * PercentOfHealth((double)monsterHealth, (double)remainingHealth)) / 100,
                        _progressBar.Height));
            }
    }
}