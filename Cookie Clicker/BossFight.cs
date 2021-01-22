using IdleClickerEngine;
using System;
using System.Configuration;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    public partial class BossFight : Form
    {
        private readonly BigInteger _bossHp;
        private readonly string _image;
        private int _timer = 30;
        private BigInteger _countDps;
        private BigInteger _remainingHealth;

        private readonly HealthBar _healthBar
            = new HealthBar(new Rectangle(245, 480, 405, 44));

        public BossFight(BigInteger bossHp,string image)
        {
            InitializeComponent();
            Paint += OnPaint;

            _bossHp = bossHp;
            _image = image;
           
            _remainingHealth = _bossHp;
            RefreshValues();
            LoadImage();
        }

        private void RefreshValues()
        {
            if (healthLabel != null)
            {
                healthLabel.Text = $@"{_remainingHealth}/{_bossHp}";
            }

            time.Text = _timer + "s remaining";
            YourCoinsAndDps.Text = "Your Dps: " + BigIntegerFormatter.FormatWithSuffix(_countDps) + "\n" +
                                   "Coins: " + BigIntegerFormatter.FormatWithSuffix(MyInfo.Coins);
            Refresh();
        }

        private void LoadImage()
        { 
            pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings[_image]);
        }

        /// <summary>
        /// Attack monster by specified damage.
        /// </summary>
        /// <param name="damage"> Damage which was dealt to monster. </param>
        private void AttackMonster(BigInteger damage)
        {
            _remainingHealth -= damage;
        }

        public void IsMonsterStillAlive()
        {
            if (_remainingHealth <= 0)
            {
                _remainingHealth = 0;
                RefreshValues();
                Timer.Enabled = false;
                MessageBox.Show("You Won");
                MyInfo.Level++;
                Hide();
                CookieForm newCookieForm = new CookieForm((int)Math.Pow(10, MyInfo.Level + 1), (int)Math.Pow(10, MyInfo.Level - 1));
                newCookieForm.ShowDialog();
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            _healthBar.DrawHealth(e, _remainingHealth, _bossHp);
        }

        private void BossAttackClick(object sender, EventArgs e)
        {
            AttackMonster(MyInfo.ClickDamage);
            IsMonsterStillAlive();
            RefreshValues();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _countDps = MyUnits.GetDpsOfYourUnits();
            AttackMonster(_countDps);
            if (_timer <= 0)
            {
                time.Text = 0 + "s remaining";
                Timer.Enabled = false;
                MessageBox.Show("You Lost!");
                Hide();
                CookieForm newCookieForm = new CookieForm((int)Math.Pow(10, MyInfo.Level), (int)Math.Pow(10, MyInfo.Level - 1));
                newCookieForm.ShowDialog();
            }

            IsMonsterStillAlive();

            RefreshValues();
            _timer--;
        }
    }
}
