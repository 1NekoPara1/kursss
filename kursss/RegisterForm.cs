using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursss
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            UserSurnameField.Text = "Введите фамилию";
            UserSurnameField.ForeColor = Color.Gray;

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;

            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;

            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void UserSurnameField_Enter(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "Введите фамилию")
            {
                UserSurnameField.Text = "";
                UserSurnameField.ForeColor = Color.Black;
            }
        }

        private void UserSurnameField_Leave(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "")
            {
                UserSurnameField.Text = "Введите фамилию";
                UserSurnameField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (UserSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }

        public Boolean isUserExists()
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
                MessageBox.Show("Такой логин уже зарегистрирован в системе, введите другой");
                return true;
            }
            else
                return false;
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void registerLabel_MouseEnter(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.Green;
        }

        private void registerLabel_MouseLeave(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.White;
        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {
            userNameField.MaxLength = 10;
            string block = "*-;'";
            foreach (char c in userNameField.Text)
            {
                foreach (char c2 in block)
                {
                    if (c == c2)
                    {
                        MessageBox.Show("Введён запрещённый символ");
                        userNameField.Clear();
                    }
                }
            }
        }

        private void UserSurnameField_TextChanged(object sender, EventArgs e)
        {
            UserSurnameField.MaxLength = 10;
            string block = "*-;'";
            foreach (char c in UserSurnameField.Text)
            {
                foreach (char c2 in block)
                {
                    if (c == c2)
                    {
                        MessageBox.Show("Введён запрещённый символ");
                        UserSurnameField.Clear();
                    }
                }
            }
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {
            loginField.MaxLength = 10;
            string block = "*-;'";
            foreach (char c in loginField.Text)
            {
                foreach (char c2 in block)
                {
                    if (c == c2)
                    {
                        MessageBox.Show("Введён запрещённый символ");
                        loginField.Clear();
                    }
                }
            }
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
            passField.MaxLength = 10;
            string block = "*-;'";
            foreach (char c in passField.Text)
            {
                foreach (char c2 in block)
                {
                    if (c == c2)
                    {
                        MessageBox.Show("Введён запрещённый символ");
                        passField.Clear();
                    }
                }
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
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
