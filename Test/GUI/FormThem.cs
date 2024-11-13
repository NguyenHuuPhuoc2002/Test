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
    public partial class FormThem : Form
    {
        public SinhVien sinhVienKetQua;
        public FormThem()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
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

        private void cmbGioTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormThem_Load(object sender, EventArgs e)
        {
            cmbGioTinh.SelectedIndex = 0;
        }
    }
}
