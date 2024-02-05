using Amazon.Applacation.Service;
using Amazon.Infrastructure.Repositories;
using Amazon.Models.Models;
using System;
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
    public partial class AddAdmin : Form
    {
        private readonly IAdminService adminService = new AdminService(new AdminRepository(new Context.AmazonContext()));

        public AddAdmin(string Email)
        {
            InitializeComponent();
            textBox4.Text = Email;

            this.adminService = adminService;

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;

            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;

            Admin newAdmin = new Admin
            {
                UserName = name,
                Email = email,
                Password = password
            };

            adminService.AddAdmin(newAdmin);

            LoadData();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (adminview.SelectedRows.Count > 0)
            {
                //string name = adminview.CurrentRow.Cells["UserName"].Value.ToString();
                string email = adminview.CurrentRow.Cells["Email"].Value.ToString();
                string password = adminview.CurrentRow.Cells["Password"].Value.ToString();

                var admintodelete = adminService.GetAdminEmailAndPassword(email, password);

                if (admintodelete != null)
                {
                    adminService.DeleteAdmin(email, password);
                }


                //Admin selectedAdmin = new Admin
                //{
                //    UserName = name,
                //    Email = email,
                //    Password = password
                //};

                //adminService.DeleteAdmin(selectedAdmin);

                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var allAdmins = adminService.GetAllAdmin();
            adminview.DataSource = null;
            adminview.DataSource = allAdmins.ToList();
        }

        private void LoadData()
        {
            button3_Click(this, EventArgs.Empty);
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminPanle adminPanle = new adminPanle(textBox4.Text);
            adminPanle.Show();
            this.Hide();
        }
    }
}
