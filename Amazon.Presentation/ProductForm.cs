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

        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public string Description { get; private set; }


        // add product
        private void button1_Click(object sender, EventArgs e)
        {



            string name = textBox1.Text;
            decimal price = decimal.Parse(textBox2.Text);
            int quantity = int.Parse(textBox3.Text);
            string descrip = textBox4.Text;



            Product NewProduct = new Product()
            {
                Name = name,
                Price = price,
                Quantity = quantity,
                Description = descrip



            };


            productService.Add(NewProduct);

            CrearTextBoxes();


            RefreshDataGridView();


            MessageBox.Show("Product Add Succssifuly");


        }

        // delete product
        private void button2_Click(object sender, EventArgs e)
        {
            int ProductId = int.Parse(textBox5.Text);
            Product ProductToDelete = productService.GetById(ProductId);

            productService.Delete(ProductToDelete);

            CrearTextBoxes();

            RefreshDataGridView();

            MessageBox.Show("Product Deleted Successfuly");

        }

         // update product
        private void button3_Click(object sender, EventArgs e)
        {
            int ProductId = int.Parse(textBox5.Text);
            Product ProductToUpdate = productService.GetById(ProductId);


            string NewName = textBox1.Text;
            decimal NewPric = decimal.Parse(textBox2.Text);
            int NewQuantity = int.Parse(textBox3.Text);
            string NewDescription = textBox4.Text;

            ProductToUpdate.Name = NewName;
            ProductToUpdate.Price = NewPric;
            ProductToUpdate.Quantity = NewQuantity;
            ProductToUpdate.Description = NewDescription;


            productService.Update(ProductToUpdate);

            CrearTextBoxes();
            RefreshDataGridView();

            MessageBox.Show("Product Updated Successfuly");


        }

        // getall product
        private void button4_Click(object sender, EventArgs e)
        {
            List<Product> AllProducts = productService.GetAll();

            dataGridView1.DataSource = AllProducts;

        }






        private void RefreshDataGridView()
        {
            List<Product> AllProducts = productService.GetAll();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = AllProducts;

        }



        private void CrearTextBoxes()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        
    }
}
