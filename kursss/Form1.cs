using MySql.Data.MySqlClient;
using System.Data;

namespace kursss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 72);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` =@uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Atbash atbash = new Atbash();
                atbash.Show();
            }
            else
                MessageBox.Show("Некорректные или пустые поля на форме");
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void registerLabel_MouseEnter(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.Green;
        }

        private void registerLabel_MouseLeave(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.White;
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
    }
}