namespace Food
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
            this.Platform = new System.Windows.Forms.ListBox();
            this.FoodPrice = new System.Windows.Forms.NumericUpDown();
            this.Distance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FoodName = new System.Windows.Forms.TextBox();
            this.CalBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FoodPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).BeginInit();
            this.SuspendLayout();
            // 
            // Platform
            // 
            this.Platform.FormattingEnabled = true;
            this.Platform.ItemHeight = 12;
            this.Platform.Items.AddRange(new object[] {
            "UberEat",
            "FoodPanda",
            "HonestBee"});
            this.Platform.Location = new System.Drawing.Point(418, 98);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(93, 40);
            this.Platform.TabIndex = 0;
            // 
            // FoodPrice
            // 
            this.FoodPrice.Location = new System.Drawing.Point(191, 98);
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.Size = new System.Drawing.Size(87, 22);
            this.FoodPrice.TabIndex = 1;
            this.FoodPrice.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(299, 98);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(87, 22);
            this.Distance.TabIndex = 2;
            this.Distance.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "物品名稱";
            // 
            // FoodName
            // 
            this.FoodName.Location = new System.Drawing.Point(76, 98);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(100, 22);
            this.FoodName.TabIndex = 4;
            this.FoodName.Text = "排骨便當";
            // 
            // CalBtn
            // 
            this.CalBtn.Location = new System.Drawing.Point(544, 97);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(75, 23);
            this.CalBtn.TabIndex = 5;
            this.CalBtn.Text = "計算";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "費用";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "單價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "距離(KM)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "運送平台";
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(418, 172);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 22);
            this.Sum.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.CalBtn);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.FoodPrice);
            this.Controls.Add(this.Platform);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Platform;
        private System.Windows.Forms.NumericUpDown FoodPrice;
        private System.Windows.Forms.NumericUpDown Distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FoodName;
        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Sum;
    }
}

