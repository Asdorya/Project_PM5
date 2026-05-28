using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Equipment_rental
{
    public partial class RegistreForm : Form
    {
        public RegistreForm()
        {
            InitializeComponent();


            userNameField.Text = "Введите ФИО";
            userNameField.ForeColor = Color.Gray;


            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;

            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
            if (passField.Text == "Введите пароль")
            {
                passField.UseSystemPasswordChar = false;
            }
            passField2.Text = "Подтвердите пароль";
            passField2.ForeColor = Color.Gray;
            if (passField2.Text == "Подтвердите пароль")
            {
                passField2.UseSystemPasswordChar = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите ФИО")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите ФИО";
                userNameField.ForeColor = Color.Gray;
            }
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


        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void eyeBox_MouseMove(object sender, MouseEventArgs e)
        {
            passField.UseSystemPasswordChar = false;
        }

        private void eyeBox_MouseLeave(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = true;
        }

        private void eyeBox2_MouseMove(object sender, MouseEventArgs e)
        {
            passField2.UseSystemPasswordChar = false;
        }

        private void eyeBox2_MouseLeave(object sender, EventArgs e)
        {
            passField2.UseSystemPasswordChar = true;
        }

        private void passField2_Enter(object sender, EventArgs e)
        {
            if (passField2.Text == "Подтвердите пароль")
            {
                passField2.UseSystemPasswordChar = true;
                passField2.Text = "";
                passField2.ForeColor = Color.Black;

            }
        }

        private void passField2_Leave(object sender, EventArgs e)
        {
            if (passField2.Text == "")
            {
                passField2.UseSystemPasswordChar = false;
                passField2.Text = "Подтвердите пароль";
                passField2.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите ФИО")
            {
                MessageBox.Show("Введите ФИО");
                return;
            }
            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (chechUser())
                return;

            if (passField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (passField2.Text == "Подтвердите пароль")
            {
                MessageBox.Show("Подтвердите пароль");
                return;
            }

            if (passField.Text != passField2.Text)
            { MessageBox.Show("Пароли не совпадают"); return; }


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Name`, `login`, `password`) VALUES (@name, @login, @pass)", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            { MessageBox.Show("Аккаунт успешно создан"); }

            else { MessageBox.Show("Ошибка при создании аккаунта, повторите попытку"); }

            db.closeConnection();

        }



        public Boolean chechUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой логин");
                return true;
            }
            else
                return false;

        }

        private void RegistrLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        private void RegistrLabel_Enter(object sender, EventArgs e)
        {
            RegistrLabel.ForeColor = Color.Gray;
        }

        private void RegistrLabel_Leave(object sender, EventArgs e)
        {
            RegistrLabel.ForeColor = Color.DarkGray;
        }
    }
}
