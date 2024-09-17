namespace InternProject
{
    partial class MaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            bakımcıBack = new PictureBox();
            bakımcıClose_label = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            user_icon = new PictureBox();
            DGW_Malzeme_Listele = new DataGridView();
            idTxt = new TextBox();
            quantityTxt = new TextBox();
            reasonTxt = new TextBox();
            apply_button = new Button();
            userTxt = new TextBox();
            refresh_button = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)bakımcıBack).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGW_Malzeme_Listele).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh_button).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // bakımcıBack
            // 
            bakımcıBack.BackColor = SystemColors.ButtonHighlight;
            bakımcıBack.Cursor = Cursors.Hand;
            bakımcıBack.Image = (Image)resources.GetObject("bakımcıBack.Image");
            bakımcıBack.Location = new Point(333, 9);
            bakımcıBack.Name = "bakımcıBack";
            bakımcıBack.Size = new Size(34, 29);
            bakımcıBack.SizeMode = PictureBoxSizeMode.Zoom;
            bakımcıBack.TabIndex = 31;
            bakımcıBack.TabStop = false;
            bakımcıBack.Click += bakımcıBack_Click;
            // 
            // bakımcıClose_label
            // 
            bakımcıClose_label.Cursor = Cursors.Hand;
            bakımcıClose_label.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bakımcıClose_label.Location = new Point(1481, 9);
            bakımcıClose_label.Name = "bakımcıClose_label";
            bakımcıClose_label.Size = new Size(27, 27);
            bakımcıClose_label.TabIndex = 30;
            bakımcıClose_label.Text = "X";
            bakımcıClose_label.Click += bakımcıClose_label_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(user_icon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 1090);
            panel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 1010);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(59, 293);
            label3.Name = "label3";
            label3.Size = new Size(100, 29);
            label3.TabIndex = 1;
            label3.Text = "Görevi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(59, 264);
            label2.Name = "label2";
            label2.Size = new Size(85, 29);
            label2.TabIndex = 1;
            label2.Text = "K.Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(59, 235);
            label1.Name = "label1";
            label1.Size = new Size(59, 29);
            label1.TabIndex = 1;
            label1.Text = "ID: ";
            // 
            // user_icon
            // 
            user_icon.Cursor = Cursors.Hand;
            user_icon.Image = (Image)resources.GetObject("user_icon.Image");
            user_icon.Location = new Point(59, 29);
            user_icon.Name = "user_icon";
            user_icon.Size = new Size(192, 187);
            user_icon.SizeMode = PictureBoxSizeMode.Zoom;
            user_icon.TabIndex = 0;
            user_icon.TabStop = false;
            // 
            // DGW_Malzeme_Listele
            // 
            DGW_Malzeme_Listele.AllowUserToAddRows = false;
            DGW_Malzeme_Listele.AllowUserToDeleteRows = false;
            DGW_Malzeme_Listele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGW_Malzeme_Listele.BackgroundColor = SystemColors.ButtonHighlight;
            DGW_Malzeme_Listele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGW_Malzeme_Listele.DefaultCellStyle = dataGridViewCellStyle2;
            DGW_Malzeme_Listele.Location = new Point(348, 44);
            DGW_Malzeme_Listele.Name = "DGW_Malzeme_Listele";
            DGW_Malzeme_Listele.ReadOnly = true;
            DGW_Malzeme_Listele.RowHeadersWidth = 62;
            DGW_Malzeme_Listele.RowTemplate.Height = 33;
            DGW_Malzeme_Listele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGW_Malzeme_Listele.Size = new Size(1148, 545);
            DGW_Malzeme_Listele.TabIndex = 33;
            // 
            // idTxt
            // 
            idTxt.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            idTxt.Location = new Point(348, 765);
            idTxt.Name = "idTxt";
            idTxt.PlaceholderText = "Malzeme ID";
            idTxt.Size = new Size(150, 34);
            idTxt.TabIndex = 35;
            // 
            // quantityTxt
            // 
            quantityTxt.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            quantityTxt.Location = new Point(348, 805);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.PlaceholderText = "Alınan Stok Adedi";
            quantityTxt.Size = new Size(243, 34);
            quantityTxt.TabIndex = 37;
            // 
            // reasonTxt
            // 
            reasonTxt.AccessibleDescription = "";
            reasonTxt.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            reasonTxt.Location = new Point(348, 845);
            reasonTxt.Multiline = true;
            reasonTxt.Name = "reasonTxt";
            reasonTxt.PlaceholderText = "Kullanım Amacı";
            reasonTxt.Size = new Size(458, 101);
            reasonTxt.TabIndex = 39;
            // 
            // apply_button
            // 
            apply_button.BackColor = Color.Red;
            apply_button.Cursor = Cursors.Hand;
            apply_button.FlatStyle = FlatStyle.Popup;
            apply_button.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            apply_button.ForeColor = SystemColors.ButtonHighlight;
            apply_button.Location = new Point(348, 957);
            apply_button.Name = "apply_button";
            apply_button.Size = new Size(150, 47);
            apply_button.TabIndex = 40;
            apply_button.Text = "Uygula";
            apply_button.UseVisualStyleBackColor = false;
            apply_button.Click += apply_button_Click;
            // 
            // userTxt
            // 
            userTxt.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            userTxt.Location = new Point(348, 725);
            userTxt.Name = "userTxt";
            userTxt.PlaceholderText = "Kullanıcı ID";
            userTxt.Size = new Size(150, 34);
            userTxt.TabIndex = 42;
            // 
            // refresh_button
            // 
            refresh_button.Cursor = Cursors.Hand;
            refresh_button.Image = (Image)resources.GetObject("refresh_button.Image");
            refresh_button.Location = new Point(373, 9);
            refresh_button.Name = "refresh_button";
            refresh_button.Size = new Size(37, 30);
            refresh_button.SizeMode = PictureBoxSizeMode.Zoom;
            refresh_button.TabIndex = 43;
            refresh_button.TabStop = false;
            refresh_button.Click += refresh_button_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Khaki;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(348, 596);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 98);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Khaki;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Khaki;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(67, 9);
            label4.Name = "label4";
            label4.Size = new Size(564, 74);
            label4.TabIndex = 47;
            label4.Text = "-Malzeme kullanımında bilgileri doğru girdiğinizden emin olun.\r\n-'Alınan Stok Adedini' eksi(-) işaretiyle birlikte girin.(Örn: -5)\r\n-Kullanım amacını anlaşılır bir şekilde girin.";
            // 
            // MaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1520, 1090);
            Controls.Add(groupBox1);
            Controls.Add(refresh_button);
            Controls.Add(userTxt);
            Controls.Add(bakımcıBack);
            Controls.Add(apply_button);
            Controls.Add(reasonTxt);
            Controls.Add(quantityTxt);
            Controls.Add(idTxt);
            Controls.Add(DGW_Malzeme_Listele);
            Controls.Add(panel1);
            Controls.Add(bakımcıClose_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MaintenanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Maintenance";
            Load += Maintenance_Load;
            ((System.ComponentModel.ISupportInitialize)bakımcıBack).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)user_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGW_Malzeme_Listele).EndInit();
            ((System.ComponentModel.ISupportInitialize)refresh_button).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bakımcıBack;
        private Label bakımcıClose_label;
        private Panel panel1;
        private PictureBox user_icon;
        private DataGridView DGW_Malzeme_Listele;
        private TextBox idTxt;
        private TextBox quantityTxt;
        private TextBox reasonTxt;
        private Button apply_button;
        private TextBox userTxt;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox refresh_button;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label label4;
    }
}