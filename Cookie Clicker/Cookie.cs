using System;
using System.Configuration;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using IdleClickerEngine;

namespace Cookie_Clicker
{
    public partial class CookieForm : Form
    {
        //Your passive dmg per second
        private BigInteger _countDps;
        //instance of shop form
        private readonly ShopForm _shop;

        //remained hp of monster
        private BigInteger _remainingHealth;

        private readonly BigInteger _monsterHealth, _rewardForKillingMonster;

        //Helathbar
        private readonly HealthBar _healthBar 
            = new HealthBar(new Rectangle(245, 480, 405, 44));

        public CookieForm(BigInteger monsterHealth, BigInteger rewardForKillingMonster)
        {
            InitializeComponent();
            _shop = new ShopForm();
           
            if (MyInfo.Level == 6) TheEnd();

            _remainingHealth = monsterHealth;
            _rewardForKillingMonster = rewardForKillingMonster;
            _monsterHealth = monsterHealth;

            Paint += OnPaint;

            RefreshValues();
            
            LoadImage();

            InitializeFormInformations();
        }

        private void InitializeFormInformations()
        {
            Floor.Text = $"Floor {MyInfo.Level}";
            Text = $"Floor {MyInfo.Level}";
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
        /// This form is opened when you finish the game
        /// </summary>
        private void TheEnd()
        {
            End end = new End();
            end.ShowDialog();
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
            _countDps = MyUnits.GetDpsOfYourUnits();
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
            _shop.ShowDialog();
        }

        /// <summary>
        /// Open unit form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyUnitFormClickOpen(object sender, EventArgs e)
        {
            TableOfMyUnits units = new TableOfMyUnits();
            units.ShowDialog();
        }

        /// <summary>
        /// Action, which is invoked when form is closed, it will save your current state to file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cookie_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileWorker worker = new FileWorker("MyUnits.txt");
            worker.SaveUnits();
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
            BossEntry boss = new BossEntry(MyInfo.Level-1,(int)Math.Pow(10, MyInfo.Level+2));
            Dispose();
            boss.Show();
            

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
