namespace AutomobileWinApps
{
    partial class frmCarDetails
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacterer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            cboManufacturer = new ComboBox();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbCarID.Location = new Point(51, 43);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(64, 25);
            lbCarID.TabIndex = 2;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbCarName.Location = new Point(51, 100);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(96, 25);
            lbCarName.TabIndex = 3;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacterer
            // 
            lbManufacterer.AutoSize = true;
            lbManufacterer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbManufacterer.Location = new Point(51, 153);
            lbManufacterer.Name = "lbManufacterer";
            lbManufacterer.Size = new Size(127, 25);
            lbManufacterer.TabIndex = 4;
            lbManufacterer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbPrice.Location = new Point(51, 209);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(54, 25);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbReleaseYear.Location = new Point(51, 264);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(116, 25);
            lbReleaseYear.TabIndex = 6;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtCarID.Location = new Point(192, 47);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(305, 29);
            txtCarID.TabIndex = 7;
            // 
            // txtCarName
            // 
            txtCarName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtCarName.Location = new Point(192, 100);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(305, 29);
            txtCarName.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSave.Location = new Point(300, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 31);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnCancel.Location = new Point(406, 333);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 31);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboManufacturer
            // 
            cboManufacturer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Huyndai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(192, 158);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(305, 29);
            cboManufacturer.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPrice.Location = new Point(192, 214);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(305, 29);
            txtPrice.TabIndex = 12;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtReleaseYear.Location = new Point(192, 269);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(305, 29);
            txtReleaseYear.TabIndex = 13;
            txtReleaseYear.Text = "0";
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 393);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(cboManufacturer);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacterer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacterer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cboManufacturer;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
    }
}