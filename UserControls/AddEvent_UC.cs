using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Windows.Forms;

namespace SmartPlanner.UserControls
{
    public partial class AddEvent_UC : UserControl
    {
        public AddEvent_UC()
        {
            InitializeComponent();
        }
        //Метод, що описує натискання на кнопку (щоб додати івент)
        private void addEventButton_Click(object sender, EventArgs e)
        {
            try
            {
                string eventName = addEventNameField.Text;
                string eventDescription = addEventDescriptionField.Text;
                DateTime date = addEventDateField.Value.Date;

                if (date < DateTime.Now || date > new DateTime(DateTime.Now.Year + 1, 12, 31))
                {
                    throw new Exception("Дата не може такою бути!");
                }
                if(string.IsNullOrEmpty(eventName) && string.IsNullOrEmpty(eventDescription))  
                { 
                    throw new Exception("Поля мають бути заповненими!");
                }

                DatabaseQueries.AddEvent(eventName, eventDescription, date, Form1.userId);
                SendEmail(eventName, eventDescription, date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Відправити мейл
        private void SendEmail(string eventName, string eventDescription, DateTime date)
        {
            string fromEmail = "my.smartplanner.pmk@outlook.com";
            string fromPassword = "mt3mZbGdKH5UbNd";
            string toEmail = DatabaseQueries.GetUserEmail(Form1.userId);

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Smart Planner", fromEmail));
            message.To.Add(new MailboxAddress("", toEmail));
            message.Subject = "Нову подію додано";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"Додано нову подію:\nНазва: {eventName}\nОпис: {eventDescription}\nДата: {date:dd.MM.yyyy}";
            message.Body = bodyBuilder.ToMessageBody();

            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate(fromEmail, fromPassword);
                    client.Send(message);
                    client.Disconnect(true);

                    MessageBox.Show("Email успішно відправлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при відправленні email: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
