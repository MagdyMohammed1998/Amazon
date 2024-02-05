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
        IOrderService orderService = new OrderService(new OrderRepository(new AmazonContext()));

        AmazonContext _Context = new AmazonContext();
        int orderID;
        public OrderState(string email)
        {
            InitializeComponent();
            textBox1.Text = email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrderState_Load(object sender, EventArgs e)
        {

            LoadDatagrid();


        }
        private void LoginForm_AdminoggedIn(object sender, string AdminEmail)
        {

            textBox1.Text = AdminEmail;
        }

        private void LoadDatagrid()
        {
            comboBoxOrderState.DataSource = Enum.GetValues(typeof(StateOrder));
            comboBoxOrderState.DropDownStyle = ComboBoxStyle.DropDownList;
            var orderSummary = _Context.Orders
                .Include(o => o.User)
                .Select(o => new
                {
                    Customer = o.User.Name,
                    OrderDate = o.OrderDate,
                    OrderState = o.StateOrder,
                    TotalPrice = o.OrderDetail.Sum(od => od.Price * od.Quantity),
                    TotalQuantity = o.OrderDetail.Sum(od => od.Quantity),
                    id = o.Id

                })
                .ToList();

            // Bind all orders to the DataGridView initially
            dataGridView1.DataSource = orderSummary;
        }
        private void SearcByUserName_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearcByUserName.Text;

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
                        Customer = o.User.Name,
                        id = o.Id
                    })
                    .ToList();

                dataGridView1.DataSource = allOrders;
            }
            else
            {

                var filteredOrders = _Context.Orders
                    .Include(o => o.User)
                    .Where(o => o.User.Name.Contains(searchTerm))
                    .Select(o => new
                    {
                        OrderDate = o.OrderDate,
                        OrderState = o.StateOrder,
                        TotalPrice = o.OrderDetail.Sum(od => od.Price * od.Quantity),
                        TotalQuantity = o.OrderDetail.Sum(od => od.Quantity),
                        Customer = o.User.Name,
                        id = o.Id
                    })
                    .ToList();

                dataGridView1.DataSource = filteredOrders;
            }
        }


        private void comboBoxOrderState_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UpdateStateOfOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string currentOrderState = selectedRow.Cells["OrderState"].Value.ToString();


                if (comboBoxOrderState.SelectedItem is StateOrder newOrderState)
                {

                    orderService.UpdateState(orderID, newOrderState, textBox1.Text);

                    MessageBox.Show($"Order state updated from {currentOrderState} to {newOrderState}");
                    LoadDatagrid();

                }
            }
            else
            {
                MessageBox.Show("Please select an order to update its state.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Clicks > 0)
                {
                    int rowIndex = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                    orderID = (int)dataGridView1.Rows[rowIndex].Cells["id"].Value;


                    comboBoxOrderState.SelectedItem = orderService.GetOrderById(orderID).StateOrder;



                }
            }
            catch (Exception)
            {


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminPanle adminPanle = new adminPanle(textBox1.Text);
            adminPanle.Show();
            this.Hide();
        }
    }
}
