namespace WindowsFormsApp1
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
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddIdTextBox = new System.Windows.Forms.TextBox();
            this.AddSex = new System.Windows.Forms.ListBox();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.AddId = new System.Windows.Forms.Label();
            this.AddNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditNameTextbox = new System.Windows.Forms.TextBox();
            this.EditSex = new System.Windows.Forms.ListBox();
            this.EditIdTextbox = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(466, 97);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "新增";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 260);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // AddIdTextBox
            // 
            this.AddIdTextBox.Location = new System.Drawing.Point(176, 97);
            this.AddIdTextBox.Name = "AddIdTextBox";
            this.AddIdTextBox.Size = new System.Drawing.Size(91, 22);
            this.AddIdTextBox.TabIndex = 3;
            // 
            // AddSex
            // 
            this.AddSex.AllowDrop = true;
            this.AddSex.FormattingEnabled = true;
            this.AddSex.ItemHeight = 12;
            this.AddSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.AddSex.Location = new System.Drawing.Point(386, 97);
            this.AddSex.Name = "AddSex";
            this.AddSex.Size = new System.Drawing.Size(46, 28);
            this.AddSex.TabIndex = 4;
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Location = new System.Drawing.Point(273, 97);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(91, 22);
            this.AddNameTextBox.TabIndex = 5;
            // 
            // AddId
            // 
            this.AddId.AutoSize = true;
            this.AddId.Location = new System.Drawing.Point(176, 79);
            this.AddId.Name = "AddId";
            this.AddId.Size = new System.Drawing.Size(53, 12);
            this.AddId.TabIndex = 6;
            this.AddId.Text = "員工編號";
            // 
            // AddNameLabel
            // 
            this.AddNameLabel.AutoSize = true;
            this.AddNameLabel.Location = new System.Drawing.Point(273, 79);
            this.AddNameLabel.Name = "AddNameLabel";
            this.AddNameLabel.Size = new System.Drawing.Size(53, 12);
            this.AddNameLabel.TabIndex = 7;
            this.AddNameLabel.Text = "員工姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "員工姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "員工編號";
            // 
            // EditNameTextbox
            // 
            this.EditNameTextbox.Location = new System.Drawing.Point(273, 188);
            this.EditNameTextbox.Name = "EditNameTextbox";
            this.EditNameTextbox.Size = new System.Drawing.Size(91, 22);
            this.EditNameTextbox.TabIndex = 11;
            // 
            // EditSex
            // 
            this.EditSex.AllowDrop = true;
            this.EditSex.FormattingEnabled = true;
            this.EditSex.ItemHeight = 12;
            this.EditSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.EditSex.Location = new System.Drawing.Point(386, 188);
            this.EditSex.Name = "EditSex";
            this.EditSex.Size = new System.Drawing.Size(46, 28);
            this.EditSex.TabIndex = 10;
            // 
            // EditIdTextbox
            // 
            this.EditIdTextbox.Location = new System.Drawing.Point(176, 188);
            this.EditIdTextbox.Name = "EditIdTextbox";
            this.EditIdTextbox.ReadOnly = true;
            this.EditIdTextbox.Size = new System.Drawing.Size(91, 22);
            this.EditIdTextbox.TabIndex = 9;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(466, 188);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 8;
            this.Edit.Text = "編輯";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(547, 188);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 14;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "性別";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "性別";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 547);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditNameTextbox);
            this.Controls.Add(this.EditSex);
            this.Controls.Add(this.EditIdTextbox);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddNameLabel);
            this.Controls.Add(this.AddId);
            this.Controls.Add(this.AddNameTextBox);
            this.Controls.Add(this.AddSex);
            this.Controls.Add(this.AddIdTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox AddIdTextBox;
        private System.Windows.Forms.ListBox AddSex;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.Label AddId;
        private System.Windows.Forms.Label AddNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditNameTextbox;
        private System.Windows.Forms.ListBox EditSex;
        private System.Windows.Forms.TextBox EditIdTextbox;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

