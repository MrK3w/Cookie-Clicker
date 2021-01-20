
namespace Cookie_Clicker
{
    partial class BossEntry
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelBossName = new System.Windows.Forms.Label();
            this.labelTextOfBoss = new System.Windows.Forms.Label();
            this.labelBossHp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(350, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelBossName
            // 
            this.labelBossName.BackColor = System.Drawing.Color.DarkRed;
            this.labelBossName.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBossName.Location = new System.Drawing.Point(350, 12);
            this.labelBossName.Name = "labelBossName";
            this.labelBossName.Size = new System.Drawing.Size(537, 40);
            this.labelBossName.TabIndex = 2;
            this.labelBossName.Text = "label1";
            this.labelBossName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTextOfBoss
            // 
            this.labelTextOfBoss.AutoSize = true;
            this.labelTextOfBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTextOfBoss.Location = new System.Drawing.Point(343, 506);
            this.labelTextOfBoss.Name = "labelTextOfBoss";
            this.labelTextOfBoss.Size = new System.Drawing.Size(103, 38);
            this.labelTextOfBoss.TabIndex = 3;
            this.labelTextOfBoss.Text = "label1";
            // 
            // labelBossHp
            // 
            this.labelBossHp.AutoSize = true;
            this.labelBossHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBossHp.ForeColor = System.Drawing.Color.DarkRed;
            this.labelBossHp.Location = new System.Drawing.Point(556, 556);
            this.labelBossHp.Name = "labelBossHp";
            this.labelBossHp.Size = new System.Drawing.Size(103, 38);
            this.labelBossHp.TabIndex = 4;
            this.labelBossHp.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BossEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelBossHp);
            this.Controls.Add(this.labelTextOfBoss);
            this.Controls.Add(this.labelBossName);
            this.Controls.Add(this.pictureBox);
            this.Name = "BossEntry";
            this.Text = "BossEntry";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelBossName;
        private System.Windows.Forms.Label labelTextOfBoss;
        private System.Windows.Forms.Label labelBossHp;
        private System.Windows.Forms.Button button1;
    }
}