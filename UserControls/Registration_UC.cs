using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace SmartPlanner.UserControls
{
    public partial class Registration_UC : UserControl
    {
        public Registration_UC()
        {
            InitializeComponent();
        }
        private void switchToLogin_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.Parent.Parent;
            parentForm.SwitchToLogin(this);
        }
        public List<string> ValidateInputs(string name, string email, string password, string confPassword)
        {
            List<string> errorList = new();

            string passwordMustContain = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(),.?:{}|<>])[A-Za-z\d!@#$%^&*(),.?:{}|<>]{8,}$";
            Regex passwordRegex = new(passwordMustContain);

            string emailMustContain = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex emailRegex = new(emailMustContain);

            if (name == "" || email == "" || password == "" || confPassword == "")
            {
                errorList.Add("Fields cannot be empty.");
            }
            if (name.Length < 4 || name.Length > 16)
            {
                errorList.Add("Username must be in range of 4-16 letters.");
            }
            if (!passwordRegex.IsMatch(password))
            {
                errorList.Add("Password must conatin more than 8 letters, 1 special symbol, number and upper case.");
            }
            if (!emailRegex.IsMatch(email))
            {
                errorList.Add("Email must be like john.doe@example.com.");
            }
            if (password != confPassword)
            {
                errorList.Add("Confirm password must metch password.");
            }

            return errorList;
        }
        private void routeToHome()
        {
            Form1 parentForm = (Form1)this.Parent.Parent;
            parentForm.SwitchToLogin(this);
        }
        private void submitRegButton_Click(object sender, EventArgs e)
        {
            string name = userNameField.Text;
            string email = emailField.Text;
            string password = passwordField.Text;
            string confPassword = confirmPasswordField.Text;

            List<string> errorList = ValidateInputs(name, email, password, confPassword);

            if (errorList.Count == 0)
            {
                string hashedPassword;
                using (var sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(password);
                    byte[] hash = sha256.ComputeHash(bytes);
                    hashedPassword = Convert.ToBase64String(hash);
                }

                DatabaseQueries.RegisterUser(name, email, hashedPassword);
                MessageBox.Show("You successfully registered!");
                routeToHome();
            }
            else
            {
                string errorMessage = string.Join(Environment.NewLine, errorList);
                MessageBox.Show(errorMessage);
            }
        }
    }
}
