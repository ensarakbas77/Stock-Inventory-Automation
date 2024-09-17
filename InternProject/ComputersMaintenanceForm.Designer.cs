namespace InternProject
{
    partial class ComputersMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputersMaintenanceForm));
            computerClose_label = new Label();
            computerBack = new PictureBox();
            panel1 = new Panel();
            user_icon = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            c_id_Txt = new Label();
            apply_button = new Button();
            start_date = new Label();
            maintenanceDateLbl = new Label();
            brandLbl = new Label();
            personUsingLbl = new Label();
            hostnameLbl = new Label();
            label2 = new Label();
            alert1 = new PictureBox();
            pictureBox2 = new PictureBox();
            refresh_button = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)computerBack).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alert1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh_button).BeginInit();
            SuspendLayout();
            // 
            // computerClose_label
            // 
            computerClose_label.Cursor = Cursors.Hand;
            computerClose_label.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            computerClose_label.Location = new Point(992, 12);
            computerClose_label.Name = "computerClose_label";
            computerClose_label.Size = new Size(27, 27);
            computerClose_label.TabIndex = 25;
            computerClose_label.Text = "X";
            computerClose_label.Click += computerClose_label_Click;
            // 
            // computerBack
            // 
            computerBack.Cursor = Cursors.Hand;
            computerBack.Image = (Image)resources.GetObject("computerBack.Image");
            computerBack.Location = new Point(333, 9);
            computerBack.Name = "computerBack";
            computerBack.Size = new Size(38, 27);
            computerBack.SizeMode = PictureBoxSizeMode.Zoom;
            computerBack.TabIndex = 26;
            computerBack.TabStop = false;
            computerBack.Click += computerBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(user_icon);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 1020);
            panel1.TabIndex = 33;
            // 
            // user_icon
            // 
            user_icon.Cursor = Cursors.Hand;
            user_icon.Image = (Image)resources.GetObject("user_icon.Image");
            user_icon.Location = new Point(65, 35);
            user_icon.Name = "user_icon";
            user_icon.Size = new Size(191, 187);
            user_icon.SizeMode = PictureBoxSizeMode.Zoom;
            user_icon.TabIndex = 47;
            user_icon.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 938);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(115, 225);
            label1.Name = "label1";
            label1.Size = new Size(89, 29);
            label1.TabIndex = 1;
            label1.Text = "Admin";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GhostWhite;
            groupBox1.Controls.Add(c_id_Txt);
            groupBox1.Controls.Add(apply_button);
            groupBox1.Controls.Add(start_date);
            groupBox1.Controls.Add(maintenanceDateLbl);
            groupBox1.Controls.Add(brandLbl);
            groupBox1.Controls.Add(personUsingLbl);
            groupBox1.Controls.Add(hostnameLbl);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(alert1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(374, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 486);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            // 
            // c_id_Txt
            // 
            c_id_Txt.AutoSize = true;
            c_id_Txt.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            c_id_Txt.ForeColor = SystemColors.WindowText;
            c_id_Txt.Location = new Point(84, 203);
            c_id_Txt.Name = "c_id_Txt";
            c_id_Txt.Size = new Size(0, 27);
            c_id_Txt.TabIndex = 42;
            // 
            // apply_button
            // 
            apply_button.BackColor = Color.Red;
            apply_button.Cursor = Cursors.Hand;
            apply_button.FlatStyle = FlatStyle.Popup;
            apply_button.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            apply_button.ForeColor = SystemColors.ButtonHighlight;
            apply_button.Location = new Point(9, 432);
            apply_button.Name = "apply_button";
            apply_button.Size = new Size(157, 40);
            apply_button.TabIndex = 41;
            apply_button.Text = "Tamamlandı";
            apply_button.UseVisualStyleBackColor = false;
            apply_button.Click += apply_button_Click;
            // 
            // start_date
            // 
            start_date.AutoSize = true;
            start_date.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            start_date.ForeColor = SystemColors.WindowText;
            start_date.Location = new Point(3, 353);
            start_date.Name = "start_date";
            start_date.Size = new Size(265, 27);
            start_date.TabIndex = 35;
            start_date.Text = "Kullanmaya Baş. Tarih:\r\n";
            // 
            // maintenanceDateLbl
            // 
            maintenanceDateLbl.AutoSize = true;
            maintenanceDateLbl.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            maintenanceDateLbl.ForeColor = SystemColors.WindowText;
            maintenanceDateLbl.Location = new Point(3, 390);
            maintenanceDateLbl.Name = "maintenanceDateLbl";
            maintenanceDateLbl.Size = new Size(194, 27);
            maintenanceDateLbl.TabIndex = 35;
            maintenanceDateLbl.Text = "PC Bakım Tarihi:";
            // 
            // brandLbl
            // 
            brandLbl.AutoSize = true;
            brandLbl.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            brandLbl.ForeColor = SystemColors.WindowText;
            brandLbl.Location = new Point(3, 277);
            brandLbl.Name = "brandLbl";
            brandLbl.Size = new Size(107, 27);
            brandLbl.TabIndex = 35;
            brandLbl.Text = "Markası:";
            // 
            // personUsingLbl
            // 
            personUsingLbl.AutoSize = true;
            personUsingLbl.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            personUsingLbl.ForeColor = SystemColors.WindowText;
            personUsingLbl.Location = new Point(3, 314);
            personUsingLbl.Name = "personUsingLbl";
            personUsingLbl.Size = new Size(163, 27);
            personUsingLbl.TabIndex = 35;
            personUsingLbl.Text = "Kullanan Kişi:";
            // 
            // hostnameLbl
            // 
            hostnameLbl.AutoSize = true;
            hostnameLbl.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            hostnameLbl.ForeColor = SystemColors.WindowText;
            hostnameLbl.Location = new Point(3, 239);
            hostnameLbl.Name = "hostnameLbl";
            hostnameLbl.Size = new Size(132, 27);
            hostnameLbl.TabIndex = 35;
            hostnameLbl.Text = "Hostname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(3, 203);
            label2.Name = "label2";
            label2.Size = new Size(83, 27);
            label2.TabIndex = 35;
            label2.Text = "PC ID:";
            // 
            // alert1
            // 
            alert1.Image = (Image)resources.GetObject("alert1.Image");
            alert1.Location = new Point(512, 0);
            alert1.Name = "alert1";
            alert1.Size = new Size(63, 58);
            alert1.SizeMode = PictureBoxSizeMode.Zoom;
            alert1.TabIndex = 35;
            alert1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(187, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // refresh_button
            // 
            refresh_button.Cursor = Cursors.Hand;
            refresh_button.Image = (Image)resources.GetObject("refresh_button.Image");
            refresh_button.Location = new Point(377, 9);
            refresh_button.Name = "refresh_button";
            refresh_button.Size = new Size(37, 30);
            refresh_button.SizeMode = PictureBoxSizeMode.Zoom;
            refresh_button.TabIndex = 44;
            refresh_button.TabStop = false;
            refresh_button.Click += refresh_button_Click;
            // 
            // ComputersMaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 1020);
            Controls.Add(refresh_button);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(computerBack);
            Controls.Add(computerClose_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComputersMaintenanceForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComputersForm";
            Load += ComputersMaintenanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)computerBack).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)user_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)alert1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)refresh_button).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label computerClose_label;
        private PictureBox computerBack;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox user_icon;
        private GroupBox groupBox1;
        private Button apply_button;
        private Label maintenanceDateLbl;
        private Label brandLbl;
        private Label personUsingLbl;
        private Label hostnameLbl;
        private Label label2;
        private PictureBox alert1;
        private PictureBox pictureBox2;
        public Label c_id_Txt;
        private Label start_date;
        private PictureBox refresh_button;
    }
}