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
        private Process gameProcess;

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
            versionLabel.Text = "الإصدار: 14.60 (Legacy)";
            readyLabel.Text = "الحالة: جاهز للتشغيل ✓";
            readyLabel.ForeColor = System.Drawing.Color.FromArgb(74, 222, 128);
            playersLabel.Text = "وضع اللعبة: سيزن قديم";
            serverStatusLabel.Text = "تشغيل مباشر - بدون Epic Games";
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

                // البحث عن ملف Fortnite التنفيذي
                string[] possiblePaths = {
                    Path.Combine(gamePath, "FortniteGame", "Binaries", "Win64", "FortniteClient-Win64-Shipping.exe"),
                    Path.Combine(gamePath, "FortniteGame", "Binaries", "Win64", "FortniteClient-Win64-Shipping_EOS.exe"),
                    Path.Combine(gamePath, "FortniteGame", "Binaries", "Win64", "FortniteLauncher.exe"),
                    Path.Combine(gamePath, "Binaries", "Win64", "FortniteClient-Win64-Shipping.exe")
                };

                string executablePath = null;
                foreach (var path in possiblePaths)
                {
                    if (File.Exists(path))
                    {
                        executablePath = path;
                        break;
                    }
                }

                if (executablePath == null)
                {
                    statusMessageLabel.Text = "✗ لم يتم العثور على ملف اللعبة";
                    statusMessageLabel.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
                    MessageBox.Show(
                        $"لم يتم العثور على ملف Fortnite القابل للتشغيل\n\nالمسار المختار:\n{gamePath}\n\nتأكد من أن المسار صحيح وأن المجلد يحتوي على FortniteGame",
                        "خطأ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // تشغيل اللعبة مباشرة بدون Epic Games
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = executablePath,
                    UseShellExecute = true,
                    WorkingDirectory = Path.GetDirectoryName(executablePath)
                };

                gameProcess = Process.Start(startInfo);
                statusMessageLabel.Text = "✓ تم تشغيل اللعبة بنجاح!";
                statusMessageLabel.ForeColor = System.Drawing.Color.FromArgb(74, 222, 128);

                // انتظر قليلاً ثم اغلق النافذة
                System.Threading.Thread.Sleep(3000);
                this.Close();
            }
            catch (Exception ex)
            {
                statusMessageLabel.Text = $"✗ خطأ: {ex.Message}";
                statusMessageLabel.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
                MessageBox.Show($"خطأ في تشغيل اللعبة:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // قتل عملية اللعبة إن كانت تعمل
            try
            {
                if (gameProcess != null && !gameProcess.HasExited)
                {
                    gameProcess.Kill();
                }
            }
            catch { }

            // العودة إلى نافذة التسجيل
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            try
            {
                if (gameProcess != null && !gameProcess.HasExited)
                {
                    gameProcess.Kill();
                }
            }
            catch { }
        }
    }
}