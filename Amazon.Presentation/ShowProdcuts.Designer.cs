namespace Amazon
{
    partial class prodcuts
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
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ProducetName = new TextBox();
            TotalPrice = new TextBox();
            ProducetPrice = new TextBox();
            Quantites = new TextBox();
            AddToCard = new Button();
            SearchByProductName = new TextBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            UserName = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(195, 19);
            label1.TabIndex = 2;
            label1.Text = "Search By Name Of Product :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(20, 349);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 6;
            label5.Text = "Produect Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(146, 40);
            label6.TabIndex = 7;
            label6.Text = "Producet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(485, 349);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 8;
            label2.Text = "Total Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(220, 349);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 9;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(362, 349);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 10;
            label4.Text = "Quantity";
            // 
            // ProducetName
            // 
            ProducetName.Enabled = false;
            ProducetName.Location = new Point(20, 371);
            ProducetName.Name = "ProducetName";
            ProducetName.Size = new Size(126, 23);
            ProducetName.TabIndex = 11;
            ProducetName.TextChanged += ProducetName_TextChanged;
            // 
            // TotalPrice
            // 
            TotalPrice.Enabled = false;
            TotalPrice.Location = new Point(485, 371);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(91, 23);
            TotalPrice.TabIndex = 12;
            TotalPrice.TextChanged += TotalPrice_TextChanged;
            // 
            // ProducetPrice
            // 
            ProducetPrice.Enabled = false;
            ProducetPrice.Location = new Point(203, 371);
            ProducetPrice.Name = "ProducetPrice";
            ProducetPrice.Size = new Size(81, 23);
            ProducetPrice.TabIndex = 13;
            ProducetPrice.TextChanged += ProducetPrice_TextChanged;
            // 
            // Quantites
            // 
            Quantites.Location = new Point(351, 371);
            Quantites.Name = "Quantites";
            Quantites.Size = new Size(95, 23);
            Quantites.TabIndex = 14;
            Quantites.TextChanged += Quantites_TextChanged;
            Quantites.Leave += Quantites_Leave;
            // 
            // AddToCard
            // 
            AddToCard.BackColor = SystemColors.ActiveCaption;
            AddToCard.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            AddToCard.Location = new Point(307, 441);
            AddToCard.Name = "AddToCard";
            AddToCard.Size = new Size(139, 39);
            AddToCard.TabIndex = 17;
            AddToCard.Text = "Add to Cart";
            AddToCard.UseVisualStyleBackColor = false;
            AddToCard.Click += AddToCard_Click;
            // 
            // SearchByProductName
            // 
            SearchByProductName.Location = new Point(244, 66);
            SearchByProductName.Name = "SearchByProductName";
            SearchByProductName.Size = new Size(146, 23);
            SearchByProductName.TabIndex = 18;
            SearchByProductName.TextChanged += SearchByProductName_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(539, 201);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            dataGridView1.MouseCaptureChanged += dataGridView1_MouseCaptureChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 454);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 20;
            label7.Text = "User Name:";
            // 
            // UserName
            // 
            UserName.Enabled = false;
            UserName.Location = new Point(129, 451);
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Size = new Size(134, 23);
            UserName.TabIndex = 21;
            UserName.TextChanged += UserName_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(485, 441);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 22;
            button1.Text = "Go to Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // prodcuts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(622, 505);
            Controls.Add(button1);
            Controls.Add(UserName);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(SearchByProductName);
            Controls.Add(AddToCard);
            Controls.Add(Quantites);
            Controls.Add(ProducetPrice);
            Controls.Add(TotalPrice);
            Controls.Add(ProducetName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "prodcuts";
            Text = "prodcuts";
            Load += prodcuts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TotalPrice;
        private TextBox ProducetPrice;
        private TextBox Quantites;
        public TextBox ProducetName;
        private Button AddToCard;
        private TextBox SearchByProductName;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox UserName;
        private Button GoToCart;
        private Button button1;
    }
}