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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label5.Cursor = Cursors.Hand;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (UserSession.IsAuthenticated)
            {
                EquipmentForm equipmentForm = new EquipmentForm();
                equipmentForm.Show();
                return;
            }

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (_, _) => Show();
            loginForm.Show();
        }
    }
}
