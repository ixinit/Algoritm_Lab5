namespace Algoritm4._4
{
    partial class Algoritm44
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgArr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "4.4 Найти количество положительных и отрицательных элементов массива.";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(168, 60);
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
            this.lblResult.Location = new System.Drawing.Point(169, 148);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "положительных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "отрицательных";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(275, 148);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(0, 13);
            this.lblResult2.TabIndex = 7;
            // 
            // Algoritm44
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgArr);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.label1);
            this.Name = "Algoritm44";
            this.Text = "Algoritm44";
            ((System.ComponentModel.ISupportInitialize)(this.dgArr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dgArr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult2;
    }
}