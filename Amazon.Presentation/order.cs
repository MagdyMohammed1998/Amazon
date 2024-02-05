using Amazon.Applacation.Service;
using Amazon.Context;
using Amazon.Infrastructure.Repositories;
using Amazon.Models.Models;
using Amazon.Presentation;
using E_Commerce.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
        IOrderService OrderService = new OrderService(new OrderRepository(new AmazonContext()));
        AmazonContext _Context = new AmazonContext();
        public order(string _UserName)
        {
            InitializeComponent();
            UserName.Text = _UserName;
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

        
            private void order_Load_1(object sender, EventArgs e)
            {
                User currentUser = UserService.GetUserByEmail(UserName.Text);

                if (currentUser != null)
                {
                    var orderSummary = _Context.Orders
                        .Include(o => o.OrderDetail)  // Ensure that OrderDetail is loaded
                        .Where(o => o.UserId == currentUser.Id)
                        .ToList()
                        .Select(o => new
                        {
                            OrderDate = o.OrderDate,
                            OrderState = o.StateOrder,
                            TotalPrice = o.OrderDetail?.Sum(od => od.Price * od.Quantity) ?? 0,
                            TotalQuantity = o.OrderDetail?.Sum(od => od.Quantity) ?? 0
                        })
                        .ToList();

                    dataGridView1.DataSource = orderSummary;
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }

        
        private void LoginForm_UserLoggedIn(object sender, string userEmail)
        {

            UserName.Text = userEmail;
        }
    }
}
