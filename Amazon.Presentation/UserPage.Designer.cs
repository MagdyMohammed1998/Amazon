namespace Amazon.Presentation
{
    partial class UserPage
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(373, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(415, 233);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(423, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 3;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(611, 31);
            button1.Name = "button1";
            button1.Size = new Size(82, 25);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(18, 264);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 5;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(139, 264);
            label3.Name = "label3";
            label3.Size = new Size(111, 24);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.OrangeRed;
            button2.Location = new Point(181, 385);
            button2.Name = "button2";
            button2.Size = new Size(82, 25);
            button2.TabIndex = 7;
            button2.Text = "Add Cart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(0, 192, 0);
            button3.Location = new Point(373, 385);
            button3.Name = "button3";
            button3.Size = new Size(106, 25);
            button3.TabIndex = 8;
            button3.Text = "Go To Cart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(164, 264);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 314);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(87, 23);
            textBox3.TabIndex = 13;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.OrangeRed;
            button4.Location = new Point(241, 31);
            button4.Name = "button4";
            button4.Size = new Size(82, 26);
            button4.TabIndex = 14;
            button4.Text = "Log Out";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            ForeColor = Color.Black;
            Name = "UserPage";
            Text = "UserPage";
            Load += UserPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button4;
    }
}