namespace SmartPlanner.UserControls
{
    partial class Home_UC
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
            LeftBorderPanel = new Panel();
            LogOut = new Label();
            LookEvents = new Label();
            AddEvent = new Label();
            label1 = new Label();
            HomeContentPanel = new Panel();
            label2 = new Label();
            LeftBorderPanel.SuspendLayout();
            HomeContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftBorderPanel
            // 
            LeftBorderPanel.BackColor = Color.SteelBlue;
            LeftBorderPanel.Controls.Add(LogOut);
            LeftBorderPanel.Controls.Add(LookEvents);
            LeftBorderPanel.Controls.Add(AddEvent);
            LeftBorderPanel.Controls.Add(label1);
            LeftBorderPanel.Location = new Point(0, 0);
            LeftBorderPanel.Name = "LeftBorderPanel";
            LeftBorderPanel.Size = new Size(302, 681);
            LeftBorderPanel.TabIndex = 0;
            // 
            // LogOut
            // 
            LogOut.AutoSize = true;
            LogOut.Font = new Font("Consolas", 18F);
            LogOut.ForeColor = Color.Gainsboro;
            LogOut.Location = new Point(23, 629);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(77, 28);
            LogOut.TabIndex = 4;
            LogOut.Text = "Вийти";
            LogOut.Click += LogOut_Click;
            // 
            // LookEvents
            // 
            LookEvents.AutoSize = true;
            LookEvents.Font = new Font("Consolas", 14F);
            LookEvents.ForeColor = Color.Gainsboro;
            LookEvents.Location = new Point(51, 178);
            LookEvents.Name = "LookEvents";
            LookEvents.Size = new Size(180, 22);
            LookEvents.TabIndex = 2;
            LookEvents.Text = "Переглянути події";
            LookEvents.Click += LookEvents_Click;
            // 
            // AddEvent
            // 
            AddEvent.AutoSize = true;
            AddEvent.Font = new Font("Consolas", 14F);
            AddEvent.ForeColor = Color.Gainsboro;
            AddEvent.Location = new Point(51, 124);
            AddEvent.Name = "AddEvent";
            AddEvent.Size = new Size(130, 22);
            AddEvent.TabIndex = 1;
            AddEvent.Text = "Додати подію";
            AddEvent.Click += AddEvent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 24F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(233, 37);
            label1.TabIndex = 0;
            label1.Text = "SmartPlanner";
            // 
            // HomeContentPanel
            // 
            HomeContentPanel.BackColor = SystemColors.ActiveCaption;
            HomeContentPanel.Controls.Add(label2);
            HomeContentPanel.Location = new Point(302, 0);
            HomeContentPanel.Name = "HomeContentPanel";
            HomeContentPanel.Size = new Size(962, 681);
            HomeContentPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 28F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(357, 319);
            label2.Name = "label2";
            label2.Size = new Size(167, 45);
            label2.TabIndex = 0;
            label2.Text = "Welcome";
            // 
            // Home_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LeftBorderPanel);
            Controls.Add(HomeContentPanel);
            Name = "Home_UC";
            Size = new Size(1264, 681);
            LeftBorderPanel.ResumeLayout(false);
            LeftBorderPanel.PerformLayout();
            HomeContentPanel.ResumeLayout(false);
            HomeContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftBorderPanel;
        private Label label1;
        private Panel HomeContentPanel;
        private Label LogOut;
        private Label LookEvents;
        private Label AddEvent;
        private Label label2;
    }
}
