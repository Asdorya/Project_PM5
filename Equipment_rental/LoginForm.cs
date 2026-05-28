using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_rental
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

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
            Application.Exit();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (capcha.Text == "V4XBG")
            {
                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passField.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);



                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                    MessageBox.Show("Произошла ошибка");
            }

            else
            {
                MessageBox.Show("Неверная капча, повторите попытку");
                capcha.Text = "";
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
    }
}
