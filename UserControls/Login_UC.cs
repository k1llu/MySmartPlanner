using System.Text;
using System.Security.Cryptography;

namespace SmartPlanner.UserControls
{
    public partial class Login_UC : UserControl
    {
        public Login_UC()
        {
            InitializeComponent();
        }
        //перехід на реєстрацію
        private void routeToRegistration_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.Parent.Parent;
            parentForm.SwitchToRegistration(this);
        }
        // перехід на хоум (у результаті успішного логіну)
        private void routeToHome()
        {
            Form1 parentForm = (Form1)this.Parent.Parent;
            parentForm.SwitchToHome(this);
        }
        // логін

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailLoginField.Text;
            string password = passwordLoginField.Text;

            string hashedPassword;
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                hashedPassword = Convert.ToBase64String(hash);
            }

            int responseValue = DatabaseQueries.LoginUser(email, hashedPassword);

            if (responseValue != -1)
            {
                Form1.userId = responseValue;
                MessageBox.Show($"You successfully logged in!");
                routeToHome();
            }
            else
            {
                MessageBox.Show("There is no such user.");
            }
        }
    }
}
