namespace Equipment_rental
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            labelUserRole = new Label();
            labelUserLogin = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panelRentalActions = new Panel();
            btnManageEquipment = new Button();
            btnRentEquipment = new Button();
            btnViewCatalog = new Button();
            labelRentalDescription = new Label();
            labelWelcomeRent = new Label();
            panelGuestActions = new Panel();
            label13 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panelRentalActions.SuspendLayout();
            panelGuestActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGoldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(204, 327);
            button1.Name = "button1";
            button1.Size = new Size(561, 72);
            button1.TabIndex = 4;
            button1.Text = "Войти чтобы арендовать оборудование →\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(labelUserRole);
            panel1.Controls.Add(labelUserLogin);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 72);
            panel1.TabIndex = 2;
            // 
            // labelUserRole
            // 
            labelUserRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUserRole.BackColor = Color.DarkGoldenrod;
            labelUserRole.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserRole.ForeColor = Color.White;
            labelUserRole.Location = new Point(870, 38);
            labelUserRole.Name = "labelUserRole";
            labelUserRole.Size = new Size(140, 20);
            labelUserRole.TabIndex = 14;
            labelUserRole.Text = "user";
            labelUserRole.TextAlign = ContentAlignment.TopRight;
            labelUserRole.Visible = false;
            // 
            // labelUserLogin
            // 
            labelUserLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUserLogin.BackColor = Color.DarkGoldenrod;
            labelUserLogin.BorderStyle = BorderStyle.FixedSingle;
            labelUserLogin.Cursor = Cursors.Hand;
            labelUserLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelUserLogin.ForeColor = Color.White;
            labelUserLogin.Location = new Point(823, 9);
            labelUserLogin.Name = "labelUserLogin";
            labelUserLogin.Padding = new Padding(4, 2, 4, 2);
            labelUserLogin.Size = new Size(190, 26);
            labelUserLogin.TabIndex = 13;
            labelUserLogin.Text = "login";
            labelUserLogin.TextAlign = ContentAlignment.MiddleRight;
            labelUserLogin.Visible = false;
            labelUserLogin.Click += labelUserLogin_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkGoldenrod;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(107, 15);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 12;
            label6.Text = "Тарифы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGoldenrod;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(195, 15);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 11;
            label5.Text = "Оборудование";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGoldenrod;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(340, 15);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 10;
            label4.Text = "FAQ";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkGoldenrod;
            pictureBox3.Image = Properties.Resources.toolbox_18936236;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGoldenrod;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(954, 12);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 1;
            label2.Text = "Войти";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkGoldenrod;
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Calibri", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1025, 72);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(panelGuestActions);
            panel2.Controls.Add(panelRentalActions);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 577);
            panel2.TabIndex = 3;
            // 
            // panelRentalActions
            // 
            panelRentalActions.BackColor = Color.Transparent;
            panelRentalActions.Controls.Add(btnManageEquipment);
            panelRentalActions.Controls.Add(btnRentEquipment);
            panelRentalActions.Controls.Add(btnViewCatalog);
            panelRentalActions.Controls.Add(labelRentalDescription);
            panelRentalActions.Controls.Add(labelWelcomeRent);
            panelRentalActions.Location = new Point(140, 300);
            panelRentalActions.Name = "panelRentalActions";
            panelRentalActions.Size = new Size(750, 200);
            panelRentalActions.TabIndex = 16;
            panelRentalActions.Visible = false;
            // 
            // btnManageEquipment
            // 
            btnManageEquipment.BackColor = Color.Black;
            btnManageEquipment.FlatStyle = FlatStyle.Flat;
            btnManageEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnManageEquipment.ForeColor = Color.White;
            btnManageEquipment.Location = new Point(510, 120);
            btnManageEquipment.Name = "btnManageEquipment";
            btnManageEquipment.Size = new Size(220, 48);
            btnManageEquipment.TabIndex = 4;
            btnManageEquipment.Text = "Управление";
            btnManageEquipment.UseVisualStyleBackColor = false;
            btnManageEquipment.Visible = false;
            btnManageEquipment.Click += btnManageEquipment_Click;
            // 
            // btnRentEquipment
            // 
            btnRentEquipment.BackColor = Color.SaddleBrown;
            btnRentEquipment.FlatStyle = FlatStyle.Flat;
            btnRentEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRentEquipment.ForeColor = Color.White;
            btnRentEquipment.Location = new Point(265, 120);
            btnRentEquipment.Name = "btnRentEquipment";
            btnRentEquipment.Size = new Size(220, 48);
            btnRentEquipment.TabIndex = 3;
            btnRentEquipment.Text = "Заказать в аренду";
            btnRentEquipment.UseVisualStyleBackColor = false;
            btnRentEquipment.Click += btnRentEquipment_Click;
            // 
            // btnViewCatalog
            // 
            btnViewCatalog.BackColor = Color.DarkGoldenrod;
            btnViewCatalog.FlatStyle = FlatStyle.Flat;
            btnViewCatalog.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewCatalog.ForeColor = Color.White;
            btnViewCatalog.Location = new Point(20, 120);
            btnViewCatalog.Name = "btnViewCatalog";
            btnViewCatalog.Size = new Size(220, 48);
            btnViewCatalog.TabIndex = 2;
            btnViewCatalog.Text = "Каталог оборудования";
            btnViewCatalog.UseVisualStyleBackColor = false;
            btnViewCatalog.Click += btnViewCatalog_Click;
            // 
            // labelRentalDescription
            // 
            labelRentalDescription.BackColor = Color.Transparent;
            labelRentalDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRentalDescription.ForeColor = Color.FromArgb(64, 64, 64);
            labelRentalDescription.Location = new Point(20, 48);
            labelRentalDescription.Name = "labelRentalDescription";
            labelRentalDescription.Size = new Size(710, 60);
            labelRentalDescription.TabIndex = 1;
            labelRentalDescription.Text = "Выберите оборудование в каталоге и оформите заказ в аренду. Доступны инструменты, техника и спецоборудование на любой срок.";
            // 
            // labelWelcomeRent
            // 
            labelWelcomeRent.AutoSize = true;
            labelWelcomeRent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWelcomeRent.ForeColor = Color.SaddleBrown;
            labelWelcomeRent.Location = new Point(20, 8);
            labelWelcomeRent.Name = "labelWelcomeRent";
            labelWelcomeRent.Size = new Size(357, 32);
            labelWelcomeRent.TabIndex = 0;
            labelWelcomeRent.Text = "Здравствуйте, пользователь!";
            labelWelcomeRent.Click += labelWelcomeRent_Click;
            // 
            // panelGuestActions
            // 
            panelGuestActions.Controls.Add(label13);
            panelGuestActions.Controls.Add(label9);
            panelGuestActions.Controls.Add(label8);
            panelGuestActions.Controls.Add(label7);
            panelGuestActions.Controls.Add(label3);
            panelGuestActions.Controls.Add(button1);
            panelGuestActions.Dock = DockStyle.Fill;
            panelGuestActions.Location = new Point(0, 0);
            panelGuestActions.Name = "panelGuestActions";
            panelGuestActions.Size = new Size(1025, 577);
            panelGuestActions.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(476, 421);
            label13.Name = "label13";
            label13.Size = new Size(31, 30);
            label13.TabIndex = 15;
            label13.Text = "\\/\r\n";
            label13.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(370, 208);
            label9.Name = "label9";
            label9.Size = new Size(234, 47);
            label9.TabIndex = 14;
            label9.Text = "Уже сегодня";
            label9.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.SaddleBrown;
            label8.Location = new Point(277, 161);
            label8.Name = "label8";
            label8.Size = new Size(424, 47);
            label8.TabIndex = 13;
            label8.Text = "Мощное оборудование";
            label8.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(395, 114);
            label7.Name = "label7";
            label7.Size = new Size(170, 47);
            label7.TabIndex = 12;
            label7.Text = "Арендуй";
            label7.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(302, 264);
            label3.Name = "label3";
            label3.Size = new Size(383, 60);
            label3.TabIndex = 11;
            label3.Text = "Регистрируйся сегодня - пользуйся \r\n оборудованием уже завтра";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.vecteezy_computer_icons_with_white_background_8958610_nobg;
            pictureBox5.Location = new Point(0, 74);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(536, 397);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.vecteezy_computer_icons_with_white_background_8958610_nobg;
            pictureBox6.Location = new Point(476, 71);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(549, 397);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGoldenrod;
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 468);
            panel3.Name = "panel3";
            panel3.Size = new Size(1025, 109);
            panel3.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DarkGoldenrod;
            pictureBox4.Image = Properties.Resources.mark_10093833;
            pictureBox4.Location = new Point(755, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkGoldenrod;
            pictureBox2.Image = Properties.Resources.headphone_18080416;
            pictureBox2.Location = new Point(463, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGoldenrod;
            pictureBox1.Image = Properties.Resources.delivery_truck_4111303;
            pictureBox1.Location = new Point(195, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DarkGoldenrod;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.White;
            label12.Location = new Point(711, 66);
            label12.Name = "label12";
            label12.Size = new Size(156, 21);
            label12.TabIndex = 15;
            label12.Text = "Гарантия возврата";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkGoldenrod;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.White;
            label11.Location = new Point(395, 66);
            label11.Name = "label11";
            label11.Size = new Size(205, 21);
            label11.TabIndex = 14;
            label11.Text = "Техническая поддержка";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGoldenrod;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.White;
            label10.Location = new Point(146, 66);
            label10.Name = "label10";
            label10.Size = new Size(151, 21);
            label10.TabIndex = 13;
            label10.Text = "Быстрая доставка";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 577);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panelRentalActions.ResumeLayout(false);
            panelRentalActions.PerformLayout();
            panelGuestActions.ResumeLayout(false);
            panelGuestActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private Label label9;
        private Label label8;
        private Label label12;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label13;
        private Label labelUserLogin;
        private Label labelUserRole;
        private Panel panelGuestActions;
        private Panel panelRentalActions;
        private Label labelWelcomeRent;
        private Label labelRentalDescription;
        private Button btnViewCatalog;
        private Button btnRentEquipment;
        private Button btnManageEquipment;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}