using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPlanner.UserControls
{
    public partial class Home_UC : UserControl
    {
        public Home_UC()
        {
            InitializeComponent();
            label2.Text = $"Привіт, {DatabaseQueries.GetUsername(Form1.userId)}";
        }
        //Опис зміни UserControl-ів
        public void changeHomePageContent(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            HomeContentPanel.Controls.Clear();
            HomeContentPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        //Перехід на вкладку "Додати подію"
        private void AddEvent_Click(object sender, EventArgs e)
        {
            AddEvent_UC uc = new();
            changeHomePageContent(uc);
        }
        //Перехід на вкладку "Мої події"
        public void LookEvents_Click(object sender, EventArgs e)
        {
            MyEvents_UC uc = new();
            changeHomePageContent(uc);
        }
        //Кнопка виходу
        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1.userId = -1;
            Form1 parentForm = (Form1)this.Parent.Parent;
            parentForm.SwitchToLogin(this);
        }
    }
}
