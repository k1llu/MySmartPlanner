namespace SmartPlanner.UserControls
{
    partial class MyEvents_UC
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
            EventsLayoutPanel = new TableLayoutPanel();
            removeEvent = new TextBox();
            deleteButton = new Label();
            label2 = new Label();
            eventDataPanel = new Panel();
            backToEventsArrow = new Label();
            eventDateField = new Label();
            label3 = new Label();
            eventDescriptionField = new TextBox();
            eventNameField = new TextBox();
            label4 = new Label();
            borderPanel = new Panel();
            eventDataPanel.SuspendLayout();
            borderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 28F);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(34, 50);
            label1.Name = "label1";
            label1.Size = new Size(209, 45);
            label1.TabIndex = 0;
            label1.Text = "Мої події";
            // 
            // EventsLayoutPanel
            // 
            EventsLayoutPanel.ColumnCount = 1;
            EventsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            EventsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            EventsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            EventsLayoutPanel.Location = new Point(34, 146);
            EventsLayoutPanel.Name = "EventsLayoutPanel";
            EventsLayoutPanel.RowCount = 10;
            EventsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventsLayoutPanel.Size = new Size(281, 507);
            EventsLayoutPanel.TabIndex = 1;
            // 
            // removeEvent
            // 
            removeEvent.BorderStyle = BorderStyle.None;
            removeEvent.Font = new Font("Consolas", 16F);
            removeEvent.Location = new Point(809, 59);
            removeEvent.Multiline = true;
            removeEvent.Name = "removeEvent";
            removeEvent.Size = new Size(56, 32);
            removeEvent.TabIndex = 2;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.BackColor = Color.Transparent;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Font = new Font("Consolas", 20F);
            deleteButton.ForeColor = Color.Gainsboro;
            deleteButton.Location = new Point(871, 59);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(46, 32);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "🗑️";
            deleteButton.Click += deleteButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 20F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(654, 59);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 4;
            label2.Text = "ID події:";
            // 
            // eventDataPanel
            // 
            eventDataPanel.BackColor = SystemColors.ActiveCaption;
            eventDataPanel.Controls.Add(backToEventsArrow);
            eventDataPanel.Controls.Add(eventDateField);
            eventDataPanel.Controls.Add(label3);
            eventDataPanel.Controls.Add(eventDescriptionField);
            eventDataPanel.Controls.Add(eventNameField);
            eventDataPanel.Controls.Add(label4);
            eventDataPanel.Location = new Point(3, 3);
            eventDataPanel.Name = "eventDataPanel";
            eventDataPanel.Size = new Size(537, 485);
            eventDataPanel.TabIndex = 5;
            eventDataPanel.Visible = false;
            // 
            // backToEventsArrow
            // 
            backToEventsArrow.AutoSize = true;
            backToEventsArrow.Font = new Font("Consolas", 24F);
            backToEventsArrow.ForeColor = Color.Gainsboro;
            backToEventsArrow.Location = new Point(12, 11);
            backToEventsArrow.Name = "backToEventsArrow";
            backToEventsArrow.Size = new Size(54, 37);
            backToEventsArrow.TabIndex = 20;
            backToEventsArrow.Text = "✖";
            backToEventsArrow.Click += backToEventsArrow_Click;
            // 
            // eventDateField
            // 
            eventDateField.AutoSize = true;
            eventDateField.Font = new Font("Consolas", 16F);
            eventDateField.ForeColor = Color.MidnightBlue;
            eventDateField.Location = new Point(118, 375);
            eventDateField.Name = "eventDateField";
            eventDateField.Size = new Size(72, 26);
            eventDateField.TabIndex = 19;
            eventDateField.Text = "Дата:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 16F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(120, 40);
            label3.Name = "label3";
            label3.Size = new Size(156, 26);
            label3.TabIndex = 18;
            label3.Text = "Деталі події";
            // 
            // eventDescriptionField
            // 
            eventDescriptionField.BackColor = Color.White;
            eventDescriptionField.BorderStyle = BorderStyle.None;
            eventDescriptionField.Font = new Font("Consolas", 12F);
            eventDescriptionField.ForeColor = Color.Black;
            eventDescriptionField.Location = new Point(118, 183);
            eventDescriptionField.Multiline = true;
            eventDescriptionField.Name = "eventDescriptionField";
            eventDescriptionField.ReadOnly = true;
            eventDescriptionField.Size = new Size(300, 161);
            eventDescriptionField.TabIndex = 17;
            // 
            // eventNameField
            // 
            eventNameField.BackColor = Color.White;
            eventNameField.BorderStyle = BorderStyle.None;
            eventNameField.Font = new Font("Consolas", 12F);
            eventNameField.ForeColor = Color.Black;
            eventNameField.Location = new Point(118, 69);
            eventNameField.Multiline = true;
            eventNameField.Name = "eventNameField";
            eventNameField.ReadOnly = true;
            eventNameField.Size = new Size(300, 45);
            eventNameField.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 16F);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(118, 154);
            label4.Name = "label4";
            label4.Size = new Size(156, 26);
            label4.TabIndex = 15;
            label4.Text = "Деталі події";
            // 
            // borderPanel
            // 
            borderPanel.BackColor = SystemColors.ActiveCaptionText;
            borderPanel.Controls.Add(eventDataPanel);
            borderPanel.Location = new Point(374, 146);
            borderPanel.Name = "borderPanel";
            borderPanel.Padding = new Padding(4);
            borderPanel.Size = new Size(543, 491);
            borderPanel.TabIndex = 21;
            borderPanel.Visible = false;
            // 
            // MyEvents_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(borderPanel);
            Controls.Add(label2);
            Controls.Add(deleteButton);
            Controls.Add(removeEvent);
            Controls.Add(EventsLayoutPanel);
            Controls.Add(label1);
            Name = "MyEvents_UC";
            Size = new Size(962, 681);
            eventDataPanel.ResumeLayout(false);
            eventDataPanel.PerformLayout();
            borderPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel EventsLayoutPanel;
        private TextBox removeEvent;
        private Label deleteButton;
        private Label label2;
        private Panel eventDataPanel;
        private Label eventDateField;
        private Label label3;
        private TextBox eventDescriptionField;
        private TextBox eventNameField;
        private Label label4;
        private Label backToEventsArrow;
        private Panel borderPanel;
    }
}
