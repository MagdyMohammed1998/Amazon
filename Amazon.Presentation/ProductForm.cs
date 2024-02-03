using Amazon.Applacation.Service;
using Amazon.Context;
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
    public partial class ProductForm : Form
    {
        IProductService productService;

        private List<Category> categories;
        private ICategoryService categoryService;

        public ProductForm()
        {
            InitializeComponent();
            productService = new ProductService(new ProductRepository(new AmazonContext()));
            categoryService = new CategoryService(new CategoryRepository(new AmazonContext()));
            LoadCategories();

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                textBox1.Text = selectedRow.Cells["Name"].Value.ToString();
                textBox2.Text = selectedRow.Cells["Price"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Quantity"].Value.ToString();
                textBox4.Text = selectedRow.Cells["Description"].Value.ToString();

                string imagePath = selectedRow.Cells["Image"].Value.ToString();
                pictureBox1.Image = Image.FromFile(imagePath);

                
            }
        }

        string ImagePath;
        // Add product
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            decimal price = decimal.Parse(textBox2.Text);
            int quantity = int.Parse(textBox3.Text);
            string descrip = textBox4.Text;
            int categoryId = (int)comboBox1.SelectedValue;

            var existingProduct = productService.GetAll().FirstOrDefault(p => p.Name == name);
            if (existingProduct != null)
            {
                MessageBox.Show($"Product with name '{name}' already exists.");
                return;
            }

            Product newProduct = new Product()
            {
                Name = name,
                Price = price,
                Quantity = quantity,
                Description = descrip,
                CategoryID = categoryId,
                Image = ImagePath

            };

            productService.Add(newProduct);
            dataGridView1.Columns["Image"].Visible = false;
            string NewPath = Environment.CurrentDirectory + "\\images\\Product\\" + newProduct.Id + ".jpg";
            File.Copy(ImagePath, NewPath);

            newProduct.Image = NewPath;

            CrearTextBoxes();
            clearpictur();
            RefreshDataGridView();

            MessageBox.Show("Product added successfully");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }

        }

        // Delete product
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                

                var selectedProductId = dataGridView1.SelectedRows[0];

                var productToDelete = selectedProductId.DataBoundItem as Product;
              
                if(productToDelete != null)
                {
                    productService.Delete(productToDelete);

                    clearpictur();
                    RefreshDataGridView();
                    MessageBox.Show("Product deleted successfully");

                }
                else
                {
                    MessageBox.Show("Please select a product to delete.");
                }


                
            }
        }

        // Update product
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                Product productToUpdate = productService.GetById(selectedProductId);

                if (productToUpdate != null)
                {
                    string newName = textBox1.Text;
                    decimal newPrice = decimal.Parse(textBox2.Text);
                    int newQuantity = int.Parse(textBox3.Text);
                    string newDescription = textBox4.Text;

                    productToUpdate.Name = newName;
                    productToUpdate.Price = newPrice;
                    productToUpdate.Quantity = newQuantity;
                    productToUpdate.Description = newDescription;

                    productService.Update(productToUpdate);

                    CrearTextBoxes();
                    clearpictur();
                    RefreshDataGridView();

                    MessageBox.Show("Product updated successfully");
                }
                else
                {
                    MessageBox.Show("Please select a product to update.");
                }
            }
        }

        // Get all products
        private void button4_Click(object sender, EventArgs e)
        {
            var allProducts = productService.GetAll();

            var SelectedProduct = allProducts.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
                Description = p.Description,
                Image = p.Image,

            }).ToList();

           
            dataGridView1.DataSource = SelectedProduct;
            dataGridView1.Columns["Image"].Visible = false;

        }

        // Refresh DataGridView
        private void RefreshDataGridView()
        {
            var allProducts = productService.GetAll();
            var SelectedProduct = allProducts.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
                Description = p.Description,
                Image = p.Image,

            }).ToList();

            //dataGridView1.DataSource = null;
            dataGridView1.DataSource = allProducts.ToList();
            dataGridView1.Columns["Image"].Visible = false;
        }

        // Clear text boxes
        private void CrearTextBoxes()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }


        private void clearpictur()
        {
            pictureBox1.ImageLocation = null;
        }

        // Search for products
        private void Search_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            var filterProduct = productService.SearchByName(name);
            var filterProductSelect = filterProduct.Select(p => new
            {
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
                Description = p.Description,
                Image = p.Image,
            }).ToList();

            // dataGridView1.DataSource = null;
            dataGridView1.DataSource = filterProductSelect;
            dataGridView1.Columns["Image"].Visible = false;

            
        
        }


        private void LoadCategories()
        {
            categories = categoryService.GetAll().ToList();
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminPanle adminPanle = new adminPanle();
            adminPanle.Show();
            this.Close();
        }
    }
}
