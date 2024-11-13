using Test.DAO;
using Test.GUI;
using Test.Models;

namespace Test
{
    public partial class Form1 : Form
    {
        public SinhVienDAO svDao;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            svDao = new SinhVienDAO();
            var svList = svDao.ReadHinhFromFile("D:\\KiemTra_Desktop\\Test\\Test\\SinhVien.txt");
            bsSinhVien.DataSource = svList;
            dgvSinhVien.DataSource = bsSinhVien; 
            dgvSinhVien.AllowUserToAddRows = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bsSinhVien.RemoveCurrent();

            var lst = bsSinhVien.DataSource as List<SinhVien>;

            svDao.SaveHinhToFile(lst, "D:\\KiemTra_Desktop\\Test\\Test\\SinhVien.txt");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sv = bsSinhVien.Current as SinhVien;
            FormSua frm = new FormSua(sv);
            frm.ShowDialog(this);

            if (bsSinhVien.Current == null)
                return;

            if (frm.sinhVienKetQua != null)
            {
                var sinhVien = frm.sinhVienKetQua;
                sv.HoTen = sinhVien.HoTen;
                sv.MaSV = sinhVien.MaSV;
                sv.NgaySinh = sinhVien.NgaySinh;
                sv.GioiTinh = sinhVien.GioiTinh;
                bsSinhVien.ResetCurrentItem();

                var list = bsSinhVien.DataSource as List<SinhVien>;
                svDao.SaveHinhToFile(list, "D:\\KiemTra_Desktop\\Test\\Test\\SinhVien.txt");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThem frm = new FormThem();
            frm.ShowDialog();

            if (bsSinhVien.Current == null)
                return;

            if (frm.sinhVienKetQua != null)
            {
                var sinhVien = frm.sinhVienKetQua;
                bsSinhVien.Add(sinhVien);

                var list = bsSinhVien.DataSource as List<SinhVien>;
                svDao.SaveHinhToFile(list, "D:\\KiemTra_Desktop\\Test\\Test\\SinhVien.txt");
            }
        }
    }
}
