using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.Applacation.Contract;
using Amazon.Applacation.Service;
using Amazon.Context;
using Amazon.Infrastructure.Repositories;
using Amazon.Models.Models;
using Amazon.Presentation;
using E_Commerce.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Amazon
{
    public partial class CartFrm : Form
    {
        IProductService productService = new ProductService(new ProductRepository(new AmazonContext()));
        ICartService CartService = new CartService(new CartRepository(new AmazonContext()));
        ICartDetailsService CartDetailsService = new CartDetailsService(new CartDetailsRepository(new AmazonContext()), new ProductRepository(new AmazonContext()));
        IUserService UserService = new UserService(new UserRepository(new AmazonContext()), new AdminRepository(new AmazonContext()));
        IOrderDetailsService orderDetailsService = new OrderDetailsService(new OrderDetailsRepository(new AmazonContext()), new CartDetailsRepository(new AmazonContext()), new ProductRepository(new AmazonContext()));
        IOrderService orderService = new OrderService(new OrderRepository(new AmazonContext()));
        AmazonContext _Context = new AmazonContext();


        public CartFrm(string _UserName)
        {
            InitializeComponent();
            UserName.Text = _UserName;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(cartQuantatiy.Text, out _)   && cartQuantatiy.Text != "")
            {
                
            
                    MessageBox.Show("Please Enter a Valid Quantity.");
                    cartQuantatiy.Text = "";
                
            }
           



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        UserLogin loginForm = new UserLogin();
        private void CartFrm_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            UserLogin loginForm = new UserLogin();

        }

        private void LoginForm_UserLoggedIn(object sender, string userEmail)
        {

            UserName.Text = userEmail;
        }
        private void LoadDataGrid()
        {
            Cart cart = CartService.GetCartByUserEmail(UserName.Text);

            dataGridView1.DataSource = null;
            var cartDetailsQuery = _Context.CartDetails
           .Where(CD => CD.CartId == cart.Id)
              .Join(
                 _Context.Products,
                 c => c.ProductId,
                 p => p.Id,
                 (CartDetails, Product) => new
                 {
                     ProductName = Product.Name,
                     Quantity = CartDetails.Quantity,
                     Price = Product.Price,
                     TotalPrice = CartDetails.Quantity * Product.Price
                 });

            var cartDetailsList = cartDetailsQuery.ToList();


            dataGridView1.DataSource = cartDetailsList;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks >= 1)
            {

                int rowIndex = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (rowIndex >= 0)
                {

                    cartProducetName.Text = dataGridView1.Rows[rowIndex].Cells["ProductName"].Value?.ToString();
                    cartprice.Text = dataGridView1.Rows[rowIndex].Cells["Price"].Value?.ToString();
                    cartQuantatiy.Text = dataGridView1.Rows[rowIndex].Cells["Quantity"].Value?.ToString();
                }
            }

        }

        private void cartEdiet_Click(object sender, EventArgs e)
        {
            if (cartProducetName.Text != "")
            {
                int cartQuantatiy1 = int.Parse(cartQuantatiy.Text);
                CartDetailsService.Update(cartProducetName.Text, int.Parse(cartQuantatiy.Text));
                if (cartQuantatiy1 == int.Parse(cartQuantatiy.Text))
                {
                    MessageBox.Show($"Your Product is Edit By New Quantatiy{cartQuantatiy.Text}");
                    LoadDataGrid();
                    ClearData();

                }
                else
                {
                    MessageBox.Show($"Please Enter Right Quantatiy i dont have this {cartQuantatiy.Text} in the stock");
                    cartQuantatiy.Text = "";
                    cartQuantatiy.Focus();

                }

            }
            else
            {
                MessageBox.Show("Please Select Product to edit");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cartDelete_Click(object sender, EventArgs e)
        {
            if (cartProducetName.Text != "")
            {
                CartDetailsService.Delete(cartProducetName.Text);

                MessageBox.Show($"Your Product is deleted");
                ClearData();
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Please Select Product to delete");
            }
        }
        private void ClearData()
        {
            cartprice.Text = "";
            cartProducetName.Text = "";
            cartQuantatiy.Text = "";
        }

        private void OrderNow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<CartDetails> selectedCartDetails = new List<CartDetails>();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string productName = row.Cells["ProductName"].Value?.ToString();
                    int quantity = int.Parse(row.Cells["Quantity"].Value?.ToString() ?? "0");

                    if (!string.IsNullOrEmpty(productName) && quantity > 0)
                    {
                        selectedCartDetails.Add(new CartDetails
                        {

                            ProductId = productService.GetProductByName(productName).Id,
                            Quantity = quantity
                        });
                    }
                }

                if (selectedCartDetails.Any())
                {
                    User existingUser = UserService.GetUserByEmail(UserName.Text);

                    Order order = new Order
                    {
                        OrderDate = DateTime.Now,
                        UserId = existingUser.Id,
                        StateOrder = StateOrder.Processing
                    };

                    orderService.Add(order);
                    foreach (CartDetails cartDetails in selectedCartDetails)
                    {
                        OrderDetails orderDetails = orderDetailsService.AddFromCartDetails(cartDetails, order);
                        CartDetailsService.Delete(productService.GetById(cartDetails.ProductId).Name);

                    }

                    MessageBox.Show("Order placed successfully!");
                    LoadDataGrid();
                }
                else
                {
                    MessageBox.Show("Please select products to order.");
                }
            }
            else
            {
                MessageBox.Show("Please select products to order.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order order = new order(UserName.Text);
            order.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage(UserName.Text);
            userPage.Show();
            this.Hide();

        }
    }
}     
