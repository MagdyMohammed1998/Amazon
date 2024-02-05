namespace Amazon.Presentation
{
    partial class AddAdmin
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
            adminview = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)adminview).BeginInit();
            SuspendLayout();
            // 
            // adminview
            // 
            adminview.BackgroundColor = SystemColors.GradientInactiveCaption;
            adminview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminview.Location = new Point(387, 33);
            adminview.Name = "adminview";
            adminview.Size = new Size(390, 214);
            adminview.TabIndex = 0;
            adminview.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 1;
            label1.Text = "Admins";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(126, 23);
            textBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 168);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 5;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 122);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 6;
            label3.Text = "E-mail :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 65);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 7;
            label4.Text = "Name :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(18, 273);
            button1.Name = "button1";
            button1.Size = new Size(89, 32);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(141, 273);
            button2.Name = "button2";
            button2.Size = new Size(89, 32);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(273, 273);
            button3.Name = "button3";
            button3.Size = new Size(89, 32);
            button3.TabIndex = 10;
            button3.Text = "GetAll";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(629, 355);
            button4.Name = "button4";
            button4.Size = new Size(89, 32);
            button4.TabIndex = 11;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(98, 2);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 26);
            textBox4.TabIndex = 36;
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 439);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(adminview);
            Name = "AddAdmin";
            Text = "AddAdmin";
            Load += AddAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)adminview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView adminview;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
    }
}