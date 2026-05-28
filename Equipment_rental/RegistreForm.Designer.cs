namespace Equipment_rental
{
    partial class RegistreForm
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
            CloseButton = new Label();
            label1 = new Label();
            panel2 = new Panel();
            userNameField = new TextBox();
            userSurnameField = new TextBox();
            eyeBox = new PictureBox();
            buttonRegister = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 70);
            panel1.TabIndex = 2;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.BackColor = Color.DarkGoldenrod;
            CloseButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(401, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(30, 32);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click_1;
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
            label1.Size = new Size(434, 70);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(userNameField);
            panel2.Controls.Add(userSurnameField);
            panel2.Controls.Add(eyeBox);
            panel2.Controls.Add(buttonRegister);
            panel2.Controls.Add(passField);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(loginField);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 450);
            panel2.TabIndex = 3;
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Calibri", 24F);
            userNameField.Location = new Point(88, 105);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(275, 44);
            userNameField.TabIndex = 7;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // userSurnameField
            // 
            userSurnameField.Font = new Font("Calibri", 24F);
            userSurnameField.Location = new Point(88, 177);
            userSurnameField.Multiline = true;
            userSurnameField.Name = "userSurnameField";
            userSurnameField.Size = new Size(275, 44);
            userSurnameField.TabIndex = 6;
            userSurnameField.Enter += userSurnameField_Enter;
            userSurnameField.Leave += userSurnameField_Leave;
            // 
            // eyeBox
            // 
            eyeBox.BackColor = Color.Transparent;
            eyeBox.Image = Properties.Resources.eye_3917052;
            eyeBox.Location = new Point(376, 326);
            eyeBox.Name = "eyeBox";
            eyeBox.Size = new Size(33, 26);
            eyeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeBox.TabIndex = 5;
            eyeBox.TabStop = false;
            eyeBox.MouseLeave += eyeBox_MouseLeave;
            eyeBox.MouseMove += eyeBox_MouseMove;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.DarkGoldenrod;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(114, 387);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(230, 44);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "Войти";
            buttonRegister.UseVisualStyleBackColor = false;
            // 
            // passField
            // 
            passField.BackColor = Color.White;
            passField.Font = new Font("Calibri", 24F);
            passField.Location = new Point(88, 316);
            passField.Name = "passField";
            passField.Size = new Size(275, 47);
            passField.TabIndex = 3;
            passField.UseSystemPasswordChar = true;
            passField.Enter += passField_Enter;
            passField.Leave += passField_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.password_14562503;
            pictureBox2.Location = new Point(20, 316);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Calibri", 24F);
            loginField.Location = new Point(88, 247);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(275, 44);
            loginField.TabIndex = 1;
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user_456283;
            pictureBox1.Location = new Point(20, 247);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // RegistreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "RegistreForm";
            Text = "RegistreForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eyeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label CloseButton;
        private Panel panel2;
        private PictureBox eyeBox;
        private Button buttonRegister;
        private TextBox passField;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox userNameField;
        private TextBox userSurnameField;
    }
}