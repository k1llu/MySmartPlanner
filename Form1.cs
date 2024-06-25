using SmartPlanner.UserControls;

namespace SmartPlanner
{
    public partial class Form1 : Form
    {
        public static int userId { get; set; }
        public static int eventId { get; set ; }
        public Form1()
        {
            InitializeComponent();
            Login_UC uc = new();
            addUserControl(uc);
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void SwitchToRegistration(UserControl currentUserControl)
        {
            Registration_UC uc = new();
            addUserControl(uc);
        }
        public void SwitchToLogin(UserControl currentUserControl)
        {
            Login_UC uc = new();
            addUserControl(uc);
        }
        public void SwitchToHome(UserControl currentUserControl)
        {
            Home_UC uc = new();
            addUserControl(uc);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
