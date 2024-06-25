namespace SmartPlanner.UserControls
{
    partial class AddEvent_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addEventDateField = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            addEventNameField = new TextBox();
            addEventDescriptionField = new TextBox();
            addEventButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 28F);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(34, 50);
            label1.Name = "label1";
            label1.Size = new Size(272, 45);
            label1.TabIndex = 0;
            label1.Text = "Додати подію";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(47, 121);
            label2.Name = "label2";
            label2.Size = new Size(128, 26);
            label2.TabIndex = 1;
            label2.Text = "Назва події";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 16F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(47, 225);
            label3.Name = "label3";
            label3.Size = new Size(156, 26);
            label3.TabIndex = 2;
            label3.Text = "Деталі події";
            // 
            // addEventDateField
            // 
            addEventDateField.CalendarFont = new Font("Consolas", 9F);
            addEventDateField.CalendarForeColor = Color.Black;
            addEventDateField.CalendarMonthBackground = SystemColors.ScrollBar;
            addEventDateField.Location = new Point(47, 461);
            addEventDateField.Name = "addEventDateField";
            addEventDateField.Size = new Size(300, 23);
            addEventDateField.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.ScrollBar;
            monthCalendar1.FirstDayOfWeek = Day.Monday;
            monthCalendar1.Font = new Font("Consolas", 9F);
            monthCalendar1.Location = new Point(632, 50);
            monthCalendar1.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.RightToLeft = RightToLeft.Yes;
            monthCalendar1.TabIndex = 4;
            // 
            // addEventNameField
            // 
            addEventNameField.BackColor = Color.White;
            addEventNameField.BorderStyle = BorderStyle.None;
            addEventNameField.Font = new Font("Consolas", 12F);
            addEventNameField.ForeColor = Color.Black;
            addEventNameField.Location = new Point(47, 150);
            addEventNameField.Multiline = true;
            addEventNameField.Name = "addEventNameField";
            addEventNameField.Size = new Size(300, 45);
            addEventNameField.TabIndex = 5;
            // 
            // addEventDescriptionField
            // 
            addEventDescriptionField.BackColor = Color.White;
            addEventDescriptionField.BorderStyle = BorderStyle.None;
            addEventDescriptionField.Font = new Font("Consolas", 12F);
            addEventDescriptionField.ForeColor = Color.Black;
            addEventDescriptionField.Location = new Point(47, 254);
            addEventDescriptionField.Multiline = true;
            addEventDescriptionField.Name = "addEventDescriptionField";
            addEventDescriptionField.Size = new Size(300, 161);
            addEventDescriptionField.TabIndex = 6;
            // 
            // addEventButton
            // 
            addEventButton.BackColor = SystemColors.Info;
            addEventButton.Cursor = Cursors.Hand;
            addEventButton.FlatStyle = FlatStyle.Flat;
            addEventButton.Font = new Font("Consolas", 14F);
            addEventButton.ForeColor = Color.MidnightBlue;
            addEventButton.Location = new Point(126, 540);
            addEventButton.Name = "addEventButton";
            addEventButton.Size = new Size(150, 40);
            addEventButton.TabIndex = 7;
            addEventButton.Text = "Додати";
            addEventButton.UseVisualStyleBackColor = false;
            addEventButton.Click += addEventButton_Click;
            // 
            // AddEvent_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(addEventButton);
            Controls.Add(addEventDescriptionField);
            Controls.Add(addEventNameField);
            Controls.Add(monthCalendar1);
            Controls.Add(addEventDateField);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddEvent_UC";
            Size = new Size(962, 681);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker addEventDateField;
        private MonthCalendar monthCalendar1;
        private TextBox addEventNameField;
        private TextBox addEventDescriptionField;
        private Button addEventButton;
    }
}
