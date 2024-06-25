namespace SmartPlanner.UserControls
{
    partial class Login_UC
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
            emailLoginField = new TextBox();
            passwordLoginField = new TextBox();
            loginButton = new Button();
            routeToRegistration = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 36F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(555, 80);
            label1.Name = "label1";
            label1.Size = new Size(154, 56);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(482, 252);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 16F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(482, 175);
            label3.Name = "label3";
            label3.Size = new Size(72, 26);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // emailLoginField
            // 
            emailLoginField.BackColor = Color.White;
            emailLoginField.BorderStyle = BorderStyle.None;
            emailLoginField.Font = new Font("Consolas", 16F);
            emailLoginField.Location = new Point(482, 204);
            emailLoginField.Multiline = true;
            emailLoginField.Name = "emailLoginField";
            emailLoginField.Size = new Size(300, 45);
            emailLoginField.TabIndex = 3;
            // 
            // passwordLoginField
            // 
            passwordLoginField.BackColor = Color.White;
            passwordLoginField.BorderStyle = BorderStyle.None;
            passwordLoginField.Font = new Font("Consolas", 16F);
            passwordLoginField.Location = new Point(482, 281);
            passwordLoginField.Multiline = true;
            passwordLoginField.Name = "passwordLoginField";
            passwordLoginField.PasswordChar = '*';
            passwordLoginField.Size = new Size(300, 45);
            passwordLoginField.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Consolas", 14F);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(557, 372);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 40);
            loginButton.TabIndex = 5;
            loginButton.Text = "Confirm";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // routeToRegistration
            // 
            routeToRegistration.AutoSize = true;
            routeToRegistration.Font = new Font("Consolas", 11.25F);
            routeToRegistration.ForeColor = Color.Gainsboro;
            routeToRegistration.Location = new Point(540, 593);
            routeToRegistration.Name = "routeToRegistration";
            routeToRegistration.Size = new Size(184, 18);
            routeToRegistration.TabIndex = 6;
            routeToRegistration.Text = "Registrate an account?";
            routeToRegistration.Click += routeToRegistration_Click;
            // 
            // Login_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(routeToRegistration);
            Controls.Add(loginButton);
            Controls.Add(passwordLoginField);
            Controls.Add(emailLoginField);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login_UC";
            Size = new Size(1264, 681);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox emailLoginField;
        private TextBox passwordLoginField;
        private Button loginButton;
        private Label routeToRegistration;
    }
}
