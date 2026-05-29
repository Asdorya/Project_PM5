using System;
using System.Linq;
using System.Windows.Forms;

namespace Equipment_rental
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label5.Cursor = Cursors.Hand;
            Load += MainForm_Load;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            RefreshUserState();
        }

        public void RefreshUserState()
        {
            bool isAuth = UserSession.IsAuthenticated;

            label2.Visible = !isAuth;
            labelUserLogin.Visible = isAuth;
            labelUserRole.Visible = isAuth;

            panelGuestActions.Visible = !isAuth;
            panelRentalActions.Visible = isAuth;

            pictureBox5.Visible = isAuth;
            pictureBox6.Visible = isAuth;

            if (isAuth)
            {
                pictureBox5.SendToBack();
                pictureBox6.SendToBack();
                panelRentalActions.BringToFront();

                labelUserLogin.Text = UserSession.UserLogin;
                labelUserRole.Text = UserRoleHelper.ToDbValue(UserSession.Role);
                labelWelcomeRent.Text = $"Здравствуйте, {UserSession.UserName}!";
                btnManageEquipment.Visible =
                    UserRoleHelper.CanCreate(UserSession.Role) ||
                    UserRoleHelper.CanUpdate(UserSession.Role);
            }
            else
            {
                labelUserLogin.Text = "";
                labelUserRole.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (UserSession.IsAuthenticated)
                return;

            OpenLoginForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (_, _) =>
            {
                RefreshUserState();
                Show();
            };
            loginForm.Show();
        }

        private void btnViewCatalog_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAuthenticated)
            {
                MessageBox.Show("Войдите в систему, чтобы просмотреть каталог.");
                return;
            }

            OpenEquipmentForm();
        }

        private void btnRentEquipment_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAuthenticated)
            {
                MessageBox.Show("Войдите в систему, чтобы оформить аренду.");
                return;
            }

            MessageBox.Show(
                "Выберите оборудование в каталоге и оформите заказ.\n" +
                "Нажмите «Каталог оборудования», чтобы выбрать позицию для аренды.",
                "Аренда оборудования",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            OpenEquipmentForm();
        }

        private void btnManageEquipment_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAuthenticated)
                return;

            OpenEquipmentForm();
        }

        private void OpenEquipmentForm()
        {
            EquipmentForm equipmentForm = new EquipmentForm();
            equipmentForm.FormClosed += (_, _) => RefreshUserState();
            equipmentForm.Show();
        }

        private void labelUserLogin_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAuthenticated)
                return;

            if (MessageBox.Show("Выйти из аккаунта?", "Выход",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            UserSession.Logout();
            RefreshUserState();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (UserSession.IsAuthenticated)
            {
                OpenEquipmentForm();
                return;
            }

            OpenLoginForm();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void labelWelcomeRent_Click(object sender, EventArgs e)
        {

        }
    }
}
