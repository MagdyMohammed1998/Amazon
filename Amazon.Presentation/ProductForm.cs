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

        public ProductForm()
        {
            InitializeComponent();
            productService = new ProductService(new ProductRepository(new AmazonContext()));
        }

        // Add product
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            decimal price = decimal.Parse(textBox2.Text);
            int quantity = int.Parse(textBox3.Text);
            string descrip = textBox4.Text;

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
                Description = descrip
            };

            productService.Add(newProduct);

            CrearTextBoxes();
            RefreshDataGridView();

            MessageBox.Show("Product added successfully");
        }

        // Delete product
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                Product productToDelete = productService.GetById(selectedProductId);

                if (productToDelete != null)
                {
                    productService.Delete(productToDelete);
                    CrearTextBoxes();
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
            List<Product> allProducts = productService.GetAll();
            dataGridView1.DataSource = allProducts;
        }

        // Refresh DataGridView
        private void RefreshDataGridView()
        {
            List<Product> allProducts = productService.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allProducts;
        }

        // Clear text boxes
        private void CrearTextBoxes()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        // Search for products
        private void Search_Click(object sender, EventArgs e)
        {
            string name = ProductSearch.Text;
            List<Product> filterProduct = productService.SearchByName(name);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filterProduct;
        }
    }
}
