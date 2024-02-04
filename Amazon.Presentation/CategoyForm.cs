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

        public CategoyForm(string Email)
        {
            InitializeComponent();
             textBox2.Text = Email;


            categoryService = new CategoryService(new CategoryRepository(new AmazonContext()));

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                
                TextBox1.Text = selectedRow.Cells["Name"].Value.ToString();

            }
        }

        // add category
        private void button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;

            var existingCatgory = categoryService.GetAll().FirstOrDefault(p => p.Name == name);
            if (existingCatgory != null)
            {
                MessageBox.Show($"Product with name '{name}' already exists.");
                return;
            }


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
            int CategoryId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            Category categoryToDelete = categoryService.GetById(CategoryId);
            if (categoryToDelete != null)
            {
                categoryService.Delete(categoryToDelete);

                CrearTextBoxes();

                RefreshDataGridView();

                MessageBox.Show("Category Deleted Successfuly:");
            }
            else
            {
                MessageBox.Show("Please select a Category to delete.");
            }


        }

        // update category
        private void button3_Click(object sender, EventArgs e)
        {
            int CategoryId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            Category CategoryToUpdate = categoryService.GetById(CategoryId);

            if (CategoryToUpdate != null)
            {
                string NewCategory = TextBox1.Text;

                CategoryToUpdate.Name = NewCategory;

                categoryService.Update(CategoryToUpdate);

                CrearTextBoxes();

                RefreshDataGridView();

                MessageBox.Show("Category Updated Successfuly");

            }
            else
            {
                MessageBox.Show("Please select a Category to update.");
            }


        }


        // getall category
        private void button4_Click(object sender, EventArgs e)
        {
            var categories = categoryService.GetAll();
            var SelectedCategory = categories.Select(c => new
            {
                Id = c.Id,
                Name = c.Name,

            }).ToList();

            dataGridView1.DataSource = SelectedCategory;

        }






        private void RefreshDataGridView()
        {
            var Categories = categoryService.GetAll();
            var SelectedCategory = Categories.Select(c => new
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();

            //dataGridView1.DataSource = null;

            dataGridView1.DataSource = SelectedCategory;

        }







        private void CrearTextBoxes()
        {

            TextBox1.Text = string.Empty;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string name = texSearch.Text;
            IQueryable<Category> filterCategory = categoryService.SearchByName(name);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filterCategory;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminPanle adminPanle = new adminPanle(textBox2.Text);
            adminPanle.Show();
            this.Hide();
        }
    }
}
