namespace InternProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            adminLinkLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            nameLabel = new Label();
            usernameTxt = new TextBox();
            passwordLabel = new Label();
            passwordTxt = new TextBox();
            gorevLabel = new Label();
            roleComboBox = new ComboBox();
            panel1 = new Panel();
            loginCloseLabel = new Label();
            label1 = new Label();
            loginButton = new Button();
            showPasswordLogin = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // adminLinkLabel
            // 
            adminLinkLabel.ActiveLinkColor = Color.Red;
            adminLinkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminLinkLabel.AutoSize = true;
            adminLinkLabel.BackColor = SystemColors.ButtonHighlight;
            adminLinkLabel.Cursor = Cursors.Hand;
            adminLinkLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            adminLinkLabel.LinkColor = Color.Red;
            adminLinkLabel.Location = new Point(487, 637);
            adminLinkLabel.Name = "adminLinkLabel";
            adminLinkLabel.Size = new Size(139, 24);
            adminLinkLabel.TabIndex = 3;
            adminLinkLabel.TabStop = true;
            adminLinkLabel.Text = " Admin Girişi";
            adminLinkLabel.LinkClicked += adminLinkLabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.Black;
            nameLabel.Location = new Point(385, 185);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(145, 29);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Kullanıcı Adı:";
            // 
            // usernameTxt
            // 
            usernameTxt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTxt.Location = new Point(385, 215);
            usernameTxt.Multiline = true;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(330, 35);
            usernameTxt.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(385, 290);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(69, 29);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Şifre:";
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxt.Location = new Point(385, 325);
            passwordTxt.Multiline = true;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(330, 35);
            passwordTxt.TabIndex = 8;
            // 
            // gorevLabel
            // 
            gorevLabel.AutoSize = true;
            gorevLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gorevLabel.ForeColor = Color.Black;
            gorevLabel.Location = new Point(385, 440);
            gorevLabel.Name = "gorevLabel";
            gorevLabel.Size = new Size(84, 29);
            gorevLabel.TabIndex = 11;
            gorevLabel.Text = "Görev:";
            // 
            // roleComboBox
            // 
            roleComboBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Bakımcı", "Stokçu", "Vardiya Amiri" });
            roleComboBox.Location = new Point(385, 470);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(330, 37);
            roleComboBox.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 720);
            panel1.TabIndex = 12;
            // 
            // loginCloseLabel
            // 
            loginCloseLabel.AutoSize = true;
            loginCloseLabel.Cursor = Cursors.Hand;
            loginCloseLabel.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            loginCloseLabel.Location = new Point(767, 9);
            loginCloseLabel.Name = "loginCloseLabel";
            loginCloseLabel.Size = new Size(27, 27);
            loginCloseLabel.TabIndex = 13;
            loginCloseLabel.Text = "X";
            loginCloseLabel.Click += loginCloseLabel_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(360, 95);
            label1.Name = "label1";
            label1.Size = new Size(407, 45);
            label1.TabIndex = 0;
            label1.Text = " Hesabınıza Giriş Yapınız";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Red;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(485, 545);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(130, 50);
            loginButton.TabIndex = 14;
            loginButton.Text = "Giriş Yap";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // showPasswordLogin
            // 
            showPasswordLogin.AutoSize = true;
            showPasswordLogin.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordLogin.Location = new Point(570, 375);
            showPasswordLogin.Name = "showPasswordLogin";
            showPasswordLogin.Size = new Size(155, 28);
            showPasswordLogin.TabIndex = 15;
            showPasswordLogin.Text = "Şifreyi Göster";
            showPasswordLogin.UseVisualStyleBackColor = true;
            showPasswordLogin.CheckedChanged += showPasswordLogin_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(805, 720);
            Controls.Add(showPasswordLogin);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(loginCloseLabel);
            Controls.Add(adminLinkLabel);
            Controls.Add(panel1);
            Controls.Add(gorevLabel);
            Controls.Add(roleComboBox);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTxt);
            Controls.Add(nameLabel);
            Controls.Add(usernameTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel adminLinkLabel;
        private PictureBox pictureBox1;
        private Label nameLabel;
        private Label passwordLabel;
        private Label gorevLabel;
        private Panel panel1;
        private Label label1;
        private Label loginCloseLabel;
        private Button loginButton;
        private CheckBox showPasswordLogin;
        public TextBox usernameTxt;
        public ComboBox roleComboBox;
        private TextBox passwordTxt;
    }
}
