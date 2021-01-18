
using System.Drawing;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    partial class Cookie
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
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePanel
            // 
            this.ImagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImagePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImagePanel.Controls.Add(this.button1);
            this.ImagePanel.Controls.Add(this.shopButton);
            this.ImagePanel.Controls.Add(this.label1);
            this.ImagePanel.Controls.Add(this.pictureBox);
            this.ImagePanel.Location = new System.Drawing.Point(266, 32);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(971, 511);
            this.ImagePanel.TabIndex = 0;
            this.ImagePanel.TabStop = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 90);
            this.button1.TabIndex = 3;
            this.button1.Text = "SHOW UNITS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(648, 83);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(162, 90);
            this.shopButton.TabIndex = 2;
            this.shopButton.Text = "SHOP";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.ShoppingFormButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(642, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Click);
            // 
            // ScoreTimer
            // 
            this.ScoreTimer.Enabled = true;
            this.ScoreTimer.Interval = 1000;
            this.ScoreTimer.Tick += new System.EventHandler(this.ScoreTimer_Tick);
            // 
            // Cookie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 577);
            this.Controls.Add(this.ImagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cookie";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cookie_FormClosed);
            this.ImagePanel.ResumeLayout(false);
            this.ImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ImagePanel;
        private PictureBox pictureBox;
        private Label label1;
        private Timer ScoreTimer;
        private Button shopButton;
        private Button button1;
    }
}

