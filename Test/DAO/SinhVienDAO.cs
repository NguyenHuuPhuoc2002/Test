using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.DAO
{
    public class SinhVienDAO
    {
        public List<SinhVien> ReadHinhFromFile(string path)
        {
            var svList = new List<SinhVien>();

            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                var maSV = parts[0];
                var hoTen = parts[1].Trim();
                DateTime ngaySinh;
                if (!DateTime.TryParse(parts[3].Trim(), out ngaySinh))
                {
                    Console.WriteLine("Dữ liệu không hợp lệ.");
                }

                var sinhVien = new SinhVien();
                sinhVien.MaSV = maSV;
                sinhVien.HoTen = hoTen;
                sinhVien.GioiTinh = parts[2].Trim() == "1";
                sinhVien.NgaySinh = ngaySinh;

                svList.Add(sinhVien);
            }

            return svList;
        }

        public void SaveHinhToFile(List<SinhVien> svList, string path)
        {
            using var writer = new StreamWriter(path);
            foreach (var sv in svList)
            {
                writer.WriteLine(sv.MaSV + "|" + sv.HoTen + "|" + (sv.GioiTinh ? "1" : "0") + "|" + sv.NgaySinh.ToString("dd/MM/yyyy"));

            }
        }
    }
}
