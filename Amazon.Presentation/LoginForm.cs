using Amazon.Applacation.Service;
using Amazon.Context;
using Amazon.Infrastructure.Repositories;

namespace Amazon.Presentation
{
    public partial class UserLogin : Form
    {
        IUserService _userService;
        IAdminService _adminService;
        public event EventHandler<string> UserLoggedIn;
        public event EventHandler<string> AdminLoggedIn;


        public UserLogin()
        {
            InitializeComponent();
            _userService = new UserService(new UserRepository(new AmazonContext()), new AdminRepository(new AmazonContext()));
            _adminService = new AdminService(new AdminRepository(new AmazonContext()));

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click_1(object sender, EventArgs e)
        {
            string email = EmaillText.Text; 
            string password = PasworddText.Text;
            if (_adminService.GetAdminEmailAndPassword(email, password))
            {
               
                adminPanle adminPanle = new adminPanle();
                AdminLoggedIn?.Invoke(this, email);
                adminPanle.Show();
                this.Hide();
            }
            else if (_userService.GetUserEmailAndPassword(email, password))
            {

                prodcuts prodcuts = new prodcuts(email);

                UserLoggedIn?.Invoke(this, email);
                prodcuts.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E  mail Or Password Is Not Valid");
                clear();
            }
        }

        private void Register_Click_1(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void clear()
        {
            EmaillText.Clear();
            PasworddText.Clear();
        }
    }
}
