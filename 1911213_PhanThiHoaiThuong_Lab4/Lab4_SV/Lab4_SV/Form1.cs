using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_SV
{
	public partial class ThongTinForm : Form
	{
		QuanLySinhVien qlSV;
		public ThongTinForm()
		{
			InitializeComponent();
		}
		private SinhVien GetSinhVien()
		{
			SinhVien sv = new SinhVien();
			bool gt = true;
			sv.MSSV = this.mktbMSSV.Text;
			sv.HoTen = this.txtHoTen.Text;
			if (rbNu.Checked)
				gt = false;
			sv.Phai = gt;
			sv.NgaySinh = this.dtpNgaySinh.Value;
			sv.Lop = this.cboLop.Text;
			sv.Sdt = this.mktbSDT.Text;
			sv.Email = this.txtEmail.Text;
			sv.DiaChi = this.txtDiaChi.Text;
			sv.Hinh = this.txtHinh.Text;
			return sv;
		}

		private SinhVien GetSinhVienLV(ListViewItem lvitem)
		{
			SinhVien sv = new SinhVien();
			sv.MSSV = lvitem.SubItems[0].Text;
			sv.HoTen = lvitem.SubItems[1].Text;
			sv.Phai = false;
			if (lvitem.SubItems[2].Text == "Nam")
				sv.Phai = true;
			sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
			sv.Lop = lvitem.SubItems[4].Text;
			sv.Sdt = lvitem.SubItems[5].Text;
			sv.Email = lvitem.SubItems[6].Text;
			sv.DiaChi = lvitem.SubItems[7].Text;
			sv.Hinh = lvitem.SubItems[8].Text;
			return sv;
		}

		private void ThietLapThongTin(SinhVien sv)
		{
			this.mktbMSSV.Text = sv.MSSV;
			this.txtHoTen.Text = sv.HoTen;
			if (sv.Phai)
				this.rbNam.Checked = true;
			else
				this.rbNu.Checked = true;
			this.dtpNgaySinh.Value = sv.NgaySinh;
			this.cboLop.Text = sv.Lop;
			this.mktbSDT.Text = sv.Sdt;
			this.txtEmail.Text = sv.Email;
			this.txtDiaChi.Text = sv.DiaChi;
			this.txtHinh.Text = sv.Hinh;
			this.pbHinh.ImageLocation = sv.Hinh;
		}

		private void ThemSV(SinhVien sv)
		{
			ListViewItem lvitem = new ListViewItem(sv.MSSV);
			lvitem.SubItems.Add(sv.HoTen);
			string gt = "Nữ";
			if (sv.Phai)
				gt = "Nam";
			lvitem.SubItems.Add(gt);
			lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
			lvitem.SubItems.Add(sv.Lop);
			lvitem.SubItems.Add(sv.Sdt);
			lvitem.SubItems.Add(sv.Email);
			lvitem.SubItems.Add(sv.DiaChi);
			lvitem.SubItems.Add(sv.Hinh);
			this.lvSinhVien.Items.Add(lvitem);
		}
		private void CapNhatSV(SinhVien sv)
		{
			bool gt = true;
			sv.MSSV = this.mktbMSSV.Text;
			sv.HoTen = this.txtHoTen.Text;
			if (rbNu.Checked)
				gt = false;
			sv.Phai = gt;
			sv.NgaySinh = this.dtpNgaySinh.Value;
			sv.Lop = this.cboLop.Text;
			sv.Sdt = this.mktbSDT.Text;
			sv.Email = this.txtEmail.Text;
			sv.DiaChi = this.txtDiaChi.Text;
			sv.Hinh = this.txtHinh.Text;
		}
		private void LoadListView(List<SinhVien> danhsach)
		{
			this.lvSinhVien.Items.Clear();
			foreach (SinhVien sv in qlSV.dsSV)
			{
				ThemSV(sv);
			}
		}

		private void ThongTinForm_Load(object sender, EventArgs e)
		{
			qlSV = new QuanLySinhVien();
			qlSV.DocTuFile();
			LoadListView(qlSV.dsSV);
		}

		private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			int count = this.lvSinhVien.SelectedItems.Count;
			if (count > 0)
			{
				ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
				SinhVien sv = GetSinhVienLV(lvitem);
				ThietLapThongTin(sv);
			}
		}

		private void btnChon_Click(object sender, EventArgs e)
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
			if (file.ShowDialog() == DialogResult.OK)
			{
				var fileName = file.FileName;
				txtHinh.Text = fileName;
				pbHinh.Load(fileName);
			}
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			this.mktbMSSV.Text = "";
			this.txtHoTen.Text = "";
			this.rbNam.Checked = true;
			this.dtpNgaySinh.Value = DateTime.Now;
			this.cboLop.Text = this.cboLop.Items[0].ToString();
			this.mktbSDT.Text = "";
			this.txtEmail.Text = "";
			this.txtDiaChi.Text = "";
			this.txtHinh.Text = "";
			this.pbHinh.ImageLocation = "";

		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			SinhVien kq = qlSV.Tim(sv.MSSV, delegate (object obj1, object obj2)
			{
				return (obj2 as SinhVien).MSSV.CompareTo(obj1.ToString());
			});
			if (kq != null)
				MessageBox.Show("Mã sinh viên đã tồn tại! Bạn có muốn cập nhật không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			else
			{
				MessageBox.Show("Đã thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.qlSV.Them(sv);
				this.LoadListView(qlSV.dsSV);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void menuItemDelete_Click(object sender, EventArgs e)
		{
			int count, i;
			ListViewItem item;
			count = lvSinhVien.Items.Count - 1;
			for (i = count; i >= 0; i--)
			{
				item = lvSinhVien.Items[i];
				if (item.Selected)
					qlSV.Xoa(item.SubItems[0].Text, SoSanhTheoMa);
			}
			LoadListView(qlSV.dsSV);
		}

		private int SoSanhTheoMa(object sv1, object sv2)
		{
			SinhVien sv = sv2 as SinhVien;
			return sv.MSSV.CompareTo(sv1);
		}

		private void menuItemReload_Click(object sender, EventArgs e)
		{
			qlSV.DocTuFile();
			LoadListView(qlSV.dsSV);
		}

		private void ThongTinForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No)
				Application.Exit();
			if (result == DialogResult.Yes)
				qlSV.GhiVaoFile(qlSV.LayDSSV());
		}
	}
}
