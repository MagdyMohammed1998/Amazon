namespace Amazon.Presentation
{
    partial class UserLogin
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
            label1 = new Label();
            EmaillText = new TextBox();
            label2 = new Label();
            PasworddText = new TextBox();
            Login = new Button();
            Register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(116, 53);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 26);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // EmaillText
            // 
            EmaillText.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            EmaillText.Location = new Point(291, 53);
            EmaillText.Margin = new Padding(7);
            EmaillText.Multiline = true;
            EmaillText.Name = "EmaillText";
            EmaillText.Size = new Size(224, 31);
            EmaillText.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 137);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 26);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // PasworddText
            // 
            PasworddText.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PasworddText.Location = new Point(291, 144);
            PasworddText.Margin = new Padding(7);
            PasworddText.Multiline = true;
            PasworddText.Name = "PasworddText";
            PasworddText.Size = new Size(224, 31);
            PasworddText.TabIndex = 4;
            // 
            // Login
            // 
            Login.BackColor = Color.Transparent;
            Login.BackgroundImageLayout = ImageLayout.Stretch;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic);
            Login.ForeColor = SystemColors.ButtonHighlight;
            Login.Location = new Point(179, 242);
            Login.Margin = new Padding(4, 3, 4, 3);
            Login.Name = "Login";
            Login.Size = new Size(129, 55);
            Login.TabIndex = 8;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click_1;
            // 
            // Register
            // 
            Register.BackColor = Color.Transparent;
            Register.BackgroundImageLayout = ImageLayout.Stretch;
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic);
            Register.ForeColor = SystemColors.ButtonHighlight;
            Register.Location = new Point(386, 242);
            Register.Margin = new Padding(4, 3, 4, 3);
            Register.Name = "Register";
            Register.Size = new Size(129, 55);
            Register.TabIndex = 9;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click_1;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(713, 386);
            Controls.Add(Register);
            Controls.Add(Login);
            Controls.Add(PasworddText);
            Controls.Add(label2);
            Controls.Add(EmaillText);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "UserLogin";
            Text = "Form1";
            Load += UserLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox EmaillText;
        private Label label2;
        private TextBox PasworddText;
        private Button Login;
        private Button Register;
    }
}
