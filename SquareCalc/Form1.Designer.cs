﻿
namespace SquareCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lowerLimit = new System.Windows.Forms.TextBox();
            this.txt_upperLimit = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_countBy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(57, 35);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(112, 34);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lower Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Upper Limit";
            // 
            // txt_lowerLimit
            // 
            this.txt_lowerLimit.Location = new System.Drawing.Point(373, 38);
            this.txt_lowerLimit.Name = "txt_lowerLimit";
            this.txt_lowerLimit.Size = new System.Drawing.Size(150, 31);
            this.txt_lowerLimit.TabIndex = 3;
            this.txt_lowerLimit.Text = "3";
            // 
            // txt_upperLimit
            // 
            this.txt_upperLimit.Location = new System.Drawing.Point(375, 98);
            this.txt_upperLimit.Name = "txt_upperLimit";
            this.txt_upperLimit.Size = new System.Drawing.Size(150, 31);
            this.txt_upperLimit.TabIndex = 4;
            this.txt_upperLimit.Text = "12";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(67, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 254);
            this.listBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count By:";
            // 
            // txt_countBy
            // 
            this.txt_countBy.Location = new System.Drawing.Point(570, 101);
            this.txt_countBy.Name = "txt_countBy";
            this.txt_countBy.Size = new System.Drawing.Size(150, 31);
            this.txt_countBy.TabIndex = 7;
            this.txt_countBy.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_countBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_upperLimit);
            this.Controls.Add(this.txt_lowerLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calculate);
            this.Name = "Form1";
            this.Text = "Square Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lowerLimit;
        private System.Windows.Forms.TextBox txt_upperLimit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_countBy;
    }
}

