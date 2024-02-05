namespace Amazon
{
    partial class order
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
            UserName = new TextBox();
            label1 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(23, 55);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 10;
            label3.Text = "Your Order";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(526, 280);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UserName
            // 
            UserName.Enabled = false;
            UserName.Location = new Point(128, 12);
            UserName.Name = "UserName";
            UserName.Size = new Size(142, 23);
            UserName.TabIndex = 21;
            UserName.Text = "mi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(23, 16);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 22;
            label1.Text = "User Name :";
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(575, 422);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 23;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 494);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(UserName);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "order";
            Text = "order";
            Load += order_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView dataGridView1;
        private TextBox UserName;
        private Label label1;
        private Label label5;
        private TextBox ordertotalprice;
        private Button button7;
    }
}