using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using IdleClickerEngine;

namespace Cookie_Clicker
{
    public partial class CookieForm : Form
    {
        //Your passive dmg per second
        public int CountDps;
        //instance of shop form
        private readonly ShopForm _shop;

        //remained hp of monster
        private int _remainingHealth;

        private readonly int _monsterHealth, rewardForKillingMonster = 1;

        //Total coins you have
        public static int Coins = 100000;

        //Your click damage
        private int _clickDamage = 1;

        private readonly HealthBar _healthBar 
            = new HealthBar(new Rectangle(245, 480, 405, 44));

        public CookieForm(int monsterHealth)
        {
            InitializeComponent();
            _shop = new ShopForm();

            _remainingHealth = monsterHealth;
            _monsterHealth = monsterHealth;

            Paint += OnPaint;

            RefreshValues();
            
            LoadImage();
          
        
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

            label1.Text = "Your Dps: " + BigIntegerFormatter.FormatWithSuffix(CountDps)+"\n"+
                          "Coins: " + Coins;
            Refresh();
        }

        /// <summary>
        /// Attack monster by specified damage.
        /// </summary>
        /// <param name="damage"> Damage which was dealt to monster. </param>
        private void AttackMonster(int damage)
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
            AttackMonster(_clickDamage);
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
            CountDps =  _shop.GetDpsOfYourUnits();
            AttackMonster(CountDps);
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
            _shop.ShowDialog();
        }

        /// <summary>
        /// Open unit form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyUnitFormClickOpen(object sender, EventArgs e)
        {
            MyUnit unit = new MyUnit(_shop);
            unit.ShowDialog();
        }

        /// <summary>
        /// Action, which is invoked when form is closed, it will save your current state to file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cookie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dictionary<string, Unit> dictionary = _shop.UnitDictionary;
            FileWorker worker = new FileWorker("MyUnits.txt");
            worker.SaveUnits(dictionary);
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
            Coins += rewardForKillingMonster;
            LoadImage();

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
