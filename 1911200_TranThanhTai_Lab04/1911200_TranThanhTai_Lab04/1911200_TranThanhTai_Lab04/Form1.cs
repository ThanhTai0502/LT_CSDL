using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911200_TranThanhTai_Lab04
{
	public partial class Form1 : Form
	{
		QuanLySinhVien QLSV;

		public Form1()
		{
			InitializeComponent();
		}
		private SinhVien GetSinhVien()
		{
			SinhVien SV = new SinhVien();
			bool gt = true;
			SV.MSSV = this.mktbMSSV.Text;
			SV.HoTen = this.txtFullName.Text;
			if (rdNu.Checked)
				gt = false;
			SV.Phai = gt;
			SV.NgaySinh = this.dtpkNgaySinh.Value;
			SV.Lop = this.cbbLop.Text;
			SV.SĐT = this.mktbSĐT.Text;
			SV.Email = this.txtEmail.Text;
			SV.DiaChi = this.txtAddress.Text;
			SV.Hinh = this.txtHinh.Text;
			return SV;
		}
		private SinhVien GetSinhVienLV(ListViewItem lvitem)
		{
			SinhVien SV = new SinhVien();
			SV.MSSV = lvitem.SubItems[0].Text;
			SV.HoTen = lvitem.SubItems[1].Text;
			SV.Phai = false;
			if (lvitem.SubItems[2].Text == "Nam")
				SV.Phai = true;
			SV.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
			SV.Lop = lvitem.SubItems[4].Text;
			SV.SĐT = lvitem.SubItems[5].Text;
			SV.Email = lvitem.SubItems[6].Text;
			SV.DiaChi = lvitem.SubItems[7].Text;
			SV.Hinh = lvitem.SubItems[8].Text;
			return SV;
		}
		private void ThietLapThongTin(SinhVien SV)
		{
			this.mktbMSSV.Text = SV.MSSV;
			this.txtFullName.Text = SV.HoTen;
			if (SV.Phai)
				this.rdNam.Checked = true;
			else
				this.rdNu.Checked = true;
			this.dtpkNgaySinh.Value = SV.NgaySinh;
			this.cbbLop.Text = SV.Lop;
			this.mktbSĐT.Text = SV.SĐT;
			this.txtEmail.Text = SV.Email;
			this.txtAddress.Text = SV.DiaChi;
			this.txtHinh.Text = SV.Hinh;
			this.pbHinh.ImageLocation = SV.Hinh;
		}
		private void ThemSV(SinhVien SV)
		{
			ListViewItem lvitem = new ListViewItem(SV.MSSV);
			lvitem.SubItems.Add(SV.HoTen);
			string gt = "Nữ";
			if (SV.Phai)
				gt = "Nam";
			lvitem.SubItems.Add(gt);
			lvitem.SubItems.Add(SV.NgaySinh.ToShortDateString());
			lvitem.SubItems.Add(SV.Lop);
			lvitem.SubItems.Add(SV.SĐT);
			lvitem.SubItems.Add(SV.Email);
			lvitem.SubItems.Add(SV.DiaChi);
			lvitem.SubItems.Add(SV.Hinh);
			this.lvSinhVien.Items.Add(lvitem);
		}
		private void CapNhatSV(SinhVien SV)
		{
			bool gt = true;
			SV.MSSV = this.mktbMSSV.Text;
			SV.HoTen = this.txtFullName.Text;
			if (rdNu.Checked)
				gt = false;
			SV.Phai = gt;
			SV.NgaySinh = this.dtpkNgaySinh.Value;
			SV.Lop = this.cbbLop.Text;
			SV.SĐT = this.mktbSĐT.Text;
			SV.Email = this.txtEmail.Text;
			SV.DiaChi = this.txtAddress.Text;
			SV.Hinh = this.txtHinh.Text;
		}
		private void LoadListView(List<SinhVien> danhsach)
		{
			this.lvSinhVien.Items.Clear();
			foreach(SinhVien SV in QLSV.DsSV)
			{
				ThemSV(SV);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			QLSV = new QuanLySinhVien();
			QLSV.DocTuFile();
			LoadListView(QLSV.DsSV);
		}

		private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			int count = this.lvSinhVien.SelectedItems.Count;
			if(count > 0)
			{
				ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
				SinhVien SV = GetSinhVienLV(lvitem);
				ThietLapThongTin(SV);
			}
		}

		private void btnChonHinh_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Title = "Open File Image";
			file.Filter = "Image Files (BMP, JPEG, PNG)|"
				+ "*.bmp;*.jpg;*.jpeg;*.png|"
				+ "BMP files (*.bmp)|*.bmp|"
				+ "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
				+ "PNG files (*.png)|*.png|"
				+ "All files (*.*)|*.*";
			file.InitialDirectory = Environment.CurrentDirectory;
			if(file.ShowDialog() == DialogResult.OK)
			{
				var fileName = file.FileName;
				txtHinh.Text = fileName;
				pbHinh.Load(fileName);
			}
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			this.mktbMSSV.Text = "";
			this.txtFullName.Text = "";
			this.rdNam.Checked = true;
			this.dtpkNgaySinh.Value = DateTime.Now;
			this.cbbLop.Text = this.cbbLop.Items[0].ToString();
			this.mktbSĐT.Text = "";
			this.txtEmail.Text = "";
			this.txtAddress.Text = "";
			this.txtHinh.Text = "";
			this.pbHinh.ImageLocation = "";
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			SinhVien SV = GetSinhVien();
			SinhVien kq = QLSV.Tim(SV.MSSV, delegate (object obj1, object obj2)
			{
				return (obj2 as SinhVien).MSSV.CompareTo(obj1.ToString());
			});
			if (kq != null)
				MessageBox.Show("Mã sinh viên tồn tại! Bạn có chắc chắn sẽ cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			else
			{
				MessageBox.Show("Đã thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.QLSV.Them(SV);
				this.LoadListView(QLSV.DsSV);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MenuItemReload_Click(object sender, EventArgs e)
		{
			QLSV.DocTuFile();
			LoadListView(QLSV.DsSV);
		}

		private void MenuItemDelete_Click(object sender, EventArgs e)
		{
			int count, i;
			ListViewItem item;
			count = lvSinhVien.Items.Count - 1;
			for(i = count; i >= 0; i--)
			{
				item = lvSinhVien.Items[i];
				if (item.Selected)
					QLSV.Xoa(item.SubItems[0].Text, SoSanhTheoMa);
			}
			LoadListView(QLSV.DsSV);
		}
		private int SoSanhTheoMa(object sv1, object sv2)
		{
			SinhVien SV = sv2 as SinhVien;
			return SV.MSSV.CompareTo(sv1);
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đôi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No)
				Application.Exit();
			if (result == DialogResult.Yes)
				QLSV.GhiVaoFile(QLSV.LuuSV());
		}
	}
}
