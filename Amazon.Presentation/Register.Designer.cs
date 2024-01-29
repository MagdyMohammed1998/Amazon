namespace Amazon.Presentation
{
    partial class Registration
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
            RegisterBtn = new Button();
            label1 = new Label();
            NameText = new TextBox();
            EmailText = new TextBox();
            PasswordText = new TextBox();
            NameLabel = new Label();
            EmailLabel = new Label();
            PasswordLabel = new Label();
            NameValid = new Label();
            EmailValid = new Label();
            PasswordValid = new Label();
            SuspendLayout();
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.Transparent;
            RegisterBtn.BackgroundImageLayout = ImageLayout.Stretch;
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic);
            RegisterBtn.ForeColor = SystemColors.ButtonHighlight;
            RegisterBtn.Location = new Point(459, 325);
            RegisterBtn.Margin = new Padding(4, 3, 4, 3);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(129, 55);
            RegisterBtn.TabIndex = 0;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(459, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 1;
            label1.Text = "Registration";
            // 
            // NameText
            // 
            NameText.Location = new Point(435, 115);
            NameText.Margin = new Padding(4, 3, 4, 3);
            NameText.Name = "NameText";
            NameText.Size = new Size(198, 30);
            NameText.TabIndex = 2;
            NameText.TextChanged += NameText_TextChanged;
            // 
            // EmailText
            // 
            EmailText.Location = new Point(435, 174);
            EmailText.Margin = new Padding(4, 3, 4, 3);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(198, 30);
            EmailText.TabIndex = 3;
            EmailText.TextChanged += EmailText_TextChanged;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(435, 228);
            PasswordText.Margin = new Padding(4, 3, 4, 3);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(198, 30);
            PasswordText.TabIndex = 4;
            PasswordText.TextChanged += PasswordText_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.Transparent;
            NameLabel.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = SystemColors.ButtonHighlight;
            NameLabel.Location = new Point(218, 115);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(86, 32);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.BackColor = Color.Transparent;
            EmailLabel.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic);
            EmailLabel.ForeColor = SystemColors.ButtonHighlight;
            EmailLabel.Location = new Point(218, 174);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(86, 32);
            EmailLabel.TabIndex = 7;
            EmailLabel.Text = "Email:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic);
            PasswordLabel.ForeColor = SystemColors.ButtonHighlight;
            PasswordLabel.Location = new Point(184, 228);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(120, 32);
            PasswordLabel.TabIndex = 8;
            PasswordLabel.Text = "Password:";
            // 
            // NameValid
            // 
            NameValid.AutoSize = true;
            NameValid.BackColor = Color.Transparent;
            NameValid.Font = new Font("Goudy Old Style", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            NameValid.ForeColor = Color.Red;
            NameValid.Location = new Point(699, 115);
            NameValid.Name = "NameValid";
            NameValid.Size = new Size(151, 26);
            NameValid.TabIndex = 12;
            NameValid.Text = "Name Not Valid";
            // 
            // EmailValid
            // 
            EmailValid.AutoSize = true;
            EmailValid.BackColor = Color.Transparent;
            EmailValid.Font = new Font("Goudy Old Style", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            EmailValid.ForeColor = Color.Red;
            EmailValid.Location = new Point(699, 174);
            EmailValid.Name = "EmailValid";
            EmailValid.Size = new Size(151, 26);
            EmailValid.TabIndex = 13;
            EmailValid.Text = "Email Not Valid";
            // 
            // PasswordValid
            // 
            PasswordValid.AutoSize = true;
            PasswordValid.BackColor = Color.Transparent;
            PasswordValid.Font = new Font("Goudy Old Style", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PasswordValid.ForeColor = Color.Red;
            PasswordValid.Location = new Point(699, 228);
            PasswordValid.Name = "PasswordValid";
            PasswordValid.Size = new Size(177, 26);
            PasswordValid.TabIndex = 14;
            PasswordValid.Text = "Password Not Valid";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cosmetic_background_for_product_branding_and_packaging_presentation_geometry_form_circle_molding_on_podium_stage_with_shadow_of_leaf_background_design_eps10_vector1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 465);
            Controls.Add(PasswordValid);
            Controls.Add(EmailValid);
            Controls.Add(NameValid);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailLabel);
            Controls.Add(NameLabel);
            Controls.Add(PasswordText);
            Controls.Add(EmailText);
            Controls.Add(NameText);
            Controls.Add(label1);
            Controls.Add(RegisterBtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterBtn;
        private Label label1;
        private TextBox NameText;
        private TextBox EmailText;
        private TextBox PasswordText;
        private Label NameLabel;
        private Label EmailLabel;
        private Label PasswordLabel;
        private Label NameValid;
        private Label EmailValid;
        private Label PasswordValid;
    }
}