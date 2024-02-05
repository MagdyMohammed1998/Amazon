namespace Amazon
{
    partial class OrderState
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
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBoxOrderState = new ComboBox();
            label2 = new Label();
            SearcByUserName = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            UpdateStateOfOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(12, 35);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 12;
            label3.Text = "Orders";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 61);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(526, 378);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(610, 80);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 21;
            label1.Text = "Order State";
            label1.Click += label1_Click;
            // 
            // comboBoxOrderState
            // 
            comboBoxOrderState.FormattingEnabled = true;
            comboBoxOrderState.Location = new Point(592, 120);
            comboBoxOrderState.Name = "comboBoxOrderState";
            comboBoxOrderState.Size = new Size(107, 23);
            comboBoxOrderState.TabIndex = 22;
            comboBoxOrderState.SelectedIndexChanged += comboBoxOrderState_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(32, 16);
            label2.Name = "label2";
            label2.Size = new Size(238, 19);
            label2.TabIndex = 24;
            label2.Text = "Search By User Name For Orders :";
            // 
            // SearcByUserName
            // 
            SearcByUserName.Location = new Point(276, 12);
            SearcByUserName.Name = "SearcByUserName";
            SearcByUserName.Size = new Size(142, 23);
            SearcByUserName.TabIndex = 23;
            SearcByUserName.TextChanged += SearcByUserName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(44, 445);
            label4.Name = "label4";
            label4.Size = new Size(106, 19);
            label4.TabIndex = 26;
            label4.Text = "Admin Name :";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(179, 445);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 25;
            textBox1.Text = "mic@1";
            // 
            // UpdateStateOfOrder
            // 
            UpdateStateOfOrder.BackColor = SystemColors.ActiveCaption;
            UpdateStateOfOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            UpdateStateOfOrder.Location = new Point(544, 220);
            UpdateStateOfOrder.Name = "UpdateStateOfOrder";
            UpdateStateOfOrder.Size = new Size(155, 29);
            UpdateStateOfOrder.TabIndex = 30;
            UpdateStateOfOrder.Text = "Update State";
            UpdateStateOfOrder.UseVisualStyleBackColor = false;
            UpdateStateOfOrder.Click += UpdateStateOfOrder_Click;
            // 
            // OrderState
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 506);
            Controls.Add(UpdateStateOfOrder);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(SearcByUserName);
            Controls.Add(comboBoxOrderState);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "OrderState";
            Text = "OrderState";
            Load += OrderState_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBoxOrderState;
        private Label label2;
        private TextBox SearcByUserName;
        private Label label4;
        private TextBox textBox1;
        private Button UpdateStateOfOrder;
    }
}