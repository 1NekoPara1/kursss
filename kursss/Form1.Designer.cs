﻿namespace kursss
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            registerLabel = new Label();
            buttonLogin = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 541);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Cursor = Cursors.Hand;
            registerLabel.Font = new Font("Zekton Rg", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            registerLabel.ForeColor = Color.White;
            registerLabel.Location = new Point(111, 513);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(177, 19);
            registerLabel.TabIndex = 6;
            registerLabel.Text = "Ещё нет аккаунта?";
            registerLabel.Click += registerLabel_Click;
            registerLabel.MouseEnter += registerLabel_MouseEnter;
            registerLabel.MouseLeave += registerLabel_MouseLeave;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(208, 183, 15);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 11, 75);
            buttonLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 10, 74);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Zekton Rg", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(121, 453);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(153, 57);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Zekton Rg", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(138, 288);
            passField.Name = "passField";
            passField.Size = new Size(226, 40);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            passField.TextChanged += passField_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(24, 288);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Zekton Rg", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(138, 160);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(226, 72);
            loginField.TabIndex = 2;
            loginField.TextChanged += loginField_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(24, 160);
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
            panel2.Size = new Size(401, 118);
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
            closeButton.Location = new Point(373, 0);
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
            label1.Location = new Point(0, 26);
            label1.Name = "label1";
            label1.Size = new Size(398, 67);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 541);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox loginField;
        private Button buttonLogin;
        private TextBox passField;
        private PictureBox pictureBox2;
        private Label registerLabel;
    }
}