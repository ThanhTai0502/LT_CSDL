using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911200_TranThanhTai_Lab04
{
	

	public class QuanLySinhVien
	{
		public delegate int SoSanh(object sv1, object sv2);
		public List<SinhVien> DsSV;

		public QuanLySinhVien()
		{
			this.DsSV = new List<SinhVien>();
		}
		public void Them(SinhVien SV)
		{
			this.DsSV.Add(SV);
		}
		public SinhVien this[int index]
		{
			get { return DsSV[index]; }
			set { DsSV[index] = value; }
		}
		public void Xoa(object obj, SoSanh ss)
		{
			int i = DsSV.Count - 1;
			for (; i > 0; i--)
				if (ss(obj, this[i]) == 0)
					this.DsSV.RemoveAt(i);
		}
		public SinhVien Tim(object obj, SoSanh ss)
		{
			SinhVien SV = null;
			foreach (SinhVien item in DsSV)
			{
				if(ss(obj, item) == 0)
				{
					SV = item;
					break;
				}
			}
			return SV;
		}
		public bool Sua(SinhVien svSua, object obj, SoSanh ss)
		{
			int i, count;
			bool kq = false;
			count = this.DsSV.Count - 1;
			for (i = 0; i < count; i++)
			{
				if(ss(obj, this[i]) == 0)
				{
					this[i] = svSua;
					kq = true;
					break;
				}
			}
			return kq;
		}
		public void DocTuFile()
		{
			string fileName = "DSSV.txt", t;
			string[] s;
			SinhVien SV;
			StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
			while((t = sr.ReadLine()) != null)
			{
				s = t.Split('*');
				SV = new SinhVien();
				SV.MSSV = s[0];
				SV.HoTen = s[1];
				bool gt = (s[2] == "1" ? true : false);
				SV.Phai = gt;
				SV.NgaySinh = DateTime.Parse(s[3]);
				SV.Lop = s[4];
				SV.SĐT = s[5];
				SV.Email = s[6];
				SV.DiaChi = s[7];
				SV.Hinh = s[8];
				Them(SV);
			}
		}
		public List<SinhVien> LuuSV()
		{
			return DsSV;
		}
		public void GhiVaoFile(List<SinhVien> list)
		{
			string fileName = "DSSV.txt";
			using(StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
			{
				foreach(var SV in list)
				{
					sw.WriteLine(SV.ToString());
				}
			}
		}
	}
}
