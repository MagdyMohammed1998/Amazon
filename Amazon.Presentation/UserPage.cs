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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Amazon.Presentation
{
    public partial class UserPage : Form
    {
        private readonly IProductService productService;
        private readonly IUserService UserService;
        private readonly ICartService cartService;
        private readonly ICartDetailsService CartDetailsService;
        public UserPage(string email)
        {
            InitializeComponent();

            textBox2.Text = email;

            productService = new ProductService(new ProductRepository(new AmazonContext()));

            cartService = new CartService(new CartRepository(new AmazonContext()));
            CartDetailsService = new CartDetailsService(new CartDetailsRepository(new AmazonContext()), new ProductRepository(new AmazonContext()));
            UserService = new UserService(new UserRepository(new AmazonContext()), new AdminRepository(new AmazonContext()));


            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            LoadData();


        }

        private void LoadData()
        {
            var Products = productService.GetAll().Where(p => p.Quantity > 0);

            var SelectProducts = Products.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Quantity = p.Quantity,
                Image = p.Image,


            }).ToList();

            dataGridView1.DataSource = SelectProducts;

            dataGridView1.Columns["Image"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
        }


        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                label1.Text = selectedRow.Cells["Name"].Value.ToString();
                label2.Text = selectedRow.Cells["Price"].Value.ToString();
                label3.Text = selectedRow.Cells["Description"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Quantity"].Value.ToString();

                string imagePath = selectedRow.Cells["Image"].Value.ToString();
                pictureBox1.Image = Image.FromFile(imagePath);

            }

        }
        string ImagePath;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }

        }

        // Search
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            IQueryable<Product> filterProduct = productService.SearchByName(name);
            var filterProductSelect = filterProduct.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Quantity = p.Quantity,
                Image = p.Image,
            }).ToList();

            // dataGridView1.DataSource = null;
            dataGridView1.DataSource = filterProductSelect;
            dataGridView1.Columns["Image"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
        }




        private void RefreshDataGridView()
        {
            IQueryable<Product> allProducts = productService.GetAll();

            var ProductSelect = allProducts.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Quantity = p.Quantity,
                Image = p.Image,

            });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductSelect.ToList();
            dataGridView1.Columns["Image"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
        }

        // Clear TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                RefreshDataGridView();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuantityMoreOfStock(object sender, EventArgs e)
        {


        }




        //add to cart
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedQuantity = Convert.ToInt32(textBox3.Text);
                var availableQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                if (selectedQuantity > availableQuantity)
                {
                    MessageBox.Show("Quantity exceeds available stock.");
                    return;
                }

                var selectedProductId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var selectedProduct = productService.GetById(selectedProductId);

                if (selectedProduct == null)
                {
                    MessageBox.Show("Selected product not found. Please check your product information.");
                    return;
                }

                CartDetails? cartDetails = CartDetailsService.GetCartDetailsBy(selectedProductId);

                int Quantity = cartDetails?.Quantity ?? 0;
                int AvailableQuantity = selectedProduct.Quantity - Quantity;

                if (int.TryParse(textBox3.Text, out int quantity) && AvailableQuantity >= quantity)

                {
                    User existingUser = UserService.GetUserByEmail(textBox2.Text);

                    if (existingUser == null)
                    {
                        MessageBox.Show("User not found. Please check your user information.");
                        return;
                    }


                    Cart cart = cartService.Add(existingUser.Id);


                    CartDetails newCartDetails = new CartDetails
                    {
                        ProductId = selectedProduct.Id,
                        Quantity = quantity,
                        CartId = cart.Id
                    };


                    CartDetailsService.Add(newCartDetails);
                    MessageBox.Show($"Your Product added To Cart By Quantity is{quantity}.");

                    LoadData();
                    ClearData();

                }

                else
                {
                    if (AvailableQuantity == 0)
                        MessageBox.Show("I Don't Have in The Stock");
                    else
                        MessageBox.Show($"Please select a product and ensure your quantity is valid OR ENTER a quantity less than {AvailableQuantity}");
                }











            }

        }


        private void LoginForm_UserLoggedIn(object sender, string userEmail)
        {

            textBox2.Text = userEmail;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void ClearData()
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            textBox3.Text = string.Empty;
            pictureBox1.Image = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CartFrm cartFrm = new CartFrm(textBox2.Text);
            cartFrm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();


        }
    }
}
