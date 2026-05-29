namespace Equipment_rental
{
    partial class LoginForm
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            capcha = new TextBox();
            pictureCapcha = new PictureBox();
            RegistrLabel = new Label();
            passField = new TextBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCapcha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 72);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGoldenrod;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(398, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 32);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
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
            label1.Size = new Size(434, 72);
            label1.TabIndex = 2;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(capcha);
            panel2.Controls.Add(pictureCapcha);
            panel2.Controls.Add(RegistrLabel);
            panel2.Controls.Add(passField);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(loginField);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 402);
            panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.refresh_875100;
            pictureBox5.Location = new Point(266, 192);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(106, 168);
            label3.Name = "label3";
            label3.Size = new Size(208, 21);
            label3.TabIndex = 10;
            label3.Text = "Введите текст с картинки";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // capcha
            // 
            capcha.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            capcha.ForeColor = Color.Black;
            capcha.Location = new Point(106, 245);
            capcha.Multiline = true;
            capcha.Name = "capcha";
            capcha.Size = new Size(208, 38);
            capcha.TabIndex = 9;
            capcha.TextChanged += textBox1_TextChanged;
            capcha.Enter += capcha_Enter;
            capcha.Leave += capcha_Leave;
            // 
            // pictureCapcha
            // 
            pictureCapcha.BackColor = Color.White;
            pictureCapcha.BorderStyle = BorderStyle.FixedSingle;
            pictureCapcha.Location = new Point(106, 192);
            pictureCapcha.Name = "pictureCapcha";
            pictureCapcha.Size = new Size(143, 47);
            pictureCapcha.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCapcha.TabIndex = 8;
            pictureCapcha.TabStop = false;
            // 
            // RegistrLabel
            // 
            RegistrLabel.AutoSize = true;
            RegistrLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegistrLabel.ForeColor = Color.DarkGray;
            RegistrLabel.Location = new Point(148, 373);
            RegistrLabel.Name = "RegistrLabel";
            RegistrLabel.Size = new Size(120, 21);
            RegistrLabel.TabIndex = 7;
            RegistrLabel.Text = "Нет аккаунта?";
            RegistrLabel.TextAlign = ContentAlignment.BottomCenter;
            RegistrLabel.Click += label3_Click;
            RegistrLabel.MouseEnter += RegistrLabel_Enter;
            RegistrLabel.MouseLeave += RegistrLabel_Leave;
            // 
            // passField
            // 
            passField.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passField.Location = new Point(91, 95);
            passField.Name = "passField";
            passField.Size = new Size(278, 43);
            passField.TabIndex = 6;
            passField.UseSystemPasswordChar = true;
            passField.TextChanged += passField_TextChanged_1;
            passField.Enter += passField_Enter;
            passField.Leave += passField_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.eye_3917052;
            pictureBox3.Location = new Point(383, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            pictureBox3.MouseMove += pictureBox3_MouseMove;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGoldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(70, 326);
            button1.Name = "button1";
            button1.Size = new Size(267, 44);
            button1.TabIndex = 4;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.password_14562503;
            pictureBox2.Location = new Point(27, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.Location = new Point(91, 23);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(278, 44);
            loginField.TabIndex = 1;
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user_456283;
            pictureBox1.Location = new Point(27, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 474);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCapcha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox passField;
        private Label RegistrLabel;
        private Label label3;
        private TextBox capcha;
        private PictureBox pictureCapcha;
        private PictureBox pictureBox5;
        private Label label4;
    }
}