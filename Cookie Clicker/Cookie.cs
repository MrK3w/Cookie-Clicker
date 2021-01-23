using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using IdleClickerEngine;

namespace Cookie_Clicker
{
    public partial class CookieForm : Form
    {
        //Your passive dmg per second
        private BigInteger _countDps;

        //remained hp of monster
        private BigInteger _remainingHealth;

        private readonly MyUnits _units = MyUnits.GetInstance();

        private readonly BigInteger _monsterHealth, _rewardForKillingMonster;

        //Helathbar
        private readonly HealthBar _healthBar 
            = new HealthBar(new Rectangle(245, 480, 405, 44));

        public CookieForm(BigInteger monsterHealth, BigInteger rewardForKillingMonster)
        {
            InitializeComponent();

            _remainingHealth = monsterHealth;
            _rewardForKillingMonster = rewardForKillingMonster;
            _monsterHealth = monsterHealth;

            InitializeFormInformations();

            Paint += OnPaint;

            RefreshValues();
            this.FormClosing += ClosedByXButton;
            LoadImage();
        }


        //Set labels for floor on form and also on label
        private void InitializeFormInformations()
        {
            Floor.Text = $"Floor {MyInfo.Level}";
            Text = $"Floor {MyInfo.Level}";
        }

        /// <summary>
        /// Close form by clicking on x in upper bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosedByXButton(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Loading monster image
        /// </summary>
        private void LoadImage()
        {
            Images newImage = new Images();
            string path = newImage.GetImage();
            pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings[path]);
        }

        /// <summary>
        /// Refresh form and his values
        /// </summary>
        private void RefreshValues()
        {
            if (healthLabel != null)
            {
                healthLabel.Text = $@"{_remainingHealth}/{_monsterHealth}";
            }

            _countDps = _units.GetDpsOfYourUnits();

            YourCoinsAndDps.Text = "Your Dps: " + BigIntegerFormatter.FormatWithSuffix(_countDps)+"\n"+
                          "Coins: " + BigIntegerFormatter.FormatWithSuffix(MyInfo.Coins);
            Refresh();
        }

        /// <summary>
        /// Attack monster by specified damage.
        /// </summary>
        /// <param name="damage"> Damage which was dealt to monster. </param>
        private void AttackMonster(BigInteger damage)
        {
            _remainingHealth -= damage;
        }

        /// <summary>
        /// Method which controls clicking on monster.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickOnMonster(object sender, MouseEventArgs e)
        {
            AttackMonster(MyInfo.ClickDamage);
            IsMonsterStillAlive();
            RefreshValues();
        }

        /// <summary>
        /// Passive ticker which attacks on your monster.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScoreTimer_Tick(object sender, EventArgs e)
        {
            AttackMonster(_countDps);
            IsMonsterStillAlive();
            RefreshValues();
        }

        /// <summary>
        /// Opening another shopping form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyShopFormClickOpen(object sender, EventArgs e)
        {
            ShopForm shop = new ShopForm();
            shop.ShowDialog();
        }


        /// <summary>
        /// Method validate if monster is still alive, otherwise reset monster and add your reward.
        /// </summary>
        public void IsMonsterStillAlive()
        {
            if (_remainingHealth > 0)
            {
                return;
            }

            _remainingHealth = _monsterHealth;
            MyInfo.Coins += _rewardForKillingMonster;
            LoadImage();

        }

        /// <summary>
        /// Opening new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenBossForm(object sender, EventArgs e)
        {
            BossEntry boss = new BossEntry((int)Math.Pow(10, MyInfo.Level+2));
            Dispose();
            boss.Show();
        }

        /// <summary>
        /// Save your units on clicking this button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveUnits(object sender, EventArgs e)
        {
            FileWorker worker = new FileWorker("MyUnits.txt");
            worker.SaveUnits();
        }
        
        /// <summary>
        /// Open form with datagrid of all yours unit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowUnits(object sender, EventArgs e)
        {
            TableOfMyUnits units = new TableOfMyUnits();
            units.ShowDialog();
        }



        /// <summary>
        /// Event for drawing health bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPaint(object sender, PaintEventArgs e)
        {
            _healthBar.DrawHealth(e, _remainingHealth,_monsterHealth);
        }
    }
}
