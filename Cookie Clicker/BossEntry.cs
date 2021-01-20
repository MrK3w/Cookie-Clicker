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
        private readonly int _levelOfBoss, _bossHp;
        private string _image;
        public BossEntry(int levelOfBoss, int bossHp)
        {
            _levelOfBoss = levelOfBoss;
            _bossHp = bossHp;
            InitializeComponent();
            SettingOfForm();
        }

        private void SettingOfForm()
        {
            Boss newBoss = new Boss();
            newBoss.GetBossInformation(_levelOfBoss, out string image, out string bossName, out string bossText);
            _image = image;
            pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings[image]);
            labelBossName.Text = bossName;
            labelTextOfBoss.Text = bossText;
            labelBossHp.Text = $"{_bossHp}HP";
            Text = bossName;
        }

        private void BossOpen(object sender, EventArgs e)
        {
            BossFight fightBoss = new BossFight( _bossHp, _image);
            Hide();
            fightBoss.ShowDialog();
        }
    }
}
