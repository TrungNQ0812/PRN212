namespace ManageCategoriesApp
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
            lbCategoryID = new Label();
            lbCategoryName = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            dvgCategories = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgCategories).BeginInit();
            SuspendLayout();
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbCategoryID.Location = new Point(144, 46);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(111, 25);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "Category ID";
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbCategoryName.Location = new Point(144, 112);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(143, 25);
            lbCategoryName.TabIndex = 1;
            lbCategoryName.Text = "Category Name";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtCategoryID.Location = new Point(330, 46);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(331, 29);
            txtCategoryID.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtCategoryName.Location = new Point(330, 112);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(331, 29);
            txtCategoryName.TabIndex = 3;
            // 
            // dvgCategories
            // 
            dvgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCategories.Location = new Point(12, 170);
            dvgCategories.Name = "dvgCategories";
            dvgCategories.ReadOnly = true;
            dvgCategories.Size = new Size(776, 150);
            dvgCategories.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnInsert.Location = new Point(144, 368);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(102, 36);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnUpdate.Location = new Point(351, 368);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 36);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDelete.Location = new Point(559, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 36);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dvgCategories);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(lbCategoryName);
            Controls.Add(lbCategoryID);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCategoryID;
        private Label lbCategoryName;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private DataGridView dvgCategories;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
