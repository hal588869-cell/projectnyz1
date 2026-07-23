using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace projectnyz1
{
    public partial class GameWindow : Form
    {
        private string username;
        private string gamePath;

        public GameWindow(string username, string gamePath)
        {
            InitializeComponent();
            this.username = username;
            this.gamePath = gamePath;
            ApplyDarkTheme();
            SetupUI();
        }

        private void SetupUI()
        {
            usernameDisplayLabel.Text = $"أهلاً بك يا {username}";
            gameStatusLabel.Text = "Fortnite Chapter 2 - Season 4";
            versionLabel.Text = "الإصدار: 14.60";
            readyLabel.Text = "الحالة: جاهز للتشغيل";
            readyLabel.ForeColor = System.Drawing.Color.FromArgb(74, 222, 128);
            playersLabel.Text = "عدد اللاعبين: 0";
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = System.Drawing.Color.FromArgb(10, 14, 39);
            this.ForeColor = System.Drawing.Color.White;
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                statusMessageLabel.Text = "جاري تشغيل اللعبة...";
                statusMessageLabel.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
                Application.DoEvents();

                // البحث عن ملف اللعبة
                string[] gameExecutables = {
                    Path.Combine(gamePath, "FortniteGame", "Binaries", "Win64", "FortniteClient-Win64-Shipping.exe"),
                    Path.Combine(gamePath, "FortniteGame", "Binaries", "Win64", "FortniteLauncher.exe"),
                    Path.Combine(gamePath, "Launcher.exe")
                };

                string executablePath = null;
                foreach (var exe in gameExecutables)
                {
                    if (File.Exists(exe))
                    {
                        executablePath = exe;
                        break;
                    }
                }

                if (executablePath == null)
                {
                    statusMessageLabel.Text = "لم يتم العثور على ملف اللعبة";
                    statusMessageLabel.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
                    return;
                }

                // تشغيل اللعبة
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = executablePath,
                    UseShellExecute = true
                };

                Process.Start(startInfo);
                statusMessageLabel.Text = "تم تشغيل اللعبة بنجاح!";
                statusMessageLabel.ForeColor = System.Drawing.Color.FromArgb(74, 222, 128);

                // إغلاق النافذة بعد ثانيتين
                System.Threading.Thread.Sleep(2000);
                this.Close();
            }
            catch (Exception ex)
            {
                statusMessageLabel.Text = $"خطأ: {ex.Message}";
                statusMessageLabel.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}