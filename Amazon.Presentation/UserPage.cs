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
    public partial class UserPage : Form
    {
        IProductService productService;
        public UserPage()
        {
            InitializeComponent();

            productService = new ProductService(new ProductRepository(new AmazonContext()));

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            var Products = productService.GetAll();

            var SelectProducts = Products.Select(p => new
            {
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Image = p.Image,


            }).ToList();

            dataGridView1.DataSource = SelectProducts;

            dataGridView1.Columns["Image"].Visible = false;
        }




        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                label1.Text = selectedRow.Cells["Name"].Value.ToString();
                label2.Text = selectedRow.Cells["Price"].Value.ToString();
                label3.Text = selectedRow.Cells["Description"].Value.ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            IQueryable<Product> filterProduct = productService.SearchByName(name);
            var filterProductSelect = filterProduct.Select(p => new
            {
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Image = p.Image,
            }).ToList();

           // dataGridView1.DataSource = null;
            dataGridView1.DataSource = filterProductSelect;
            dataGridView1.Columns["Image"].Visible = false;
        }
    }
}
