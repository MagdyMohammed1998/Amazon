using Amazon.Applacation.Service;
using Amazon.Context;
using Amazon.Infrastructure.Repositories;
using Amazon.Models.Models;
using E_Commerce.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazon
{
    public partial class order : Form
    {

        IUserService UserService = new UserService(new UserRepository(new AmazonContext()), new AdminRepository(new AmazonContext()));

        AmazonContext _Context = new AmazonContext();
        public order()
        {
            InitializeComponent();
        }

        private void order_Load(object sender, EventArgs e)
        {
            // Retrieve the user by email
            User currentUser = UserService.GetUserByEmail(UserName.Text);

            if (currentUser != null)
            {
                // Fetch orders for the current user with total price and total quantity
                var orderSummary = _Context.Orders
                    .Where(o => o.UserId == currentUser.Id)
                    .Select(o => new
                    {
                        OrderDate = o.OrderDate,
                        OrderState = o.StateOrder,
                        TotalPrice = o.OrderDetail.Sum(od => od.Price * od.Quantity),
                        TotalQuantity = o.OrderDetail.Sum(od => od.Quantity)
                    })
                    .ToList();

                // Bind the orders with total price and total quantity to the DataGridView
                dataGridView1.DataSource = orderSummary;
            }
            else
            {
                // Handle the case where the user is not found
                MessageBox.Show("User not found.");
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
