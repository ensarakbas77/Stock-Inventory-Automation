namespace InternProject
{
    partial class IntermediateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntermediateForm));
            apply_button = new Button();
            pcIDTxt = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            intermediateClose_Lbl = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // apply_button
            // 
            apply_button.BackColor = Color.Red;
            apply_button.Cursor = Cursors.Hand;
            apply_button.FlatStyle = FlatStyle.Popup;
            apply_button.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            apply_button.ForeColor = SystemColors.ButtonHighlight;
            apply_button.Location = new Point(148, 206);
            apply_button.Name = "apply_button";
            apply_button.Size = new Size(115, 40);
            apply_button.TabIndex = 42;
            apply_button.Text = "Onayla";
            apply_button.UseVisualStyleBackColor = false;
            apply_button.Click += apply_button_Click;
            // 
            // pcIDTxt
            // 
            pcIDTxt.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            pcIDTxt.Location = new Point(132, 153);
            pcIDTxt.Name = "pcIDTxt";
            pcIDTxt.PlaceholderText = "PC ID";
            pcIDTxt.Size = new Size(150, 34);
            pcIDTxt.TabIndex = 43;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Khaki;
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(label2);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Location = new Point(42, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 63);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Khaki;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 46;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Khaki;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(70, 8);
            label2.Name = "label2";
            label2.Size = new Size(258, 50);
            label2.TabIndex = 47;
            label2.Text = "-Bilgisayar ID'sini doğru bir \r\nşekilde girin.\r\n";
            // 
            // intermediateClose_Lbl
            // 
            intermediateClose_Lbl.Cursor = Cursors.Hand;
            intermediateClose_Lbl.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            intermediateClose_Lbl.Location = new Point(400, 9);
            intermediateClose_Lbl.Name = "intermediateClose_Lbl";
            intermediateClose_Lbl.Size = new Size(27, 27);
            intermediateClose_Lbl.TabIndex = 51;
            intermediateClose_Lbl.Text = "X";
            intermediateClose_Lbl.Click += intermediateClose_Lbl_Click;
            // 
            // Intermediate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(430, 270);
            Controls.Add(intermediateClose_Lbl);
            Controls.Add(groupBox2);
            Controls.Add(pcIDTxt);
            Controls.Add(apply_button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Intermediate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Intermediate";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button apply_button;
        private TextBox pcIDTxt;
        private GroupBox groupBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label intermediateClose_Lbl;
    }
}