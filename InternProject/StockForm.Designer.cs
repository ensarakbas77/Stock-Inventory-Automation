namespace InternProject
{
    partial class StockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            stockBack = new PictureBox();
            stockClose_label = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Label_role = new Label();
            Label_username = new Label();
            Label_id = new Label();
            user_icon = new PictureBox();
            DGW_MalList_Stokcu = new DataGridView();
            idTxt = new TextBox();
            typeTxt = new TextBox();
            nameTxt = new TextBox();
            quantityTxt = new TextBox();
            delete_button = new Button();
            add_button = new Button();
            update_button = new Button();
            refresh_button = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)stockBack).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGW_MalList_Stokcu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // stockBack
            // 
            stockBack.Cursor = Cursors.Hand;
            stockBack.Image = (Image)resources.GetObject("stockBack.Image");
            stockBack.Location = new Point(333, 9);
            stockBack.Name = "stockBack";
            stockBack.Size = new Size(37, 30);
            stockBack.SizeMode = PictureBoxSizeMode.Zoom;
            stockBack.TabIndex = 29;
            stockBack.TabStop = false;
            stockBack.Click += stockBack_Click;
            // 
            // stockClose_label
            // 
            stockClose_label.Cursor = Cursors.Hand;
            stockClose_label.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            stockClose_label.Location = new Point(1481, 9);
            stockClose_label.Name = "stockClose_label";
            stockClose_label.Size = new Size(27, 27);
            stockClose_label.TabIndex = 28;
            stockClose_label.Text = "X";
            stockClose_label.Click += stockClose_label_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Label_role);
            panel1.Controls.Add(Label_username);
            panel1.Controls.Add(Label_id);
            panel1.Controls.Add(user_icon);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 1090);
            panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 1010);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // Label_role
            // 
            Label_role.AutoSize = true;
            Label_role.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_role.ForeColor = SystemColors.ControlLightLight;
            Label_role.Location = new Point(63, 296);
            Label_role.Name = "Label_role";
            Label_role.Size = new Size(100, 29);
            Label_role.TabIndex = 47;
            Label_role.Text = "Görevi:";
            // 
            // Label_username
            // 
            Label_username.AutoSize = true;
            Label_username.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_username.ForeColor = SystemColors.ControlLightLight;
            Label_username.Location = new Point(63, 267);
            Label_username.Name = "Label_username";
            Label_username.Size = new Size(85, 29);
            Label_username.TabIndex = 48;
            Label_username.Text = "K.Adı:";
            // 
            // Label_id
            // 
            Label_id.AutoSize = true;
            Label_id.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_id.ForeColor = SystemColors.ControlLightLight;
            Label_id.Location = new Point(63, 238);
            Label_id.Name = "Label_id";
            Label_id.Size = new Size(59, 29);
            Label_id.TabIndex = 49;
            Label_id.Text = "ID: ";
            // 
            // user_icon
            // 
            user_icon.BackColor = SystemColors.ButtonHighlight;
            user_icon.Cursor = Cursors.Hand;
            user_icon.Image = (Image)resources.GetObject("user_icon.Image");
            user_icon.Location = new Point(63, 34);
            user_icon.Name = "user_icon";
            user_icon.Size = new Size(204, 187);
            user_icon.SizeMode = PictureBoxSizeMode.Zoom;
            user_icon.TabIndex = 46;
            user_icon.TabStop = false;
            // 
            // DGW_MalList_Stokcu
            // 
            DGW_MalList_Stokcu.AllowUserToAddRows = false;
            DGW_MalList_Stokcu.AllowUserToDeleteRows = false;
            DGW_MalList_Stokcu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGW_MalList_Stokcu.BackgroundColor = SystemColors.ButtonHighlight;
            DGW_MalList_Stokcu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGW_MalList_Stokcu.DefaultCellStyle = dataGridViewCellStyle1;
            DGW_MalList_Stokcu.Location = new Point(343, 55);
            DGW_MalList_Stokcu.Name = "DGW_MalList_Stokcu";
            DGW_MalList_Stokcu.ReadOnly = true;
            DGW_MalList_Stokcu.RowHeadersWidth = 62;
            DGW_MalList_Stokcu.RowTemplate.Height = 33;
            DGW_MalList_Stokcu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGW_MalList_Stokcu.Size = new Size(1152, 483);
            DGW_MalList_Stokcu.TabIndex = 34;
            // 
            // idTxt
            // 
            idTxt.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            idTxt.Location = new Point(343, 713);
            idTxt.Name = "idTxt";
            idTxt.PlaceholderText = "Malzeme ID";
            idTxt.Size = new Size(228, 34);
            idTxt.TabIndex = 37;
            // 
            // typeTxt
            // 
            typeTxt.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            typeTxt.Location = new Point(343, 793);
            typeTxt.Name = "typeTxt";
            typeTxt.PlaceholderText = "Malzeme Tipi (Örn: Monitör, kablo vs.)";
            typeTxt.Size = new Size(400, 34);
            typeTxt.TabIndex = 39;
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nameTxt.Location = new Point(343, 753);
            nameTxt.Name = "nameTxt";
            nameTxt.PlaceholderText = "Malzeme Adı";
            nameTxt.Size = new Size(228, 34);
            nameTxt.TabIndex = 41;
            // 
            // quantityTxt
            // 
            quantityTxt.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            quantityTxt.Location = new Point(343, 833);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.PlaceholderText = "Malzeme Stok Adedi";
            quantityTxt.Size = new Size(228, 34);
            quantityTxt.TabIndex = 43;
            // 
            // delete_button
            // 
            delete_button.BackColor = SystemColors.Control;
            delete_button.BackgroundImage = (Image)resources.GetObject("delete_button.BackgroundImage");
            delete_button.BackgroundImageLayout = ImageLayout.Zoom;
            delete_button.Cursor = Cursors.Hand;
            delete_button.FlatStyle = FlatStyle.Popup;
            delete_button.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delete_button.ForeColor = SystemColors.ButtonHighlight;
            delete_button.Location = new Point(418, 874);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(67, 60);
            delete_button.TabIndex = 44;
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // add_button
            // 
            add_button.BackColor = SystemColors.Control;
            add_button.BackgroundImage = (Image)resources.GetObject("add_button.BackgroundImage");
            add_button.BackgroundImageLayout = ImageLayout.Zoom;
            add_button.Cursor = Cursors.Hand;
            add_button.FlatStyle = FlatStyle.Popup;
            add_button.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            add_button.ForeColor = SystemColors.ButtonHighlight;
            add_button.Location = new Point(342, 873);
            add_button.Name = "add_button";
            add_button.Size = new Size(70, 61);
            add_button.TabIndex = 44;
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // update_button
            // 
            update_button.BackColor = SystemColors.Control;
            update_button.BackgroundImage = (Image)resources.GetObject("update_button.BackgroundImage");
            update_button.BackgroundImageLayout = ImageLayout.Zoom;
            update_button.Cursor = Cursors.Hand;
            update_button.FlatStyle = FlatStyle.Popup;
            update_button.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            update_button.ForeColor = SystemColors.ButtonHighlight;
            update_button.Location = new Point(491, 874);
            update_button.Name = "update_button";
            update_button.Size = new Size(67, 60);
            update_button.TabIndex = 44;
            update_button.UseVisualStyleBackColor = false;
            update_button.Click += update_button_Click;
            // 
            // refresh_button
            // 
            refresh_button.Cursor = Cursors.Hand;
            refresh_button.Image = (Image)resources.GetObject("refresh_button.Image");
            refresh_button.Location = new Point(376, 9);
            refresh_button.Name = "refresh_button";
            refresh_button.Size = new Size(37, 30);
            refresh_button.SizeMode = PictureBoxSizeMode.Zoom;
            refresh_button.TabIndex = 29;
            refresh_button.TabStop = false;
            refresh_button.Click += refresh_button_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(808, 98);
            label1.TabIndex = 47;
            label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Khaki;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(343, 554);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(887, 119);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1520, 1090);
            Controls.Add(groupBox1);
            Controls.Add(add_button);
            Controls.Add(update_button);
            Controls.Add(delete_button);
            Controls.Add(quantityTxt);
            Controls.Add(nameTxt);
            Controls.Add(typeTxt);
            Controls.Add(idTxt);
            Controls.Add(DGW_MalList_Stokcu);
            Controls.Add(panel1);
            Controls.Add(refresh_button);
            Controls.Add(stockBack);
            Controls.Add(stockClose_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockForm";
            Load += StockForm_Load;
            ((System.ComponentModel.ISupportInitialize)stockBack).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)user_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGW_MalList_Stokcu).EndInit();
            ((System.ComponentModel.ISupportInitialize)refresh_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox stockBack;
        private Label stockClose_label;
        private Panel panel1;
        private DataGridView DGW_MalList_Stokcu;
        private TextBox idTxt;
        private TextBox typeTxt;
        private TextBox nameTxt;
        private TextBox quantityTxt;
        private Button delete_button;
        private Button add_button;
        private PictureBox user_icon;
        private Button update_button;
        private Label Label_role;
        private Label Label_username;
        private Label Label_id;
        private PictureBox pictureBox1;
        private PictureBox refresh_button;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox groupBox1;
    }
}