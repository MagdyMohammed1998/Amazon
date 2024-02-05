namespace Amazon
{
    partial class CartFrm
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
            UserName = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            cartProducetName = new TextBox();
            ProducetName1 = new Label();
            cartprice = new TextBox();
            cartprice1 = new Label();
            cartDelete = new Button();
            cartEdiet = new Button();
            cartQuantatiy1 = new Label();
            cartQuantatiy = new DomainUpDown();
            OrderNow = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 0;
            label1.Text = "Hello";
            // 
            // UserName
            // 
            UserName.Enabled = false;
            UserName.Location = new Point(62, 12);
            UserName.Name = "UserName";
            UserName.Size = new Size(100, 23);
            UserName.TabIndex = 1;
            UserName.Text = "mi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(535, 14);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 2;
            label2.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(595, 14);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(494, 244);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 6;
            label3.Text = "Your Cart Items";
            // 
            // cartProducetName
            // 
            cartProducetName.Enabled = false;
            cartProducetName.Location = new Point(656, 137);
            cartProducetName.Name = "cartProducetName";
            cartProducetName.Size = new Size(87, 23);
            cartProducetName.TabIndex = 20;
            cartProducetName.TextChanged += textBox1_TextChanged;
            // 
            // ProducetName1
            // 
            ProducetName1.AutoSize = true;
            ProducetName1.BackColor = SystemColors.Window;
            ProducetName1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            ProducetName1.ForeColor = Color.Black;
            ProducetName1.Location = new Point(521, 137);
            ProducetName1.Name = "ProducetName1";
            ProducetName1.Size = new Size(120, 19);
            ProducetName1.TabIndex = 19;
            ProducetName1.Text = "Produect Name:";
            ProducetName1.Click += label6_Click;
            // 
            // cartprice
            // 
            cartprice.Enabled = false;
            cartprice.Location = new Point(656, 189);
            cartprice.Name = "cartprice";
            cartprice.Size = new Size(87, 23);
            cartprice.TabIndex = 22;
            // 
            // cartprice1
            // 
            cartprice1.AutoSize = true;
            cartprice1.BackColor = SystemColors.Window;
            cartprice1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            cartprice1.ForeColor = SystemColors.ControlText;
            cartprice1.Location = new Point(521, 193);
            cartprice1.Name = "cartprice1";
            cartprice1.Size = new Size(51, 19);
            cartprice1.TabIndex = 21;
            cartprice1.Text = "Price :";
            cartprice1.Click += label7_Click;
            // 
            // cartDelete
            // 
            cartDelete.BackColor = SystemColors.ActiveCaption;
            cartDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cartDelete.Location = new Point(535, 309);
            cartDelete.Name = "cartDelete";
            cartDelete.Size = new Size(92, 29);
            cartDelete.TabIndex = 24;
            cartDelete.Text = "Delete";
            cartDelete.UseVisualStyleBackColor = false;
            cartDelete.Click += cartDelete_Click;
            // 
            // cartEdiet
            // 
            cartEdiet.BackColor = SystemColors.ActiveCaption;
            cartEdiet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cartEdiet.Location = new Point(661, 310);
            cartEdiet.Name = "cartEdiet";
            cartEdiet.Size = new Size(89, 28);
            cartEdiet.TabIndex = 26;
            cartEdiet.Text = "Edit";
            cartEdiet.UseVisualStyleBackColor = false;
            cartEdiet.Click += cartEdiet_Click;
            // 
            // cartQuantatiy1
            // 
            cartQuantatiy1.AutoSize = true;
            cartQuantatiy1.BackColor = SystemColors.Window;
            cartQuantatiy1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            cartQuantatiy1.ForeColor = SystemColors.ControlText;
            cartQuantatiy1.Location = new Point(521, 242);
            cartQuantatiy1.Name = "cartQuantatiy1";
            cartQuantatiy1.Size = new Size(85, 19);
            cartQuantatiy1.TabIndex = 27;
            cartQuantatiy1.Text = "Quantatiy :";
            // 
            // cartQuantatiy
            // 
            cartQuantatiy.BackColor = SystemColors.InactiveCaption;
            cartQuantatiy.Location = new Point(656, 238);
            cartQuantatiy.Name = "cartQuantatiy";
            cartQuantatiy.Size = new Size(87, 23);
            cartQuantatiy.TabIndex = 28;
            cartQuantatiy.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // OrderNow
            // 
            OrderNow.BackColor = SystemColors.ActiveCaption;
            OrderNow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            OrderNow.Location = new Point(175, 374);
            OrderNow.Name = "OrderNow";
            OrderNow.Size = new Size(155, 29);
            OrderNow.TabIndex = 29;
            OrderNow.Text = "Order Now";
            OrderNow.UseVisualStyleBackColor = false;
            OrderNow.Click += OrderNow_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(351, 465);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 30;
            button1.Text = "Go To Orders";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CartFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 506);
            Controls.Add(button1);
            Controls.Add(OrderNow);
            Controls.Add(cartQuantatiy);
            Controls.Add(cartQuantatiy1);
            Controls.Add(cartEdiet);
            Controls.Add(cartDelete);
            Controls.Add(cartprice);
            Controls.Add(cartprice1);
            Controls.Add(cartProducetName);
            Controls.Add(ProducetName1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(UserName);
            Controls.Add(label1);
            Name = "CartFrm";
            Text = "Cart";
            Load += CartFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UserName;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox CartTotalQuantites;
        private Label CartTotalQuantites1;
        private TextBox CartTotalPrice;
        private Label CartTotalPrice1;
        public TextBox cartProducetName;
        private Label ProducetName1;
        private TextBox cartprice;
        private Label cartprice1;
        private Button cartDelete;
        private Button cartEdiet;
        private Label cartQuantatiy1;
        private Button OrderNow;
        public DomainUpDown cartQuantatiy;
        private Button button1;
    }
}