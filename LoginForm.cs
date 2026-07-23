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
            LoadSavedGamePath();
            ApplyDarkTheme();
        }

        private void LoadSavedUsers()
        {
            try
            {
                string configDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProjectNYZ");
                string usersFile = Path.Combine(configDir, "users.txt");

                if (File.Exists(usersFile))
                {
                    var lines = File.ReadAllLines(usersFile);
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrEmpty(line.Trim()))
                        {
                            usernameComboBox.Items.Add(line.Trim());
                            savedUsers.Add(line.Trim());
                        }
                    }
                }

                usernameComboBox.Items.Add("إضف مستخدم جديد");
                if (usernameComboBox.Items.Count > 0)
                {
                    usernameComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل المستخدمين: {ex.Message}");
            }
        }

        private void LoadSavedGamePath()
        {
            try
            {
                string configDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProjectNYZ");
                string pathFile = Path.Combine(configDir, "gamepath.txt");
                if (File.Exists(pathFile))
                {
                    selectedGamePath = File.ReadAllText(pathFile).Trim();
                    gamePathTextBox.Text = selectedGamePath;
                }
            }
            catch { }
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = System.Drawing.Color.FromArgb(10, 14, 39);
            this.ForeColor = System.Drawing.Color.White;
        }

        private void usernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usernameComboBox.SelectedItem?.ToString() == "إضف مستخدم جديد")
            {
                newUsernameLabel.Visible = true;
                newUsernameTextBox.Visible = true;
                newUsernameTextBox.Clear();
                newUsernameTextBox.Focus();
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
                folderDialog.Description = "اختر مجلد اللعبة الرئيسي (حيث توجد مجلد FortniteGame)";
                if (!string.IsNullOrEmpty(selectedGamePath))
                {
                    folderDialog.SelectedPath = selectedGamePath;
                }

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedGamePath = folderDialog.SelectedPath;
                    gamePathTextBox.Text = selectedGamePath;
                    SaveGamePath(selectedGamePath);
                    statusLabel.Text = "✓ تم حفظ المسار بنجاح";
                    statusLabel.ForeColor = System.Drawing.Color.FromArgb(74, 222, 128);
                }
            }
        }

        private void SaveGamePath(string path)
        {
            try
            {
                string configDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProjectNYZ");
                Directory.CreateDirectory(configDir);
                File.WriteAllText(Path.Combine(configDir, "gamepath.txt"), path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في حفظ المسار: {ex.Message}");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameComboBox.SelectedItem?.ToString() ?? "";
                string password = passwordTextBox.Text;
                selectedGamePath = gamePathTextBox.Text.Trim();

                // التحقق من المستخدم الجديد
                if (username == "إضف مستخدم جديد")
                {
                    username = newUsernameTextBox.Text.Trim();
                    if (string.IsNullOrEmpty(username))
                    {
                        MessageBox.Show("من فضلك أدخل اسم مستخدم صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        newUsernameTextBox.Focus();
                        return;
                    }
                    SaveNewUser(username);
                }

                // التحقق من المدخلات
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("من فضلك اختر اسم مستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameComboBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("من فضلك أدخل كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(selectedGamePath))
                {
                    MessageBox.Show("من فضلك اختر مجلد اللعبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // التحقق من وجود مجلد اللعبة
                if (!Directory.Exists(selectedGamePath))
                {
                    statusLabel.Text = "✗ مجلد اللعبة غير موجود";
                    statusLabel.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
                    MessageBox.Show($"المجلد غير موجود: {selectedGamePath}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // التحقق من وجود ملفات الفورتنايت
                if (!VerifyGamePath(selectedGamePath))
                {
                    statusLabel.Text = "✗ ملفات اللعبة غير صحيحة";
                    statusLabel.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
                    MessageBox.Show("هذا المجلد لا يبدو أنه يحتوي على Fortnite\n\nتأكد من أن المجلد يحتوي على مجلد 'FortniteGame'", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            catch (Exception ex)
            {
                statusLabel.Text = $"✗ خطأ: {ex.Message}";
                statusLabel.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
                MessageBox.Show($"خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyGamePath(string path)
        {
            // تحقق من وجود مجلد FortniteGame
            string fortniteGamePath = Path.Combine(path, "FortniteGame");
            if (Directory.Exists(fortniteGamePath))
            {
                // تحقق من وجود الملف التنفيذي
                string[] possibleExes = {
                    Path.Combine(fortniteGamePath, "Binaries", "Win64", "FortniteClient-Win64-Shipping.exe"),
                    Path.Combine(fortniteGamePath, "Binaries", "Win64", "FortniteClient-Win64-Shipping_EOS.exe"),
                    Path.Combine(fortniteGamePath, "Binaries", "Win64", "FortniteLauncher.exe")
                };

                foreach (var exe in possibleExes)
                {
                    if (File.Exists(exe))
                        return true;
                }
            }

            return false;
        }

        private void SaveNewUser(string username)
        {
            try
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

                // إضافة المستخدم للقائمة
                if (!usernameComboBox.Items.Contains(username))
                {
                    usernameComboBox.Items.Insert(usernameComboBox.Items.Count - 1, username);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في حفظ المستخدم: {ex.Message}");
            }
        }
    }
}