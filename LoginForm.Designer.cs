namespace projectnyz1
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox usernameComboBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox gamePathTextBox;
        private System.Windows.Forms.TextBox newUsernameTextBox;
        private System.Windows.Forms.Button selectGameFolderButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label gamePathLabel;
        private System.Windows.Forms.Label newUsernameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label statusLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.gamePathLabel = new System.Windows.Forms.Label();
            this.newUsernameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.usernameComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.gamePathTextBox = new System.Windows.Forms.TextBox();
            this.newUsernameTextBox = new System.Windows.Forms.TextBox();
            this.selectGameFolderButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            this.titleLabel.Location = new System.Drawing.Point(100, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(400, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "PROJECT NYZ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // usernameLabel
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.usernameLabel.Location = new System.Drawing.Point(50, 90);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 17);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "اختر المستخدم";

            // usernameComboBox
            this.usernameComboBox.BackColor = System.Drawing.Color.FromArgb(26, 31, 58);
            this.usernameComboBox.Font = new System.Drawing.Font("Arial", 12F);
            this.usernameComboBox.ForeColor = System.Drawing.Color.White;
            this.usernameComboBox.Location = new System.Drawing.Point(50, 115);
            this.usernameComboBox.Name = "usernameComboBox";
            this.usernameComboBox.Size = new System.Drawing.Size(500, 30);
            this.usernameComboBox.TabIndex = 0;
            this.usernameComboBox.SelectedIndexChanged += new System.EventHandler(this.usernameComboBox_SelectedIndexChanged);

            // newUsernameLabel
            this.newUsernameLabel.AutoSize = true;
            this.newUsernameLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.newUsernameLabel.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.newUsernameLabel.Location = new System.Drawing.Point(50, 155);
            this.newUsernameLabel.Name = "newUsernameLabel";
            this.newUsernameLabel.Size = new System.Drawing.Size(150, 17);
            this.newUsernameLabel.TabIndex = 2;
            this.newUsernameLabel.Text = "اسم المستخدم الجديد";
            this.newUsernameLabel.Visible = false;

            // newUsernameTextBox
            this.newUsernameTextBox.BackColor = System.Drawing.Color.FromArgb(26, 31, 58);
            this.newUsernameTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.newUsernameTextBox.ForeColor = System.Drawing.Color.White;
            this.newUsernameTextBox.Location = new System.Drawing.Point(50, 180);
            this.newUsernameTextBox.Name = "newUsernameTextBox";
            this.newUsernameTextBox.Size = new System.Drawing.Size(500, 30);
            this.newUsernameTextBox.TabIndex = 1;
            this.newUsernameTextBox.Visible = false;

            // passwordLabel
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.passwordLabel.Location = new System.Drawing.Point(50, 225);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 17);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "كلمة المرور";

            // passwordTextBox
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(26, 31, 58);
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(50, 250);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(500, 30);
            this.passwordTextBox.TabIndex = 2;

            // gamePathLabel
            this.gamePathLabel.AutoSize = true;
            this.gamePathLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.gamePathLabel.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.gamePathLabel.Location = new System.Drawing.Point(50, 295);
            this.gamePathLabel.Name = "gamePathLabel";
            this.gamePathLabel.Size = new System.Drawing.Size(150, 17);
            this.gamePathLabel.TabIndex = 4;
            this.gamePathLabel.Text = "مسار مجلد اللعبة";

            // gamePathTextBox
            this.gamePathTextBox.BackColor = System.Drawing.Color.FromArgb(26, 31, 58);
            this.gamePathTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.gamePathTextBox.ForeColor = System.Drawing.Color.White;
            this.gamePathTextBox.Location = new System.Drawing.Point(50, 320);
            this.gamePathTextBox.Name = "gamePathTextBox";
            this.gamePathTextBox.ReadOnly = true;
            this.gamePathTextBox.Size = new System.Drawing.Size(400, 25);
            this.gamePathTextBox.TabIndex = 5;

            // selectGameFolderButton
            this.selectGameFolderButton.BackColor = System.Drawing.Color.FromArgb(0, 212, 255);
            this.selectGameFolderButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.selectGameFolderButton.ForeColor = System.Drawing.Color.Black;
            this.selectGameFolderButton.Location = new System.Drawing.Point(460, 320);
            this.selectGameFolderButton.Name = "selectGameFolderButton";
            this.selectGameFolderButton.Size = new System.Drawing.Size(90, 35);
            this.selectGameFolderButton.TabIndex = 3;
            this.selectGameFolderButton.Text = "اختر";
            this.selectGameFolderButton.UseVisualStyleBackColor = false;
            this.selectGameFolderButton.Click += new System.EventHandler(this.selectGameFolderButton_Click);
            this.selectGameFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;

            // loginButton
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(0, 212, 255);
            this.loginButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(50, 380);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(500, 50);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "دخول";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;

            // statusLabel
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.statusLabel.Location = new System.Drawing.Point(50, 445);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.statusLabel.AutoSize = true;

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.BackColor = System.Drawing.Color.FromArgb(10, 14, 39);
            this.ForeColor = System.Drawing.Color.White;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameComboBox);
            this.Controls.Add(this.newUsernameLabel);
            this.Controls.Add(this.newUsernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.gamePathLabel);
            this.Controls.Add(this.gamePathTextBox);
            this.Controls.Add(this.selectGameFolderButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.statusLabel);
            this.Name = "LoginForm";
            this.Text = "Project NYZ - Fortnite Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Icon = null;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}