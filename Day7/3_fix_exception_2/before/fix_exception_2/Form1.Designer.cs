﻿namespace fix_exception_2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.AddedMajor = new System.Windows.Forms.ListBox();
            this.AddedName = new System.Windows.Forms.TextBox();
            this.AddedEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(205, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 233);
            this.dataGridView1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "主修";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "信箱";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(522, 81);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "新增";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // AddedMajor
            // 
            this.AddedMajor.FormattingEnabled = true;
            this.AddedMajor.ItemHeight = 12;
            this.AddedMajor.Items.AddRange(new object[] {
            "資訊工程",
            "機械",
            "經濟"});
            this.AddedMajor.Location = new System.Drawing.Point(432, 81);
            this.AddedMajor.Name = "AddedMajor";
            this.AddedMajor.Size = new System.Drawing.Size(82, 40);
            this.AddedMajor.TabIndex = 10;
            // 
            // AddedName
            // 
            this.AddedName.Location = new System.Drawing.Point(319, 81);
            this.AddedName.Name = "AddedName";
            this.AddedName.Size = new System.Drawing.Size(100, 22);
            this.AddedName.TabIndex = 9;
            this.AddedName.Text = "Ken";
            // 
            // AddedEmail
            // 
            this.AddedEmail.Location = new System.Drawing.Point(205, 81);
            this.AddedEmail.Name = "AddedEmail";
            this.AddedEmail.Size = new System.Drawing.Size(100, 22);
            this.AddedEmail.TabIndex = 8;
            this.AddedEmail.Text = "xyz@abc.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AddedMajor);
            this.Controls.Add(this.AddedName);
            this.Controls.Add(this.AddedEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox AddedMajor;
        private System.Windows.Forms.TextBox AddedName;
        private System.Windows.Forms.TextBox AddedEmail;
    }
}

