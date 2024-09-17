namespace InternProject
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            adminLogin_button = new Button();
            label1 = new Label();
            adminClose_Label = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            adminPassLabel = new Label();
            admin_password = new TextBox();
            adminLabel = new Label();
            admin_username = new TextBox();
            backButton = new PictureBox();
            showPasswordAdmin = new CheckBox();
            computerGorev_Label = new Label();
            adminComboBox = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            SuspendLayout();
            // 
            // adminLogin_button
            // 
            adminLogin_button.BackColor = Color.Red;
            adminLogin_button.Cursor = Cursors.Hand;
            adminLogin_button.FlatStyle = FlatStyle.Flat;
            adminLogin_button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminLogin_button.ForeColor = SystemColors.ButtonHighlight;
            adminLogin_button.Location = new Point(485, 545);
            adminLogin_button.Name = "adminLogin_button";
            adminLogin_button.Size = new Size(130, 50);
            adminLogin_button.TabIndex = 25;
            adminLogin_button.Text = "Giriş Yap";
            adminLogin_button.UseVisualStyleBackColor = false;
            adminLogin_button.Click += adminLogin_button_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(360, 95);
            label1.Name = "label1";
            label1.Size = new Size(408, 45);
            label1.TabIndex = 15;
            label1.Text = " Hesabınıza Giriş Yapınız";
            // 
            // adminClose_Label
            // 
            adminClose_Label.AutoSize = true;
            adminClose_Label.Cursor = Cursors.Hand;
            adminClose_Label.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            adminClose_Label.Location = new Point(772, 9);
            adminClose_Label.Name = "adminClose_Label";
            adminClose_Label.Size = new Size(27, 27);
            adminClose_Label.TabIndex = 24;
            adminClose_Label.Text = "X";
            adminClose_Label.Click += adminClose_Label_Click;
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
            panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // adminPassLabel
            // 
            adminPassLabel.AutoSize = true;
            adminPassLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminPassLabel.ForeColor = Color.Black;
            adminPassLabel.Location = new Point(385, 290);
            adminPassLabel.Name = "adminPassLabel";
            adminPassLabel.Size = new Size(69, 29);
            adminPassLabel.TabIndex = 20;
            adminPassLabel.Text = "Şifre:";
            // 
            // admin_password
            // 
            admin_password.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            admin_password.Location = new Point(385, 325);
            admin_password.Multiline = true;
            admin_password.Name = "admin_password";
            admin_password.PasswordChar = '*';
            admin_password.Size = new Size(330, 35);
            admin_password.TabIndex = 19;
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminLabel.ForeColor = Color.Black;
            adminLabel.Location = new Point(385, 185);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(145, 29);
            adminLabel.TabIndex = 18;
            adminLabel.Text = "Kullanıcı Adı:";
            // 
            // admin_username
            // 
            admin_username.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            admin_username.Location = new Point(385, 215);
            admin_username.Multiline = true;
            admin_username.Name = "admin_username";
            admin_username.Size = new Size(330, 35);
            admin_username.TabIndex = 17;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ButtonHighlight;
            backButton.Cursor = Cursors.Hand;
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(385, 545);
            backButton.Name = "backButton";
            backButton.Size = new Size(54, 50);
            backButton.SizeMode = PictureBoxSizeMode.Zoom;
            backButton.TabIndex = 6;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // showPasswordAdmin
            // 
            showPasswordAdmin.AutoSize = true;
            showPasswordAdmin.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordAdmin.Location = new Point(570, 375);
            showPasswordAdmin.Name = "showPasswordAdmin";
            showPasswordAdmin.Size = new Size(155, 28);
            showPasswordAdmin.TabIndex = 26;
            showPasswordAdmin.Text = "Şifreyi Göster";
            showPasswordAdmin.UseVisualStyleBackColor = true;
            showPasswordAdmin.CheckedChanged += showPasswordAdmin_CheckedChanged;
            // 
            // computerGorev_Label
            // 
            computerGorev_Label.AutoSize = true;
            computerGorev_Label.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            computerGorev_Label.ForeColor = Color.Black;
            computerGorev_Label.Location = new Point(385, 440);
            computerGorev_Label.Name = "computerGorev_Label";
            computerGorev_Label.Size = new Size(360, 29);
            computerGorev_Label.TabIndex = 28;
            computerGorev_Label.Text = "Yapmak istediğiniz işlemi seçiniz:";
            // 
            // adminComboBox
            // 
            adminComboBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminComboBox.FormattingEnabled = true;
            adminComboBox.Items.AddRange(new object[] { "PC Bakımı", "Log", "Zimmet" });
            adminComboBox.Location = new Point(385, 470);
            adminComboBox.Name = "adminComboBox";
            adminComboBox.Size = new Size(360, 37);
            adminComboBox.TabIndex = 27;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(805, 720);
            Controls.Add(computerGorev_Label);
            Controls.Add(adminComboBox);
            Controls.Add(showPasswordAdmin);
            Controls.Add(backButton);
            Controls.Add(adminLogin_button);
            Controls.Add(label1);
            Controls.Add(adminClose_Label);
            Controls.Add(panel1);
            Controls.Add(adminPassLabel);
            Controls.Add(admin_password);
            Controls.Add(adminLabel);
            Controls.Add(admin_username);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adminLogin_button;
        private Label label1;
        private Label adminClose_Label;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label adminPassLabel;
        private TextBox admin_password;
        private Label adminLabel;
        private TextBox admin_username;
        private PictureBox backButton;
        private CheckBox showPasswordAdmin;
        private Label computerGorev_Label;
        private ComboBox adminComboBox;
    }
}