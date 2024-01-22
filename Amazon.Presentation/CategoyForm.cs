using Amazon.Applacation.Contract;
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
    public partial class CategoyForm : Form
    {
        ICategoryService categoryService;

        public CategoyForm()
        {
            InitializeComponent();

            categoryService = new CategoryService(new CategoryRepository(new AmazonContext()));

        }

        // add category
        private void button1_Click(object sender, EventArgs e)
        {
            string name = CategoryNameText.Text;

            Category NewCategory = new Category()
            {
                Name = name
            };

            categoryService.Add(NewCategory);

            CrearTextBoxes();
            RefreshDataGridView();

            MessageBox.Show("Category Add Successfuly");
        }

        // delete category
        private void button2_Click(object sender, EventArgs e)
        {
            int CategoryId = int.Parse(categoryidtext.Text);

            Category categoryToDelete = categoryService.GetById(CategoryId);

            categoryService.Delete(categoryToDelete);

            CrearTextBoxes();

            RefreshDataGridView();

            MessageBox.Show("Category Deleted Successfuly:");

        }

        // update category
        private void button3_Click(object sender, EventArgs e)
        {
            int CategoryId = int.Parse(categoryidtext.Text);

            Category CategoryToUpdate = categoryService.GetById(CategoryId);

            string NewCategory = CategoryNameText.Text;

            CategoryToUpdate.Name = NewCategory;

            categoryService.Update(CategoryToUpdate);

            CrearTextBoxes();

            RefreshDataGridView();

            MessageBox.Show("Category Updated Successfuly");

        }


        // getall category
        private void button4_Click(object sender, EventArgs e)
        {
            List<Category> categories = categoryService.GetAll();
            dataGridView1.DataSource = categories;

        }






        private void RefreshDataGridView()
        {
            List<Category> Categories = categoryService.GetAll();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = Categories;

        }







        private void CrearTextBoxes()
        {
            categoryidtext.Text = string.Empty;
            CategoryNameText.Text = string.Empty;
        }

       
    }
}
