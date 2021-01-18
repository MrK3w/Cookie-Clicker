
namespace Cookie_Clicker
{
    partial class MyUnit
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
            this.unitView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.unitView)).BeginInit();
            this.SuspendLayout();
            // 
            // unitView
            // 
            this.unitView.AllowUserToAddRows = false;
            this.unitView.AllowUserToDeleteRows = false;
            this.unitView.AllowUserToResizeColumns = false;
            this.unitView.AllowUserToResizeRows = false;
            this.unitView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.unitView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitView.Location = new System.Drawing.Point(21, 41);
            this.unitView.Name = "unitView";
            this.unitView.RowHeadersVisible = false;
            this.unitView.RowHeadersWidth = 51;
            this.unitView.RowTemplate.Height = 24;
            this.unitView.Size = new System.Drawing.Size(710, 285);
            this.unitView.TabIndex = 2;
            // 
            // MyUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unitView);
            this.Name = "MyUnit";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.unitView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView unitView;
    }
}