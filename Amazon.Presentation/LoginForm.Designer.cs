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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            Login = new Button();
            label1 = new Label();
            EmaillText = new TextBox();
            label2 = new Label();
            PasworddText = new TextBox();
            SignUP = new Button();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackgroundImageLayout = ImageLayout.Stretch;
            Login.FlatAppearance.BorderSize = 0;
            Login.Image = (Image)resources.GetObject("Login.Image");
            Login.Location = new Point(141, 228);
            Login.Margin = new Padding(7);
            Login.Name = "Login";
            Login.Size = new Size(107, 38);
            Login.TabIndex = 0;
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 46);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 38);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // EmaillText
            // 
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
            label2.ForeColor = Color.White;
            label2.Location = new Point(53, 137);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 38);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // PasworddText
            // 
            PasworddText.Location = new Point(291, 144);
            PasworddText.Margin = new Padding(7);
            PasworddText.Multiline = true;
            PasworddText.Name = "PasworddText";
            PasworddText.Size = new Size(224, 31);
            PasworddText.TabIndex = 4;
            // 
            // SignUP
            // 
            SignUP.BackgroundImageLayout = ImageLayout.Stretch;
            SignUP.FlatAppearance.BorderSize = 0;
            SignUP.Image = (Image)resources.GetObject("SignUP.Image");
            SignUP.Location = new Point(326, 228);
            SignUP.Margin = new Padding(7);
            SignUP.Name = "SignUP";
            SignUP.Size = new Size(109, 38);
            SignUP.TabIndex = 5;
            SignUP.UseVisualStyleBackColor = true;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(20F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(659, 379);
            Controls.Add(SignUP);
            Controls.Add(PasworddText);
            Controls.Add(label2);
            Controls.Add(EmaillText);
            Controls.Add(label1);
            Controls.Add(Login);
            Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "UserLogin";
            Text = "Form1";
            Load += UserLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private Label label1;
        private TextBox EmaillText;
        private Label label2;
        private TextBox PasworddText;
        private Button SignUP;
    }
}
