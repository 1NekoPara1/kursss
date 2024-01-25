using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursss
{
    public partial class Atbash : Form
    {
        //private Dictionary<char, char> russianAlphabetMapping;
        //private Dictionary<char, char> englishAlphabetMapping;
        public Atbash()
        {
            InitializeComponent();

           /* russianAlphabetMapping = new Dictionary<char, char>()
            {
                {'А', 'Я'}, {'Б', 'Ю'}, {'В', 'Э'}, {'Г', 'Ь'}, {'Д', 'Ы'}, {'Е', 'Ъ'}, {'Ё', 'Щ'}, {'Ж', 'Ш'}, {'З', 'Ч'}, {'И', 'Ц'},
                {'Й', 'Х'}, {'К', 'Ф'}, {'Л', 'У'}, {'М', 'Т'}, {'Н', 'С'}, {'О', 'Р'}, {'П', 'П'}, {'Р', 'О'}, {'С', 'Н'}, {'Т', 'М'},
                {'У', 'Л'}, {'Ф', 'К'}, {'Х', 'Й'}, {'Ц', 'И'}, {'Ч', 'З'}, {'Ш', 'Ж'}, {'Щ', 'Ё'}, {'Ъ', 'Е'}, {'Ы', 'Д'}, {'Ь', 'Г'},
                {'Э', 'В'}, {'Ю', 'Б'}, {'Я', 'А'},
                {'а', 'я'}, {'б', 'ю'}, {'в', 'э'}, {'г', 'ь'}, {'д', 'ы'}, {'е', 'ъ'}, {'ё', 'щ'}, {'ж', 'ш'}, {'з', 'ч'}, {'и', 'ц'},
                {'й', 'х'}, {'к', 'ф'}, {'л', 'у'}, {'м', 'т'}, {'н', 'с'}, {'о', 'р'}, {'п', 'п'}, {'р', 'о'}, {'с', 'н'}, {'т', 'м'},
                {'у', 'л'}, {'ф', 'к'}, {'х', 'й'}, {'ц', 'и'}, {'ч', 'з'}, {'ш', 'ж'}, {'щ', 'ё'}, {'ъ', 'е'}, {'ы', 'д'}, {'ь', 'г'},
                {'э', 'в'}, {'ю', 'б'}, {'я', 'а'}
            };

            englishAlphabetMapping = new Dictionary<char, char>()
            {
                {'A', 'Z'}, {'B', 'Y'}, {'C', 'X'}, {'D', 'W'}, {'E', 'V'}, {'F', 'U'}, {'G', 'T'}, {'H', 'S'}, {'I', 'R'}, {'J', 'Q'},
                {'K', 'P'}, {'L', 'O'}, {'M', 'N'}, {'N', 'M'}, {'O', 'L'}, {'P', 'K'}, {'Q', 'J'}, {'R', 'I'}, {'S', 'H'}, {'T', 'G'},
                {'U', 'F'}, {'V', 'E'}, {'W', 'D'}, {'X', 'C'}, {'Y', 'B'}, {'Z', 'A'},
                {'a', 'z'}, {'b', 'y'}, {'c', 'x'}, {'d', 'w'}, {'e', 'v'}, {'f', 'u'}, {'g', 't'}, {'h', 's'}, {'i', 'r'}, {'j', 'q'},
                {'k', 'p'}, {'l', 'o'}, {'m', 'n'}, {'n', 'm'}, {'o', 'l'}, {'p', 'k'}, {'q', 'j'}, {'r', 'i'}, {'s', 'h'}, {'t', 'g'},
                {'u', 'f'}, {'v', 'e'}, {'w', 'd'}, {'x', 'c'}, {'y', 'b'}, {'z', 'a'}
            };*/
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

        private void buttonEncryption_Click(object sender, EventArgs e)
        {
            string Text = Decryption.Text;
            var Chifr = new AtbashShifer();
            decryptionResult.Text = Chifr.ChifrA(Text);
        }

        private void buttonDecryption_Click(object sender, EventArgs e)
        {
            string Text = Decryption.Text;
            var Chifr = new AtbashShifer();
            decryptionResult.Text = Chifr.ChifrA(Text);
        }
        /*private string EncryptionText(string inputText)
        {
            string Text = richTextBox1.Text;
            var Chifr = new CifrAtbash();
            richTextBoxOut.Text = Chifr.ChifrA(Text);
        }*/

        /*public string DecryptionText(string inputText)
        {
            string Text = Decryption.Text;
            var Chifr = new AtbashShifer();
            decryptionResult.Text = Chifr.ChifrA(Text);
        }*/

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

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = ".txt";
            savefile.Filter = "Test files|*.txt";
            if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK && savefile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName, true))
                {
                    sw.WriteLine(decryptionResult.Text);
                    sw.Close();
                }
            }
        }

        private void read_Click(object sender, EventArgs e)
        {
            OpenFileDialog readfile = new OpenFileDialog();
            if (readfile.ShowDialog() == DialogResult.OK)
            {
                Name = readfile.FileName;
                Decryption.Clear();
                Decryption.Text = File.ReadAllText(Name);
            }
        }
    }
}
