using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911200_TranThanhTai_Lab04
{
	public class SinhVien
	{
		public string MSSV { get; set; }
		public string HoTen { get; set; }
		public bool Phai { get; set; }
		public DateTime NgaySinh { get; set; }
		public string Lop { get; set; }
		public string SĐT { get; set; }
		public string Email { get; set; }
		public string DiaChi { get; set; }
		public string Hinh { get; set; }

		public SinhVien()
		{
		}
		public SinhVien(string mssv, string hoTen, bool phai, DateTime ngaySinh, string lop, string sdt, string email, string diaChi, string hinh)
		{
			this.MSSV = mssv;
			this.HoTen = hoTen;
			this.Phai = phai;
			this.NgaySinh = ngaySinh;
			this.Lop = lop;
			this.SĐT = sdt;
			this.Email = email;
			this.DiaChi = diaChi;
			this.Hinh = hinh;
		}
		public override string ToString()
		{
			return String.Format("{0}*{1}*{2}*{3}*{4}*{5}*{6}*{7}*{8}*", MSSV, HoTen, Phai, NgaySinh, Lop, SĐT, Email, DiaChi, Hinh);
		}
	}
}


