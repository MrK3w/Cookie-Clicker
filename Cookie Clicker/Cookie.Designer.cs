
using System.Drawing;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    partial class CookieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.YourCoinsAndDps = new System.Windows.Forms.Label();
            this.shopButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.healthLabel = new System.Windows.Forms.Label();
            this.Floor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.ImagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoreTimer
            // 
            this.ScoreTimer.Enabled = true;
            this.ScoreTimer.Interval = 1000;
            this.ScoreTimer.Tick += new System.EventHandler(this.ScoreTimer_Tick);
            // 
            // YourCoinsAndDps
            // 
            this.YourCoinsAndDps.AutoSize = true;
            this.YourCoinsAndDps.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YourCoinsAndDps.ForeColor = System.Drawing.Color.Black;
            this.YourCoinsAndDps.Location = new System.Drawing.Point(642, 48);
            this.YourCoinsAndDps.Name = "YourCoinsAndDps";
            this.YourCoinsAndDps.Size = new System.Drawing.Size(93, 32);
            this.YourCoinsAndDps.TabIndex = 1;
            this.YourCoinsAndDps.Text = "label1";
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(648, 111);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(162, 90);
            this.shopButton.TabIndex = 2;
            this.shopButton.Text = "SHOP";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.MyShopFormClickOpen);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(69, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickOnMonster);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 90);
            this.button1.TabIndex = 3;
            this.button1.Text = "SHOW UNITS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MyUnitFormClickOpen);
            // 
            // ImagePanel
            // 
            this.ImagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImagePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImagePanel.Controls.Add(this.button1);
            this.ImagePanel.Controls.Add(this.shopButton);
            this.ImagePanel.Controls.Add(this.YourCoinsAndDps);
            this.ImagePanel.Controls.Add(this.pictureBox);
            this.ImagePanel.Location = new System.Drawing.Point(259, 61);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(971, 511);
            this.ImagePanel.TabIndex = 0;
            this.ImagePanel.TabStop = true;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Transparent;
            this.healthLabel.Font = new System.Drawing.Font("Noto Sans Arabic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.healthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.healthLabel.Location = new System.Drawing.Point(559, 607);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(87, 33);
            this.healthLabel.TabIndex = 4;
            this.healthLabel.Text = "label2";
            // 
            // Floor
            // 
            this.Floor.AutoSize = true;
            this.Floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Floor.ForeColor = System.Drawing.Color.Black;
            this.Floor.Location = new System.Drawing.Point(557, 9);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(145, 46);
            this.Floor.TabIndex = 4;
            this.Floor.Text = "Floor 1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 90);
            this.button2.TabIndex = 4;
            this.button2.Text = "BOSS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CookieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 758);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.ImagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CookieForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cookie_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ImagePanel.ResumeLayout(false);
            this.ImagePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Timer ScoreTimer;
        private Label YourCoinsAndDps;
        private Button shopButton;
        private PictureBox pictureBox;
        private Button button1;
        private Panel ImagePanel;
        private Label healthLabel;
        private Label Floor;
        private Button button2;
    }
}

