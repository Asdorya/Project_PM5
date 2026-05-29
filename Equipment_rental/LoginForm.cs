using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Equipment_rental
{
    public partial class LoginForm : Form
    {
        private const int MaxCaptchaAttempts = 3;
        private const int LockoutSeconds = 30;

        private string _captchaCode = "";
        private int _failedCaptchaAttempts;
        private DateTime _lockoutUntil = DateTime.MinValue;
        private readonly System.Windows.Forms.Timer _lockoutTimer;

        public LoginForm()
        {
            InitializeComponent();

            _lockoutTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            _lockoutTimer.Tick += LockoutTimer_Tick;

            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;

            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
            if (passField.Text == "Введите пароль")
            {
                passField.UseSystemPasswordChar = false;
            }
            capcha.Text = "Введите капчу";
            capcha.ForeColor = Color.Gray;

            RefreshCaptcha();
        }

        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.UseSystemPasswordChar = true;
                passField.Text = "";
                passField.ForeColor = Color.Black;

            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.UseSystemPasswordChar = false;
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }
        private void capcha_Enter(object sender, EventArgs e)
        {
            if (capcha.Text == "Введите капчу")
            {
                capcha.Text = "";
                capcha.ForeColor = Color.Black;
            }
        }

        private void capcha_Leave(object sender, EventArgs e)
        {
            if (capcha.Text == "")
            {
                capcha.Text = "Введите капчу";
                capcha.ForeColor = Color.Gray;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsLockedOut())
            {
                MessageBox.Show($"Вход заблокирован. Повторите через {GetLockoutRemainingSeconds()} сек.");
                return;
            }

            if (capcha.Text == "Введите капчу" || string.IsNullOrWhiteSpace(capcha.Text))
            {
                MessageBox.Show("Введите текст с картинки");
                return;
            }

            if (!string.Equals(capcha.Text.Trim(), _captchaCode, StringComparison.OrdinalIgnoreCase))
            {
                _failedCaptchaAttempts++;
                MessageBox.Show("Неверная капча, повторите попытку");
                RefreshCaptcha();

                if (_failedCaptchaAttempts >= MaxCaptchaAttempts)
                    StartLockout();
                return;
            }

            _failedCaptchaAttempts = 0;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0
                && PasswordHasher.VerifyPassword(passField.Text, table.Rows[0]["password"].ToString()!))
            {
                DataRow userRow = table.Rows[0];
                string roleValue = userRow.Table.Columns.Contains("role")
                    ? userRow["role"]?.ToString()
                    : UserRoleHelper.UserDbValue;

                UserSession.SignIn(
                    Convert.ToInt32(userRow["id"]),
                    userRow["Name"].ToString() ?? "",
                    loginField.Text,
                    UserRoleHelper.FromDbValue(roleValue));

                MainForm? mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm == null)
                {
                    mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    mainForm.Show();
                    mainForm.RefreshUserState();
                }

                Close();
            }
            else
            {
                MessageBox.Show("Произошла ошибка");
                RefreshCaptcha();
            }
        }


        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }


        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            passField.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = true;
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistreForm registerForm = new RegistreForm();
            registerForm.Show();
        }


        private void RegistrLabel_Enter(object sender, EventArgs e)
        {
            RegistrLabel.ForeColor = Color.Gray;
        }

        private void RegistrLabel_Leave(object sender, EventArgs e)
        {
            RegistrLabel.ForeColor = Color.DarkGray;
        }

        private void passField_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (IsLockedOut())
            {
                MessageBox.Show($"Вход заблокирован. Повторите через {GetLockoutRemainingSeconds()} сек.");
                return;
            }

            RefreshCaptcha();
        }

        private void RefreshCaptcha()
        {
            _captchaCode = CaptchaGenerator.GenerateCode();
            var oldImage = pictureCapcha.Image;
            pictureCapcha.Image = CaptchaGenerator.CreateImage(
                _captchaCode,
                pictureCapcha.Width,
                pictureCapcha.Height);
            oldImage?.Dispose();

            capcha.Text = "";
            capcha.ForeColor = Color.Black;
        }

        private void StartLockout()
        {
            _lockoutUntil = DateTime.Now.AddSeconds(LockoutSeconds);
            _failedCaptchaAttempts = 0;
            SetLoginControlsEnabled(false);
            button1.Text = $"Заблокировано ({LockoutSeconds} с)";
            _lockoutTimer.Start();
            MessageBox.Show($"Слишком много неверных попыток. Вход заблокирован на {LockoutSeconds} секунд.");
        }

        private void LockoutTimer_Tick(object? sender, EventArgs e)
        {
            int remaining = GetLockoutRemainingSeconds();
            if (remaining <= 0)
            {
                EndLockout();
                return;
            }

            button1.Text = $"Заблокировано ({remaining} с)";
        }

        private void EndLockout()
        {
            _lockoutTimer.Stop();
            _lockoutUntil = DateTime.MinValue;
            SetLoginControlsEnabled(true);
            button1.Text = "Войти";
            RefreshCaptcha();
        }

        private bool IsLockedOut() => DateTime.Now < _lockoutUntil;

        private int GetLockoutRemainingSeconds() =>
            Math.Max(0, (int)Math.Ceiling((_lockoutUntil - DateTime.Now).TotalSeconds));

        private void SetLoginControlsEnabled(bool enabled)
        {
            button1.Enabled = enabled;
            loginField.Enabled = enabled;
            passField.Enabled = enabled;
            capcha.Enabled = enabled;
            pictureBox5.Enabled = enabled;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _lockoutTimer.Stop();
            _lockoutTimer.Dispose();
            pictureCapcha.Image?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
