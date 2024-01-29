using Amazon.Applacation.Service;
using Amazon.Context;
using Amazon.Infrastructure.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.Models.Models;

namespace Amazon.Presentation
{
    public partial class Registration : Form
    {
        IUserService _userService;
        public Registration()
        {
            InitializeComponent();
            _userService = new UserService(new UserRepository(new AmazonContext()), new AdminRepository(new AmazonContext()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = NameText.Text;
            string email = EmailText.Text;
            string password = PasswordText.Text;

            Models.Models.User user = new Models.Models.User()
            {
                Name = name,
                Email = email,
                Password = password,
            };

            if (NameValid.Visible == false &&
               EmailValid.Visible == false &&
               PasswordValid.Visible == false &&
               _userService.AddUser(user) != null)
            {

                _userService.AddUser(user);
                MessageBox.Show("User Add Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Faild to Add User");
            }

        }


        //Name
        private void NameText_TextChanged(object sender, EventArgs e)
        {
            string Name = NameText.Text;
            if (IsValidName(Name))
            {
                NameValid.Visible = false;
            }
            else
            {
                NameValid.Visible = true;
            }

        }

        //fuctionName for validation
        private bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter) && name.Length >= 3;
        }


        //Email
        private void EmailText_TextChanged(object sender, EventArgs e)
        {
            string Emaill = EmailText.Text;
            if (IsValidEmail(Emaill))
            {
                EmailValid.Visible = false;
            }
            else
            {
                EmailValid.Visible = true;
            }
        }


        //fuctionEmail for validation
        private bool IsValidEmail(string email)
        {
            return !string.IsNullOrEmpty(email) && email.Contains("@gmail.com");
        }


        //password
        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            string Passwordd = PasswordText.Text;

            if (IsValidPassword(Passwordd))
            {

                PasswordValid.Visible = false;
            }
            else
            {

                PasswordValid.Visible = true;
            }
        }

        //fuctionPassword for validation
        private bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        private void clear()
        {
            NameText.Clear();
            EmailText.Clear();
            PasswordText.Clear();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
        }
    }
}
