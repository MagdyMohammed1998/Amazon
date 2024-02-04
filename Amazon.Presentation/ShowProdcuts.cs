using Amazon.Applacation.Contract;
using Amazon.Applacation.Service;
using Amazon.Context;
using Amazon.Infrastructure.Repositories;
using Amazon.Models.Models;
using Amazon.Presentation;
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
    public partial class prodcuts : Form
    {
        IProductService productService = new ProductService(new ProductRepository(new AmazonContext()));
        ICartService CartService = new CartService(new CartRepository(new AmazonContext()));
        ICartDetailsService CartDetailsService = new CartDetailsService(new CartDetailsRepository(new AmazonContext()), new ProductRepository(new AmazonContext()));
        IUserService UserService = new UserService(new UserRepository(new AmazonContext()), new AdminRepository(new AmazonContext()));



        int selectedProductId;
        Product selectedProduct;



        public prodcuts()
        {
            InitializeComponent();
        }

        private void AddToCard_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = productService.GetById(selectedProductId);

            if (selectedProduct == null)
            {
                MessageBox.Show("Selected product not found. Please check your product information.");
                return;
            }

            CartDetails? cartDetails = CartDetailsService.GetCartDetailsBy(selectedProductId);

            int Quantity = cartDetails?.Quantity ?? 0;
            int AvailableQuantity = selectedProduct.Quantity - Quantity;

            if (decimal.TryParse(ProducetPrice.Text, out decimal productPrice) &&
                int.TryParse(Quantites.Text, out int quantity) && AvailableQuantity >= quantity)
            {
                User? existingUser = UserService.GetUserByEmail(UserName.Text);

                if (existingUser == null)
                {
                    MessageBox.Show("User not found. Please check your user information.");
                    return;
                }

                Cart? cart = CartService.Add(existingUser.Id);

                CartDetails newCartDetails = new CartDetails
                {
                    ProductId = selectedProduct.Id,
                    Quantity = quantity,
                    CartId = cart.Id
                };

                CartDetailsService.Add(newCartDetails);
                Console.WriteLine("Your Product added successfully to the Cart ");
            }
            else
            {
                if (AvailableQuantity == 0)
                    MessageBox.Show("I Don't Have in The Stock");
                else
                    MessageBox.Show($"Please select a product and ensure your quantity is valid OR ENTER a quantity less than {AvailableQuantity}");
            }
        }









        private void SearchByProductName_TextChanged(object sender, EventArgs e)
        {
            if (SearchByProductName.Text is not null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productService.SearchByName(SearchByProductName.Text).ToList();
            }

        }



        private void ProducetPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProducetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodcuts_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            UserLogin loginForm = new UserLogin();
            loginForm.UserLoggedIn += LoginForm_UserLoggedIn;

        }
        private void LoginForm_UserLoggedIn(object sender, string userEmail)
        {

            UserName.Text = userEmail;
        }
        private void LoadDataGrid()
        {
            IQueryable<Product> allProducts = productService.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allProducts.ToList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void TotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantites_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantites_Leave(object sender, EventArgs e)
        {
            if (Quantites.Text is not "")
                if (selectedProduct is not null && selectedProduct.Quantity >= int.Parse(Quantites.Text))
                    TotalPrice.Text = (selectedProduct.Price * int.Parse(Quantites.Text)).ToString();
                else
                {
                    MessageBox.Show("Idont have this Quantity in the Stock ");
                    TotalPrice.Text = "0";
                    Quantites.Text = "0";

                }
            else
            {
                TotalPrice.Text = "0";
                Quantites.Text = "0";

            }
        }



        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks >= 1)
            {
                int rowIndex = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                selectedProductId = (int)dataGridView1.Rows[rowIndex].Cells["Id"].Value;


                selectedProduct = productService.GetById(selectedProductId);

                ProducetName.Text = selectedProduct.Name;
                ProducetPrice.Text = selectedProduct.Price.ToString();
                Quantites.Text = selectedProduct.Quantity.ToString();
                int quantities = selectedProduct.Quantity;
                int productPrice = (int)selectedProduct.Price;


                TotalPrice.Text = (quantities * productPrice).ToString();


            }
        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
    }
}
