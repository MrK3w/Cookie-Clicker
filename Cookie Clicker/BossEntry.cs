using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdleClickerEngine;

namespace Cookie_Clicker
{
    public partial class BossEntry : Form
    {
        private readonly int _bossHp;
        private string _image;
        public BossEntry(int bossHp)
        {
            _bossHp = bossHp;
            InitializeComponent();
            SettingOfForm();
        }
        
        //Get information about boss and set all lables in form
        private void SettingOfForm()
        {
            Boss newBoss = new Boss();
            newBoss.GetBossInformation(out string image, out string bossName, out string bossText);
           
            _image = image;
            pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings[image]);

            labelBossName.Text = bossName;
            labelTextOfBoss.Text = bossText;
            labelBossHp.Text = $"{_bossHp}HP";

            Text = bossName;
        }

        /// <summary>
        /// Open form with boss
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BossOpen(object sender, EventArgs e)
        {
            BossFight fightBoss = new BossFight( _bossHp, _image);
            Dispose();
            fightBoss.ShowDialog();
        }
    }
}
