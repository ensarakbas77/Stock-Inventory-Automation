namespace InternProject
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            logClose_label = new Label();
            logBack = new PictureBox();
            DGW_logView_admin = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Label_admin = new Label();
            user_icon = new PictureBox();
            dateTimePickerUsageDate = new DateTimePicker();
            search_button = new Button();
            ((System.ComponentModel.ISupportInitialize)logBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGW_logView_admin).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user_icon).BeginInit();
            SuspendLayout();
            // 
            // logClose_label
            // 
            logClose_label.Cursor = Cursors.Hand;
            logClose_label.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            logClose_label.Location = new Point(1691, 9);
            logClose_label.Name = "logClose_label";
            logClose_label.Size = new Size(27, 27);
            logClose_label.TabIndex = 26;
            logClose_label.Text = "X";
            logClose_label.Click += logClose_label_Click;
            // 
            // logBack
            // 
            logBack.Cursor = Cursors.Hand;
            logBack.Image = (Image)resources.GetObject("logBack.Image");
            logBack.Location = new Point(345, 9);
            logBack.Name = "logBack";
            logBack.Size = new Size(33, 27);
            logBack.SizeMode = PictureBoxSizeMode.Zoom;
            logBack.TabIndex = 27;
            logBack.TabStop = false;
            logBack.Click += logBack_Click;
            // 
            // DGW_logView_admin
            // 
            DGW_logView_admin.AllowUserToAddRows = false;
            DGW_logView_admin.AllowUserToDeleteRows = false;
            DGW_logView_admin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGW_logView_admin.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGW_logView_admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGW_logView_admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGW_logView_admin.DefaultCellStyle = dataGridViewCellStyle2;
            DGW_logView_admin.GridColor = Color.Gray;
            DGW_logView_admin.Location = new Point(344, 54);
            DGW_logView_admin.Name = "DGW_logView_admin";
            DGW_logView_admin.ReadOnly = true;
            DGW_logView_admin.RowHeadersWidth = 62;
            DGW_logView_admin.RowTemplate.Height = 33;
            DGW_logView_admin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGW_logView_admin.Size = new Size(1374, 726);
            DGW_logView_admin.TabIndex = 36;
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
            panel1.Size = new Size(339, 960);
            panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 877);
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
            Label_admin.Location = new Point(115, 225);
            Label_admin.Name = "Label_admin";
            Label_admin.Size = new Size(89, 29);
            Label_admin.TabIndex = 52;
            Label_admin.Text = "Admin";
            // 
            // user_icon
            // 
            user_icon.Cursor = Cursors.Hand;
            user_icon.Image = (Image)resources.GetObject("user_icon.Image");
            user_icon.Location = new Point(65, 35);
            user_icon.Name = "user_icon";
            user_icon.Size = new Size(192, 187);
            user_icon.SizeMode = PictureBoxSizeMode.Zoom;
            user_icon.TabIndex = 46;
            user_icon.TabStop = false;
            // 
            // dateTimePickerUsageDate
            // 
            dateTimePickerUsageDate.Location = new Point(345, 799);
            dateTimePickerUsageDate.Name = "dateTimePickerUsageDate";
            dateTimePickerUsageDate.Size = new Size(274, 31);
            dateTimePickerUsageDate.TabIndex = 46;
            // 
            // search_button
            // 
            search_button.BackColor = Color.Red;
            search_button.Cursor = Cursors.Hand;
            search_button.FlatStyle = FlatStyle.Popup;
            search_button.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            search_button.ForeColor = SystemColors.ButtonHighlight;
            search_button.Location = new Point(637, 799);
            search_button.Name = "search_button";
            search_button.Size = new Size(122, 40);
            search_button.TabIndex = 47;
            search_button.Text = "Filtrele";
            search_button.UseVisualStyleBackColor = false;
            search_button.Click += search_button_Click;
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1730, 960);
            Controls.Add(search_button);
            Controls.Add(dateTimePickerUsageDate);
            Controls.Add(DGW_logView_admin);
            Controls.Add(panel1);
            Controls.Add(logBack);
            Controls.Add(logClose_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogForm";
            Load += LogForm_Load;
            ((System.ComponentModel.ISupportInitialize)logBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGW_logView_admin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)user_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label logClose_label;
        private PictureBox logBack;
        private DataGridView DGW_logView_admin;
        private Panel panel1;
        private PictureBox user_icon;
        private PictureBox pictureBox1;
        private Label Label_admin;
        private DateTimePicker dateTimePickerUsageDate;
        private Button search_button;
    }
}