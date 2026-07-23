namespace projectnyz1
{
    partial class GameWindow
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label usernameDisplayLabel;
        private System.Windows.Forms.Label gameStatusLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label readyLabel;
        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Label serverStatusLabel;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label statusMessageLabel;

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
            this.usernameDisplayLabel = new System.Windows.Forms.Label();
            this.gameStatusLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.readyLabel = new System.Windows.Forms.Label();
            this.playersLabel = new System.Windows.Forms.Label();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.playGameButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.statusMessageLabel = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // usernameDisplayLabel
            this.usernameDisplayLabel.AutoSize = true;
            this.usernameDisplayLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.usernameDisplayLabel.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            this.usernameDisplayLabel.Location = new System.Drawing.Point(100, 40);
            this.usernameDisplayLabel.Name = "usernameDisplayLabel";
            this.usernameDisplayLabel.Size = new System.Drawing.Size(150, 36);
            this.usernameDisplayLabel.TabIndex = 0;
            this.usernameDisplayLabel.Text = "أهلاً بك";
            this.usernameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // gameStatusLabel
            this.gameStatusLabel.AutoSize = true;
            this.gameStatusLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.gameStatusLabel.ForeColor = System.Drawing.Color.White;
            this.gameStatusLabel.Location = new System.Drawing.Point(50, 120);
            this.gameStatusLabel.Name = "gameStatusLabel";
            this.gameStatusLabel.Size = new System.Drawing.Size(100, 22);
            this.gameStatusLabel.TabIndex = 1;
            this.gameStatusLabel.Text = "Game Status";

            // versionLabel
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.versionLabel.Location = new System.Drawing.Point(50, 155);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(60, 17);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version";

            // readyLabel
            this.readyLabel.AutoSize = true;
            this.readyLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.readyLabel.ForeColor = System.Drawing.Color.FromArgb(74, 222, 128);
            this.readyLabel.Location = new System.Drawing.Point(50, 180);
            this.readyLabel.Name = "readyLabel";
            this.readyLabel.Size = new System.Drawing.Size(50, 17);
            this.readyLabel.TabIndex = 3;
            this.readyLabel.Text = "Ready";

            // serverStatusLabel
            this.serverStatusLabel.AutoSize = true;
            this.serverStatusLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.serverStatusLabel.ForeColor = System.Drawing.Color.White;
            this.serverStatusLabel.Location = new System.Drawing.Point(50, 230);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(100, 20);
            this.serverStatusLabel.TabIndex = 4;
            this.serverStatusLabel.Text = "Server Info";

            // playersLabel
            this.playersLabel.AutoSize = true;
            this.playersLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.playersLabel.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.playersLabel.Location = new System.Drawing.Point(50, 265);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(80, 17);
            this.playersLabel.TabIndex = 5;
            this.playersLabel.Text = "Players";

            // playGameButton
            this.playGameButton.BackColor = System.Drawing.Color.FromArgb(74, 222, 128);
            this.playGameButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.playGameButton.ForeColor = System.Drawing.Color.Black;
            this.playGameButton.Location = new System.Drawing.Point(50, 330);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(280, 50);
            this.playGameButton.TabIndex = 6;
            this.playGameButton.Text = "تشغيل اللعبة";
            this.playGameButton.UseVisualStyleBackColor = false;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);

            // logoutButton
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.logoutButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(350, 330);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(280, 50);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "الخروج";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);

            // statusMessageLabel
            this.statusMessageLabel.AutoSize = true;
            this.statusMessageLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.statusMessageLabel.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.statusMessageLabel.Location = new System.Drawing.Point(50, 410);
            this.statusMessageLabel.Name = "statusMessageLabel";
            this.statusMessageLabel.Size = new System.Drawing.Size(0, 17);
            this.statusMessageLabel.TabIndex = 8;

            // GameWindow
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 500);
            this.Controls.Add(this.usernameDisplayLabel);
            this.Controls.Add(this.gameStatusLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.readyLabel);
            this.Controls.Add(this.serverStatusLabel);
            this.Controls.Add(this.playersLabel);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.statusMessageLabel);
            this.Name = "GameWindow";
            this.Text = "Project NYZ - Game Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}