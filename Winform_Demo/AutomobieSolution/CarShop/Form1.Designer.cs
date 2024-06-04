namespace CarShop
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.CarID = new System.Windows.Forms.Label();
            this.CarIDTextBox = new System.Windows.Forms.TextBox();
            this.CarName = new System.Windows.Forms.Label();
            this.CarNameTextBox = new System.Windows.Forms.TextBox();
            this.Manufacturer = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 504);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(669, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(329, 314);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarID
            // 
            this.CarID.AutoSize = true;
            this.CarID.Location = new System.Drawing.Point(54, 55);
            this.CarID.Name = "CarID";
            this.CarID.Size = new System.Drawing.Size(37, 13);
            this.CarID.TabIndex = 2;
            this.CarID.Text = "Car ID";
            this.CarID.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarIDTextBox
            // 
            this.CarIDTextBox.Location = new System.Drawing.Point(124, 52);
            this.CarIDTextBox.Name = "CarIDTextBox";
            this.CarIDTextBox.Size = new System.Drawing.Size(212, 20);
            this.CarIDTextBox.TabIndex = 3;
            // 
            // CarName
            // 
            this.CarName.AutoSize = true;
            this.CarName.Location = new System.Drawing.Point(54, 97);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(54, 13);
            this.CarName.TabIndex = 4;
            this.CarName.Text = "Car Name";
            this.CarName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CarNameTextBox
            // 
            this.CarNameTextBox.Location = new System.Drawing.Point(124, 94);
            this.CarNameTextBox.Name = "CarNameTextBox";
            this.CarNameTextBox.Size = new System.Drawing.Size(212, 20);
            this.CarNameTextBox.TabIndex = 5;
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.Location = new System.Drawing.Point(54, 142);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(70, 13);
            this.Manufacturer.TabIndex = 6;
            this.Manufacturer.Text = "Manufacturer";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 7;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(54, 187);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 8;
            this.Price.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(124, 184);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(212, 20);
            this.PriceTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 359);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.CarNameTextBox);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.CarIDTextBox);
            this.Controls.Add(this.CarID);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label CarID;
        private System.Windows.Forms.TextBox CarIDTextBox;
        private System.Windows.Forms.Label CarName;
        private System.Windows.Forms.TextBox CarNameTextBox;
        private System.Windows.Forms.Label Manufacturer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}

