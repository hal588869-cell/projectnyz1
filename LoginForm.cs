using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace projectnyz1
{
    public partial class LoginForm : Form
    {
        private string selectedGamePath = "";
        private List<string> savedUsers = new List<string>();

        public LoginForm()
        {
            InitializeComponent();
            LoadSavedUsers();
            ApplyDarkTheme();
        }

        private void LoadSavedUsers()
        {
            string configDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProjectNYZ");
            string usersFile = Path.Combine(configDir, "users.txt");

            if (File.Exists(usersFile))
            {
                var lines = File.ReadAllLines(usersFile);
                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        usernameComboBox.Items.Add(line);
                        savedUsers.Add(line);
                    }
                }
            }

            usernameComboBox.Items.Add("اضف مستخدم جديد");
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = System.Drawing.Color.FromArgb(10, 14, 39);
            this.ForeColor = System.Drawing.Color.White;
        }

        private void usernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usernameComboBox.SelectedItem?.ToString() == "اضف مستخدم جديد")
            {
                newUsernameLabel.Visible = true;
                newUsernameTextBox.Visible = true;
                newUsernameTextBox.Clear();
            }
            else
            {
                newUsernameLabel.Visible = false;
                newUsernameTextBox.Visible = false;
            }
        }

        private void selectGameFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "اختر مجلد اللعبة (Fortnite)";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedGamePath = folderDialog.SelectedPath;
                    gamePathTextBox.Text = selectedGamePath;
                    SaveGamePath(selectedGamePath);
                }
            }
        }

        private void SaveGamePath(string path)
        {
            string configDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProjectNYZ");
            Directory.CreateDirectory(configDir);
            File.WriteAllText(Path.Combine(configDir, "gamepath.txt"), path);
        }

        private string LoadGamePath()
        {
            string configDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProjectNYZ");
            string pathFile = Path.Combine(configDir, "gamepath.txt");
            if (File.Exists(pathFile))
            {
                return File.ReadAllText(pathFile).Trim();
            }
            return "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameComboBox.SelectedItem?.ToString() ?? "";
            string password = passwordTextBox.Text;
            selectedGamePath = gamePathTextBox.Text;

            if (username == "اضف مستخدم جديد")
            {
                username = newUsernameTextBox.Text.Trim();
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("من فضلك أدخل اسم مستخدم صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveNewUser(username);
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("من فضلك أدخل اسم المستخدم وكلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(selectedGamePath))
            {
                selectedGamePath = LoadGamePath();
                if (string.IsNullOrEmpty(selectedGamePath))
                {
                    MessageBox.Show("من فضلك اختر مجلد اللعبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!Directory.Exists(selectedGamePath))
            {
                MessageBox.Show("مجلد اللعبة غير موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            statusLabel.Text = "جاري تسجيل الدخول...";
            statusLabel.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            Application.DoEvents();

            // الانتقال إلى نافذة اللعبة
            GameWindow gameWindow = new GameWindow(username, selectedGamePath);
            gameWindow.Show();
            this.Hide();
        }

        private void SaveNewUser(string username)
        {
            string configDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProjectNYZ");
            Directory.CreateDirectory(configDir);
            string usersFile = Path.Combine(configDir, "users.txt");

            if (!File.Exists(usersFile))
            {
                File.WriteAllText(usersFile, username);
            }
            else
            {
                var users = File.ReadAllText(usersFile);
                if (!users.Contains(username))
                {
                    File.AppendAllText(usersFile, Environment.NewLine + username);
                }
            }
        }
    }
}