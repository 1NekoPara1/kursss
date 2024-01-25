namespace kursss
{
    partial class RegisterForm
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
            registerLabel = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            UserSurnameField = new TextBox();
            userNameField = new TextBox();
            buttonRegister = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(UserSurnameField);
            panel1.Controls.Add(userNameField);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 546);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Cursor = Cursors.Hand;
            registerLabel.Font = new Font("Zekton Rg", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            registerLabel.ForeColor = Color.White;
            registerLabel.Location = new Point(370, 461);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(158, 19);
            registerLabel.TabIndex = 10;
            registerLabel.Text = "Авторизоваться";
            registerLabel.Click += registerLabel_Click;
            registerLabel.MouseEnter += registerLabel_MouseEnter;
            registerLabel.MouseLeave += registerLabel_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.name;
            pictureBox4.Location = new Point(17, 143);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(74, 72);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.surname;
            pictureBox3.Location = new Point(454, 143);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 81);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // UserSurnameField
            // 
            UserSurnameField.Font = new Font("Zekton Rg", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            UserSurnameField.Location = new Point(567, 159);
            UserSurnameField.Multiline = true;
            UserSurnameField.Name = "UserSurnameField";
            UserSurnameField.Size = new Size(226, 49);
            UserSurnameField.TabIndex = 7;
            UserSurnameField.TextChanged += UserSurnameField_TextChanged;
            UserSurnameField.Enter += UserSurnameField_Enter;
            UserSurnameField.Leave += UserSurnameField_Leave;
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Zekton Rg", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            userNameField.ForeColor = Color.Black;
            userNameField.Location = new Point(131, 159);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(226, 49);
            userNameField.TabIndex = 6;
            userNameField.TextChanged += userNameField_TextChanged;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(208, 183, 15);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 11, 75);
            buttonRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 10, 74);
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Zekton Rg", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(242, 370);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(398, 57);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Zekton Rg", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(567, 239);
            passField.Name = "passField";
            passField.Size = new Size(226, 33);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            passField.TextChanged += passField_TextChanged;
            passField.Enter += passField_Enter;
            passField.Leave += passField_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(454, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Zekton Rg", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(131, 239);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(226, 49);
            loginField.TabIndex = 2;
            loginField.TextChanged += loginField_TextChanged;
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(17, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 134, 0);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 118);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(824, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(26, 28);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // label1
            // 
            label1.Font = new Font("Zekton Rg", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(242, 24);
            label1.Name = "label1";
            label1.Size = new Size(398, 67);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 545);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRegister;
        private TextBox passField;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private TextBox userNameField;
        private TextBox UserSurnameField;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label registerLabel;
    }
}