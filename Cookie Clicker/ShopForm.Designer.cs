
namespace Cookie_Clicker
{
    partial class ShopForm
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
            this.basicUnit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondUnitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basicUnit
            // 
            this.basicUnit.Location = new System.Drawing.Point(480, 14);
            this.basicUnit.Name = "basicUnit";
            this.basicUnit.Size = new System.Drawing.Size(116, 56);
            this.basicUnit.TabIndex = 0;
            this.basicUnit.Text = "Add";
            this.basicUnit.UseVisualStyleBackColor = true;
            this.basicUnit.Click += new System.EventHandler(this.basicUnit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add one unit price: 10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add one unit price: 100";
            // 
            // SecondUnitButton
            // 
            this.SecondUnitButton.Location = new System.Drawing.Point(480, 115);
            this.SecondUnitButton.Name = "SecondUnitButton";
            this.SecondUnitButton.Size = new System.Drawing.Size(116, 56);
            this.SecondUnitButton.TabIndex = 3;
            this.SecondUnitButton.Text = "Add";
            this.SecondUnitButton.UseVisualStyleBackColor = true;
            this.SecondUnitButton.Click += new System.EventHandler(this.IntermediateUnit_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SecondUnitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basicUnit);
            this.Name = "ShopForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button basicUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SecondUnitButton;
    }
}