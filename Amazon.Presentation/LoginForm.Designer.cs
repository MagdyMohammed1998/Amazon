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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            SignUP = new Button();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackgroundImageLayout = ImageLayout.Stretch;
            Login.FlatAppearance.BorderSize = 0;
            Login.Image = (Image)resources.GetObject("Login.Image");
            Login.Location = new Point(140, 216);
            Login.Margin = new Padding(7);
            Login.Name = "Login";
            Login.Size = new Size(107, 38);
            Login.TabIndex = 0;
            Login.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 28);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 31);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 25);
            textBox1.Margin = new Padding(7);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 31);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 144);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 144);
            textBox2.Margin = new Padding(7);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 31);
            textBox2.TabIndex = 4;
            // 
            // SignUP
            // 
            SignUP.BackgroundImageLayout = ImageLayout.Stretch;
            SignUP.FlatAppearance.BorderSize = 0;
            SignUP.Image = (Image)resources.GetObject("SignUP.Image");
            SignUP.Location = new Point(280, 216);
            SignUP.Margin = new Padding(7);
            SignUP.Name = "SignUP";
            SignUP.Size = new Size(109, 38);
            SignUP.TabIndex = 5;
            SignUP.UseVisualStyleBackColor = true;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(490, 318);
            Controls.Add(SignUP);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Login);
            Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "UserLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button SignUP;
    }
}
