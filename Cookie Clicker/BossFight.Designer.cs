
namespace Cookie_Clicker
{
    partial class BossFight
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
            this.Floor = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.YourCoinsAndDps = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bossTimeTicker = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Floor
            // 
            this.Floor.AutoSize = true;
            this.Floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Floor.ForeColor = System.Drawing.Color.Black;
            this.Floor.Location = new System.Drawing.Point(538, 37);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(132, 46);
            this.Floor.TabIndex = 7;
            this.Floor.Text = "BOSS";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Transparent;
            this.healthLabel.Font = new System.Drawing.Font("Noto Sans Arabic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.healthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.healthLabel.Location = new System.Drawing.Point(558, 615);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(87, 33);
            this.healthLabel.TabIndex = 8;
            this.healthLabel.Text = "label2";
            // 
            // ImagePanel
            // 
            this.ImagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImagePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImagePanel.Controls.Add(this.YourCoinsAndDps);
            this.ImagePanel.Controls.Add(this.pictureBox);
            this.ImagePanel.Location = new System.Drawing.Point(240, 89);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(971, 511);
            this.ImagePanel.TabIndex = 5;
            this.ImagePanel.TabStop = true;
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
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(90, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.BossAttackClick);
            // 
            // bossTimeTicker
            // 
            this.bossTimeTicker.Interval = 1000;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time.Location = new System.Drawing.Point(47, 104);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(122, 44);
            this.time.TabIndex = 9;
            this.time.Text = "label1";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BossFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 758);
            this.Controls.Add(this.time);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.ImagePanel);
            this.Name = "BossFight";
            this.Text = "FightingBoss";
            this.ImagePanel.ResumeLayout(false);
            this.ImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Floor;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Label YourCoinsAndDps;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer bossTimeTicker;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer Timer;
    }
}