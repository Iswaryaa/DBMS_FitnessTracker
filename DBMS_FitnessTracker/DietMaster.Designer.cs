﻿namespace DBMS_FitnessTracker
{
    partial class DietMaster
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
            this.ADDNEW = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NO = new System.Windows.Forms.RadioButton();
            this.YES = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.EXISTING = new System.Windows.Forms.GroupBox();
            this.ADDNEW.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADDNEW
            // 
            this.ADDNEW.Controls.Add(this.textBox7);
            this.ADDNEW.Controls.Add(this.textBox6);
            this.ADDNEW.Controls.Add(this.textBox5);
            this.ADDNEW.Controls.Add(this.textBox4);
            this.ADDNEW.Controls.Add(this.textBox3);
            this.ADDNEW.Controls.Add(this.listBox1);
            this.ADDNEW.Controls.Add(this.NO);
            this.ADDNEW.Controls.Add(this.YES);
            this.ADDNEW.Controls.Add(this.textBox2);
            this.ADDNEW.Controls.Add(this.textBox1);
            this.ADDNEW.Controls.Add(this.label4);
            this.ADDNEW.Controls.Add(this.label3);
            this.ADDNEW.Controls.Add(this.label2);
            this.ADDNEW.Controls.Add(this.label1);
            this.ADDNEW.Location = new System.Drawing.Point(619, 15);
            this.ADDNEW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ADDNEW.Name = "ADDNEW";
            this.ADDNEW.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ADDNEW.Size = new System.Drawing.Size(523, 514);
            this.ADDNEW.TabIndex = 1;
            this.ADDNEW.TabStop = false;
            this.ADDNEW.Text = "ADD NEW";
            this.ADDNEW.Enter += new System.EventHandler(this.ADDNEW_Enter);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(253, 298);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(253, 254);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(253, 207);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(253, 158);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(253, 107);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "1.Carbo",
            "",
            "",
            "2.Pro",
            "",
            "",
            "3.Vit",
            "",
            "",
            "4.Fat",
            "",
            "",
            "5.Others"});
            this.listBox1.Location = new System.Drawing.Point(179, 91);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 244);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Location = new System.Drawing.Point(179, 453);
            this.NO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(50, 21);
            this.NO.TabIndex = 7;
            this.NO.TabStop = true;
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = true;
            // 
            // YES
            // 
            this.YES.AutoSize = true;
            this.YES.Location = new System.Drawing.Point(179, 414);
            this.YES.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YES.Name = "YES";
            this.YES.Size = new System.Drawing.Size(56, 21);
            this.YES.TabIndex = 6;
            this.YES.TabStop = true;
            this.YES.Text = "YES";
            this.YES.UseVisualStyleBackColor = true;
            this.YES.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 356);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "JUNK";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CALORIES/SERVING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUTRIENTS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1217, 222);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // EXISTING
            // 
            this.EXISTING.Location = new System.Drawing.Point(16, 15);
            this.EXISTING.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EXISTING.Name = "EXISTING";
            this.EXISTING.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EXISTING.Size = new System.Drawing.Size(557, 514);
            this.EXISTING.TabIndex = 0;
            this.EXISTING.TabStop = false;
            this.EXISTING.Text = "EXISTING";
            this.EXISTING.Enter += new System.EventHandler(this.EXISTING_Enter);
            // 
            // DietMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1397, 554);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ADDNEW);
            this.Controls.Add(this.EXISTING);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DietMaster";
            this.Text = "DietMaster";
            this.Load += new System.EventHandler(this.DietMaster_Load);
            this.ADDNEW.ResumeLayout(false);
            this.ADDNEW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ADDNEW;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton NO;
        private System.Windows.Forms.RadioButton YES;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox EXISTING;
    }
}