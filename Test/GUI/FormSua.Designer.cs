namespace Test.GUI
{
    partial class FormSua
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
            btnLuu = new Button();
            dtpNgaySinh = new DateTimePicker();
            cmbGioTinh = new ComboBox();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(180, 277);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 17;
            btnLuu.Text = "Chỉnh Sửa";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(163, 199);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 16;
            // 
            // cmbGioTinh
            // 
            cmbGioTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioTinh.FormattingEnabled = true;
            cmbGioTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbGioTinh.Location = new Point(163, 141);
            cmbGioTinh.Name = "cmbGioTinh";
            cmbGioTinh.Size = new Size(125, 28);
            cmbGioTinh.TabIndex = 15;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(163, 87);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 27);
            txtHoTen.TabIndex = 14;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(163, 38);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(250, 27);
            txtMaSV.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 199);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 12;
            label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 149);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 11;
            label3.Text = "Giới Tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 94);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 10;
            label2.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã SV";
            // 
            // FormSua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 342);
            Controls.Add(btnLuu);
            Controls.Add(dtpNgaySinh);
            Controls.Add(cmbGioTinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSua";
            Text = "FormSua";
            Load += FormSua_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLuu;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cmbGioTinh;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}