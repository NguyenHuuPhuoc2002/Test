using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Models;

namespace Test.GUI
{
    public partial class FormSua : Form
    {
        public SinhVien _sinhVien;
        public SinhVien sinhVienKetQua;
        public FormSua(SinhVien sinhVien)
        {
            _sinhVien = sinhVien;
            InitializeComponent();
        }

        private void FormSua_Load(object sender, EventArgs e)
        {
            txtMaSV.Text = _sinhVien.MaSV;
            txtHoTen.Text = _sinhVien.HoTen;
            cmbGioTinh.Text = _sinhVien.GioiTinh ? "Nam" : "Nữ";
            dtpNgaySinh.Value = _sinhVien.NgaySinh;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            bool gioiTinh = cmbGioTinh.SelectedIndex == 0;
            DateTime ngaySinh = dtpNgaySinh.Value;

            sinhVienKetQua = new SinhVien();
            sinhVienKetQua.MaSV = maSV;
            sinhVienKetQua.HoTen = hoTen;
            sinhVienKetQua.GioiTinh = gioiTinh;
            sinhVienKetQua.NgaySinh = ngaySinh;

            this.Close();
        }
    }
}
