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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.Location = new Point(397, 319);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button2.Location = new Point(258, 319);
            button2.Name = "button2";
            button2.Size = new Size(100, 37);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(51, 43);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(51, 100);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(51, 153);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(51, 209);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(51, 264);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox1.Location = new Point(192, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 29);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox2.Location = new Point(192, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 29);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox3.Location = new Point(192, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(305, 29);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox4.Location = new Point(192, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(305, 29);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox5.Location = new Point(192, 264);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(305, 29);
            textBox5.TabIndex = 11;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 393);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}