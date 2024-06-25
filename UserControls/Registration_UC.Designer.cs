namespace SmartPlanner.UserControls
{
    partial class Registration_UC
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
            switchToLogin = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            userNameField = new TextBox();
            emailField = new TextBox();
            passwordField = new TextBox();
            confirmPasswordField = new TextBox();
            submitRegButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 36F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(464, 80);
            label1.Name = "label1";
            label1.Size = new Size(336, 56);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(482, 418);
            label2.Name = "label2";
            label2.Size = new Size(204, 26);
            label2.TabIndex = 1;
            label2.Text = "Confirm Password";
            // 
            // switchToLogin
            // 
            switchToLogin.AutoSize = true;
            switchToLogin.Font = new Font("Consolas", 11.25F);
            switchToLogin.ForeColor = Color.Gainsboro;
            switchToLogin.Location = new Point(532, 636);
            switchToLogin.Name = "switchToLogin";
            switchToLogin.Size = new Size(200, 18);
            switchToLogin.TabIndex = 5;
            switchToLogin.Text = "Already have an account?";
            switchToLogin.Click += switchToLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 16F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(482, 338);
            label3.Name = "label3";
            label3.Size = new Size(108, 26);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 16F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(482, 252);
            label4.Name = "label4";
            label4.Size = new Size(72, 26);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 16F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(482, 175);
            label5.Name = "label5";
            label5.Size = new Size(108, 26);
            label5.TabIndex = 8;
            label5.Text = "Username";
            // 
            // userNameField
            // 
            userNameField.BackColor = Color.White;
            userNameField.BorderStyle = BorderStyle.None;
            userNameField.Font = new Font("Consolas", 16F);
            userNameField.ForeColor = Color.Black;
            userNameField.Location = new Point(482, 204);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(300, 45);
            userNameField.TabIndex = 9;
            // 
            // emailField
            // 
            emailField.BackColor = Color.White;
            emailField.BorderStyle = BorderStyle.None;
            emailField.Font = new Font("Consolas", 16F);
            emailField.ForeColor = Color.Black;
            emailField.Location = new Point(482, 290);
            emailField.Multiline = true;
            emailField.Name = "emailField";
            emailField.Size = new Size(300, 45);
            emailField.TabIndex = 10;
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.White;
            passwordField.BorderStyle = BorderStyle.None;
            passwordField.Font = new Font("Consolas", 16F);
            passwordField.ForeColor = Color.Black;
            passwordField.Location = new Point(482, 367);
            passwordField.Multiline = true;
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(300, 45);
            passwordField.TabIndex = 11;
            // 
            // confirmPasswordField
            // 
            confirmPasswordField.BackColor = Color.White;
            confirmPasswordField.BorderStyle = BorderStyle.None;
            confirmPasswordField.Font = new Font("Consolas", 16F);
            confirmPasswordField.ForeColor = Color.Black;
            confirmPasswordField.Location = new Point(482, 447);
            confirmPasswordField.Multiline = true;
            confirmPasswordField.Name = "confirmPasswordField";
            confirmPasswordField.PasswordChar = '*';
            confirmPasswordField.Size = new Size(300, 45);
            confirmPasswordField.TabIndex = 12;
            // 
            // submitRegButton
            // 
            submitRegButton.Cursor = Cursors.Hand;
            submitRegButton.FlatStyle = FlatStyle.Flat;
            submitRegButton.Font = new Font("Consolas", 14F);
            submitRegButton.ForeColor = Color.White;
            submitRegButton.Location = new Point(557, 523);
            submitRegButton.Name = "submitRegButton";
            submitRegButton.Size = new Size(150, 40);
            submitRegButton.TabIndex = 13;
            submitRegButton.Text = "Confirm";
            submitRegButton.UseVisualStyleBackColor = true;
            submitRegButton.Click += submitRegButton_Click;
            // 
            // Registration_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(submitRegButton);
            Controls.Add(confirmPasswordField);
            Controls.Add(passwordField);
            Controls.Add(emailField);
            Controls.Add(userNameField);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(switchToLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration_UC";
            Size = new Size(1264, 681);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label switchToLogin;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox userNameField;
        private TextBox emailField;
        private TextBox passwordField;
        private TextBox confirmPasswordField;
        private Button submitRegButton;
    }
}
