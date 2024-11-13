namespace Test.GUI
{
    partial class FormThem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            cmbGioTinh = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            btnThem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 94);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 149);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 199);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(156, 38);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(250, 27);
            txtMaSV.TabIndex = 4;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(156, 87);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 27);
            txtHoTen.TabIndex = 5;
            // 
            // cmbGioTinh
            // 
            cmbGioTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioTinh.FormattingEnabled = true;
            cmbGioTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbGioTinh.Location = new Point(156, 141);
            cmbGioTinh.Name = "cmbGioTinh";
            cmbGioTinh.Size = new Size(125, 28);
            cmbGioTinh.TabIndex = 6;
            cmbGioTinh.SelectedIndexChanged += cmbGioTinh_SelectedIndexChanged;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(156, 199);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 7;
            dtpNgaySinh.Value = new DateTime(2024, 11, 7, 0, 0, 0, 0);
            // 
            // btnThem
            // 
            btnThem.Location = new Point(173, 277);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // FormThem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 349);
            Controls.Add(btnThem);
            Controls.Add(dtpNgaySinh);
            Controls.Add(cmbGioTinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormThem";
            Text = "FormThem";
            Load += FormThem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private ComboBox cmbGioTinh;
        private DateTimePicker dtpNgaySinh;
        private Button btnThem;
    }
}