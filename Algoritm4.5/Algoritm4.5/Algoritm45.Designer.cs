namespace Algoritm4._5
{
    partial class Algoritm45
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.dgArr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgArr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "4.5 Найти номер последнего отрицательного элемента в массиве.";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(172, 61);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Решить";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(169, 113);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;
            // 
            // dgArr
            // 
            this.dgArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArr.Location = new System.Drawing.Point(12, 12);
            this.dgArr.Name = "dgArr";
            this.dgArr.Size = new System.Drawing.Size(150, 426);
            this.dgArr.TabIndex = 4;
            // 
            // Algoritm45
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgArr);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.label1);
            this.Name = "Algoritm45";
            this.Text = "Algoritm45";
            ((System.ComponentModel.ISupportInitialize)(this.dgArr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dgArr;
    }
}