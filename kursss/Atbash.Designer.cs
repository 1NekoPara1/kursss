namespace kursss
{
    partial class Atbash
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
            read = new Button();
            save = new Button();
            decryptionResult = new TextBox();
            Decryption = new TextBox();
            buttonDecryption = new Button();
            buttonEncryption = new Button();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(read);
            panel1.Controls.Add(save);
            panel1.Controls.Add(decryptionResult);
            panel1.Controls.Add(Decryption);
            panel1.Controls.Add(buttonDecryption);
            panel1.Controls.Add(buttonEncryption);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 571);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // read
            // 
            read.Cursor = Cursors.Hand;
            read.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 11, 65);
            read.FlatAppearance.MouseOverBackColor = Color.FromArgb(91, 7, 37);
            read.FlatStyle = FlatStyle.Flat;
            read.Font = new Font("Zekton Rg", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            read.ForeColor = Color.FromArgb(248, 25, 105);
            read.Location = new Point(554, 497);
            read.Name = "read";
            read.Size = new Size(214, 46);
            read.TabIndex = 9;
            read.Text = "Читать из файла";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // save
            // 
            save.Cursor = Cursors.Hand;
            save.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 11, 65);
            save.FlatAppearance.MouseOverBackColor = Color.FromArgb(91, 7, 37);
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Zekton Rg", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            save.ForeColor = Color.FromArgb(248, 25, 105);
            save.Location = new Point(106, 497);
            save.Name = "save";
            save.Size = new Size(214, 46);
            save.TabIndex = 8;
            save.Text = "Сохранить";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // decryptionResult
            // 
            decryptionResult.BackColor = Color.Black;
            decryptionResult.BorderStyle = BorderStyle.None;
            decryptionResult.Font = new Font("Zekton Rg", 15F, FontStyle.Regular, GraphicsUnit.Point);
            decryptionResult.ForeColor = Color.FromArgb(208, 16, 224);
            decryptionResult.Location = new Point(106, 341);
            decryptionResult.Multiline = true;
            decryptionResult.Name = "decryptionResult";
            decryptionResult.ReadOnly = true;
            decryptionResult.ScrollBars = ScrollBars.Vertical;
            decryptionResult.Size = new Size(662, 150);
            decryptionResult.TabIndex = 7;
            // 
            // Decryption
            // 
            Decryption.Font = new Font("Zekton Rg", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Decryption.Location = new Point(106, 133);
            Decryption.Multiline = true;
            Decryption.Name = "Decryption";
            Decryption.ScrollBars = ScrollBars.Vertical;
            Decryption.Size = new Size(662, 150);
            Decryption.TabIndex = 5;
            // 
            // buttonDecryption
            // 
            buttonDecryption.Cursor = Cursors.Hand;
            buttonDecryption.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 11, 65);
            buttonDecryption.FlatAppearance.MouseOverBackColor = Color.FromArgb(91, 7, 37);
            buttonDecryption.FlatStyle = FlatStyle.Flat;
            buttonDecryption.Font = new Font("Zekton Rg", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDecryption.ForeColor = Color.FromArgb(248, 25, 105);
            buttonDecryption.Location = new Point(106, 289);
            buttonDecryption.Name = "buttonDecryption";
            buttonDecryption.Size = new Size(214, 46);
            buttonDecryption.TabIndex = 4;
            buttonDecryption.Text = "Зашифровать";
            buttonDecryption.UseVisualStyleBackColor = true;
            buttonDecryption.Click += buttonDecryption_Click;
            // 
            // buttonEncryption
            // 
            buttonEncryption.BackColor = Color.Black;
            buttonEncryption.Cursor = Cursors.Hand;
            buttonEncryption.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 11, 65);
            buttonEncryption.FlatAppearance.MouseOverBackColor = Color.FromArgb(91, 7, 37);
            buttonEncryption.FlatStyle = FlatStyle.Flat;
            buttonEncryption.Font = new Font("Zekton Rg", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEncryption.ForeColor = Color.FromArgb(248, 25, 105);
            buttonEncryption.Location = new Point(558, 289);
            buttonEncryption.Name = "buttonEncryption";
            buttonEncryption.Size = new Size(210, 46);
            buttonEncryption.TabIndex = 2;
            buttonEncryption.Text = "Расшифровать";
            buttonEncryption.UseVisualStyleBackColor = false;
            buttonEncryption.Click += buttonEncryption_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 134, 0);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 118);
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
            closeButton.Location = new Point(839, 0);
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
            label1.Location = new Point(244, 25);
            label1.Name = "label1";
            label1.Size = new Size(398, 67);
            label1.TabIndex = 0;
            label1.Text = "Шифр Атбаш";
            // 
            // Atbash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 568);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Atbash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atbash";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private Button buttonDecryption;
        private Button buttonEncryption;
        private TextBox Decryption;
        private TextBox decryptionResult;
        private Button read;
        private Button save;
    }
}