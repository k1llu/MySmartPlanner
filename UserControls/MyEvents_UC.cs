namespace SmartPlanner.UserControls
{
    public partial class MyEvents_UC : UserControl
    {
        public MyEvents_UC()
        {
            InitializeComponent();
            loadEvents();
        }
        // видалення події за ід
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int eventIdToRemove = int.Parse(removeEvent.Text);
                DatabaseQueries.DeleteEvent(Form1.userId, eventIdToRemove);
            }
            catch (Exception)
            {
                MessageBox.Show("Не коректний id");
                throw;
            }
        }
        // загрузка подій з бд
        public void loadEvents()
        {
            var myevents = DatabaseQueries.GetUserEvents(Form1.userId);

            EventsLayoutPanel.Controls.Clear();

            foreach (var myevent in myevents)
            {
                Label EventLabel = new Label
                {
                    Text = $"ID:{myevent.id} - {myevent.name}",
                    AutoSize = true,
                    Font = new Font("Consolas", 16, FontStyle.Regular),
                    ForeColor = Color.Gainsboro,
                    Cursor = Cursors.Hand,
                    Tag = myevent.id,
                };

                EventLabel.Click += (sender, e) =>
                {
                    if (sender is Label clickedLabel)
                    {
                        Form1.eventId = (int)clickedLabel.Tag;
                        loadEventData();
                        eventDataPanel.Visible = true;
                        borderPanel.Visible = true;
                    }
                };

                EventLabel.MouseEnter += (sender, e) => EventLabel.ForeColor = Color.DarkBlue;
                EventLabel.MouseLeave += (sender, e) => EventLabel.ForeColor = Color.Gainsboro;

                EventsLayoutPanel.Controls.Add(EventLabel);
            }
        }
        //приховати деталі події

        private void backToEventsArrow_Click(object sender, EventArgs e)
        {
            eventNameField.Text = "";
            eventDescriptionField.Text = "";
            eventDateField.Text = $"Дата: ";

            eventDataPanel.Visible = false;
            borderPanel.Visible = false;
        }
        //загрузити дані про конкретний івент
        private void loadEventData()
        {
            try
            {
                var myEventData = DatabaseQueries.GetEvent(Form1.eventId);

                eventNameField.Text = myEventData.Value.name;
                eventDescriptionField.Text = myEventData.Value.description;
                eventDateField.Text = $"Дата: {myEventData.Value.date.Date:d}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
