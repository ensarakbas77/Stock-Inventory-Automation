namespace InternProject
{
    partial class AgreementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgreementForm));
            exit_Lbl = new Label();
            back_Lbl = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Label_admin = new Label();
            user_icon = new PictureBox();
            save_button = new Button();
            passwordLabel = new Label();
            last_name_TXT = new TextBox();
            nameLabel = new Label();
            first_name_TXT = new TextBox();
            label1 = new Label();
            department_TXT = new TextBox();
            label2 = new Label();
            link_LBL = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)back_Lbl).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user_icon).BeginInit();
            SuspendLayout();
            // 
            // exit_Lbl
            // 
            exit_Lbl.Cursor = Cursors.Hand;
            exit_Lbl.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            exit_Lbl.Location = new Point(711, 12);
            exit_Lbl.Name = "exit_Lbl";
            exit_Lbl.Size = new Size(27, 27);
            exit_Lbl.TabIndex = 27;
            exit_Lbl.Text = "X";
            exit_Lbl.Click += exit_Lbl_Click;
            // 
            // back_Lbl
            // 
            back_Lbl.Cursor = Cursors.Hand;
            back_Lbl.Image = (Image)resources.GetObject("back_Lbl.Image");
            back_Lbl.Location = new Point(256, 12);
            back_Lbl.Name = "back_Lbl";
            back_Lbl.Size = new Size(33, 27);
            back_Lbl.SizeMode = PictureBoxSizeMode.Zoom;
            back_Lbl.TabIndex = 28;
            back_Lbl.TabStop = false;
            back_Lbl.Click += back_Lbl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Label_admin);
            panel1.Controls.Add(user_icon);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 750);
            panel1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 667);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // Label_admin
            // 
            Label_admin.AutoSize = true;
            Label_admin.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_admin.ForeColor = SystemColors.ControlLightLight;
            Label_admin.Location = new Point(81, 225);
            Label_admin.Name = "Label_admin";
            Label_admin.Size = new Size(89, 29);
            Label_admin.TabIndex = 52;
            Label_admin.Text = "Admin";
            // 
            // user_icon
            // 
            user_icon.Cursor = Cursors.Hand;
            user_icon.Image = (Image)resources.GetObject("user_icon.Image");
            user_icon.Location = new Point(32, 35);
            user_icon.Name = "user_icon";
            user_icon.Size = new Size(192, 187);
            user_icon.SizeMode = PictureBoxSizeMode.Zoom;
            user_icon.TabIndex = 46;
            user_icon.TabStop = false;
            // 
            // save_button
            // 
            save_button.BackColor = Color.Red;
            save_button.Cursor = Cursors.Hand;
            save_button.FlatStyle = FlatStyle.Popup;
            save_button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            save_button.ForeColor = SystemColors.ButtonHighlight;
            save_button.Location = new Point(429, 580);
            save_button.Name = "save_button";
            save_button.Size = new Size(130, 50);
            save_button.TabIndex = 37;
            save_button.Text = "Kaydet";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(323, 314);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(100, 29);
            passwordLabel.TabIndex = 41;
            passwordLabel.Text = "Soyisim:";
            // 
            // last_name_TXT
            // 
            last_name_TXT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            last_name_TXT.Location = new Point(323, 349);
            last_name_TXT.Multiline = true;
            last_name_TXT.Name = "last_name_TXT";
            last_name_TXT.Size = new Size(330, 35);
            last_name_TXT.TabIndex = 40;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.Black;
            nameLabel.Location = new Point(323, 209);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(66, 29);
            nameLabel.TabIndex = 39;
            nameLabel.Text = "İsim:\r\n";
            // 
            // first_name_TXT
            // 
            first_name_TXT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            first_name_TXT.Location = new Point(323, 239);
            first_name_TXT.Multiline = true;
            first_name_TXT.Name = "first_name_TXT";
            first_name_TXT.Size = new Size(330, 35);
            first_name_TXT.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(323, 434);
            label1.Name = "label1";
            label1.Size = new Size(139, 29);
            label1.TabIndex = 43;
            label1.Text = "Departman:";
            // 
            // department_TXT
            // 
            department_TXT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            department_TXT.Location = new Point(323, 469);
            department_TXT.Multiline = true;
            department_TXT.Name = "department_TXT";
            department_TXT.Size = new Size(330, 35);
            department_TXT.TabIndex = 42;
            // 
            // label2
            // 
            label2.BackColor = Color.Red;
            label2.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(282, 121);
            label2.Name = "label2";
            label2.Size = new Size(407, 45);
            label2.TabIndex = 44;
            label2.Text = "Çalışan Bilgilerini Giriniz";
            // 
            // link_LBL
            // 
            link_LBL.ActiveLinkColor = Color.Red;
            link_LBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            link_LBL.AutoSize = true;
            link_LBL.BackColor = SystemColors.ButtonHighlight;
            link_LBL.Cursor = Cursors.Hand;
            link_LBL.Font = new Font("Tahoma", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            link_LBL.LinkColor = Color.Red;
            link_LBL.Location = new Point(346, 652);
            link_LBL.Name = "link_LBL";
            link_LBL.Size = new Size(317, 24);
            link_LBL.TabIndex = 45;
            link_LBL.TabStop = true;
            link_LBL.Text = "Zimmet Formları klasörüne Git";
            link_LBL.LinkClicked += link_LBL_LinkClicked;
            // 
            // Agreement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(750, 750);
            Controls.Add(link_LBL);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(department_TXT);
            Controls.Add(passwordLabel);
            Controls.Add(last_name_TXT);
            Controls.Add(nameLabel);
            Controls.Add(first_name_TXT);
            Controls.Add(save_button);
            Controls.Add(panel1);
            Controls.Add(back_Lbl);
            Controls.Add(exit_Lbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agreement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agreement";
            ((System.ComponentModel.ISupportInitialize)back_Lbl).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)user_icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exit_Lbl;
        private PictureBox back_Lbl;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label Label_admin;
        private PictureBox user_icon;
        private Button save_button;
        private Label passwordLabel;
        private TextBox last_name_TXT;
        private Label nameLabel;
        public TextBox first_name_TXT;
        private Label label1;
        private TextBox department_TXT;
        private Label label2;
        private LinkLabel link_LBL;
    }
}