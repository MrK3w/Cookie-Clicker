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
        public BossEntry(int levelOfBoss, int bossHp)
        {
            InitializeComponent();
            SettingOfForm(levelOfBoss, bossHp);
        }

        private void SettingOfForm(int levelOfBoss, int bossHp)
        {
            Boss newBoss = new Boss();
            newBoss.GetBossInformation(levelOfBoss, out string image, out string bossName, out string bossText);
            pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings[image]);
            labelBossName.Text = bossName;
            labelTextOfBoss.Text = bossText;
            labelBossHp.Text = $"{bossHp}HP";
            Text = bossName;
        }
    }
}
