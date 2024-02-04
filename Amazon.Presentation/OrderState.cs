using Amazon.Applacation.Service;
using Amazon.Context;
using Amazon.Infrastructure.Repositories;
using Amazon.Models.Models;
using Amazon.Presentation;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Amazon
{
    public partial class OrderState : Form
    {
        IUserService UserService = new UserService(new UserRepository(new AmazonContext()), new AdminRepository(new AmazonContext()));

        AmazonContext _Context = new AmazonContext();
        public OrderState()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrderState_Load(object sender, EventArgs e)
        {
            // Fetch all orders with details
            var orderSummary = _Context.Orders
                .Include(o => o.User)
                .Select(o => new
                {
                    OrderDate = o.OrderDate,
                    OrderState = o.StateOrder,
                    TotalPrice = o.OrderDetail.Sum(od => od.Price * od.Quantity),
                    TotalQuantity = o.OrderDetail.Sum(od => od.Quantity),
                    Customer = o.User.Name
                })
                .ToList();

            // Bind all orders to the DataGridView initially
            dataGridView1.DataSource = orderSummary;

            UserLogin loginForm = new UserLogin();
            loginForm.AdminLoggedIn += LoginForm_AdminoggedIn;

        }
        private void LoginForm_AdminoggedIn(object sender, string AdminEmail)
        {

            textBox1.Text = AdminEmail;
        }


        private void SearcByUserName_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearcByUserName.Text;

            // If the search term is empty, show all orders
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                var allOrders = _Context.Orders
                    .Include(o => o.User)
                    .Select(o => new
                    {
                        OrderDate = o.OrderDate,
                        OrderState = o.StateOrder,
                        TotalPrice = o.OrderDetail.Sum(od => od.Price * od.Quantity),
                        TotalQuantity = o.OrderDetail.Sum(od => od.Quantity),
                        Customer = o.User.Name
                    })
                    .ToList();

                dataGridView1.DataSource = allOrders;
            }
            else
            {
                // If there is a search term, filter orders based on the username
                var filteredOrders = _Context.Orders
                    .Include(o => o.User)
                    .Where(o => o.User.Name.Contains(searchTerm))
                    .Select(o => new
                    {
                        OrderDate = o.OrderDate,
                        OrderState = o.StateOrder,
                        TotalPrice = o.OrderDetail.Sum(od => od.Price * od.Quantity),
                        TotalQuantity = o.OrderDetail.Sum(od => od.Quantity),
                        Customer = o.User.Name
                    })
                    .ToList();

                dataGridView1.DataSource = filteredOrders;
            }
        }

       

        private void comboBoxOrderState_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string selectedOrderState = comboBoxOrderState.SelectedItem.ToString();
        }

        private void UpdateStateOfOrder_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Assuming the OrderState is in a specific column (adjust column index accordingly)
                string currentOrderState = selectedRow.Cells["OrderState"].Value.ToString();

                // Get the new OrderState from the comboBoxOrderState
                string newOrderState = comboBoxOrderState.SelectedItem.ToString();

              

               

                MessageBox.Show($"Order state updated from {currentOrderState} to {newOrderState}");
            }
            else
            {
                MessageBox.Show("Please select an order to update its state.");
            }
        }

    }
}
