﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazon.Presentation
{
    public partial class adminPanle : Form
    {
        public adminPanle( string adminEmail)
        {
            InitializeComponent();

            Email.Text = adminEmail;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CategoyForm categoyForm = new CategoyForm(Email.Text);
            categoyForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(Email.Text);
            productForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.Show();
            this.Hide();
        }
    }

}
