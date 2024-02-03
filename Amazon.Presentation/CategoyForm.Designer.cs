namespace Amazon.Presentation
{
    partial class CategoyForm
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
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            TextBox1 = new TextBox();
            Search = new Button();
            texSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(347, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(218, 199);
            dataGridView1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(212, 9);
            label3.Name = "label3";
            label3.Size = new Size(195, 24);
            label3.TabIndex = 18;
            label3.Text = "Category Mangment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 171);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 26;
            label1.Text = "Name";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(4, 372);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(137, 372);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 28;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(263, 372);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 29;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(415, 372);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 30;
            button4.Text = "GetAll";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(499, 426);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 31;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(93, 171);
            TextBox1.Margin = new Padding(4, 3, 4, 3);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(152, 23);
            TextBox1.TabIndex = 32;
            // 
            // Search
            // 
            Search.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(4, 84);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 33;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // texSearch
            // 
            texSearch.Location = new Point(93, 86);
            texSearch.Margin = new Padding(4, 3, 4, 3);
            texSearch.Name = "texSearch";
            texSearch.Size = new Size(152, 23);
            texSearch.TabIndex = 34;
            // 
            // CategoyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(610, 461);
            Controls.Add(texSearch);
            Controls.Add(Search);
            Controls.Add(TextBox1);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "CategoyForm";
            Text = "CategoyForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label3;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button7;
        private TextBox TextBox1;
        private Button Search;
        private TextBox texSearch;
    }
}