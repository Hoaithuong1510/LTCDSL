﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
	public partial class SinhVienForm : Form
	{
		QuanLySinhVien qlSV;
		public SinhVienForm()
		{
			InitializeComponent();
		}

		private SinhVien GetSinhVien()
		{
			SinhVien sv = new SinhVien();
			bool gt = true;
			List<string> cn = new List<string>();
			sv.MaSo = this.mtxtMaSo.Text;
			sv.HoTen = this.txtHoTen.Text;
			sv.NgaySinh = this.dtpNgaySinh.Value;
			sv.DiaChi = this.txtDiaChi.Text;
			sv.Lop = this.cboLop.Text;
			sv.Hinh = this.txtHinh.Text;
			if (rbNu.Checked)
				gt = false;
			sv.GioiTinh = gt;
			for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
				if (clbChuyenNganh.GetItemChecked(i))
					cn.Add(clbChuyenNganh.Items[i].ToString());
			sv.ChuyenNganh = cn;
			return sv;
		}

		private SinhVien GetSinhVienLV(ListViewItem lvitem)
		{
			SinhVien sv = new SinhVien();
			sv.MaSo = lvitem.SubItems[0].Text;
			sv.HoTen = lvitem.SubItems[1].Text;
			sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
			sv.DiaChi = lvitem.SubItems[3].Text;
			sv.Lop = lvitem.SubItems[4].Text;
			sv.GioiTinh = false;
			if (lvitem.SubItems[5].Text == "Nam")
				sv.GioiTinh = true;
			List<string> chuyenNganh = new List<string>();
			string[] s = lvitem.SubItems[6].Text.Split(',');
			foreach (string t in s)
				chuyenNganh.Add(t);
			sv.ChuyenNganh = chuyenNganh;
			sv.Hinh = lvitem.SubItems[7].Text;
			return sv;
		}

		private void ThietLapThongTin(SinhVien sv)
		{
			this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
           if (sv.GioiTinh)
              this.rbNam.Checked = true;
           else
              this.rbNu.Checked = true;
			for (int i = 0; i< this.clbChuyenNganh.Items.Count; i++)
				this.clbChuyenNganh.SetItemChecked(i, false);

			foreach (string s in sv.ChuyenNganh)
			{
				for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
					if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
						this.clbChuyenNganh.SetItemChecked(i, true);
			}
		}

		private void ThemSV(SinhVien sv)
		{
			ListViewItem lvitem = new ListViewItem(sv.MaSo);
			lvitem.SubItems.Add(sv.HoTen);
			lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
			lvitem.SubItems.Add(sv.DiaChi);
			lvitem.SubItems.Add(sv.Lop);
			string gt = "Nữ";
			if (sv.GioiTinh)
				gt = "Nam";
			lvitem.SubItems.Add(gt);
			string cn = "";
			foreach (string s in sv.ChuyenNganh)
				cn += s + ",";
			cn = cn.Substring(0, cn.Length - 1);
			lvitem.SubItems.Add(cn);
			lvitem.SubItems.Add(sv.Hinh);
			this.lvSinhVien.Items.Add(lvitem);
		}

		private void LoadListView()
		{
			this.lvSinhVien.Items.Clear();
			foreach (SinhVien sv in qlSV.dsSinhVien)
			{
				ThemSV(sv);
			}
		}

		private void SinhVienForm_Load(object sender, EventArgs e)
		{
			qlSV = new QuanLySinhVien();
			qlSV.DocTuFile();
			LoadListView();
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

		private void btnAdd_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			SinhVien kq = qlSV.Tim(sv.MaSo, delegate (object obj1, object obj2)
			{
				return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
			});
			if (kq != null)
				MessageBox.Show("Mã sinh viên đã tồn tại!","Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				this.qlSV.Them(sv);
				this.LoadListView();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int i, count;
			ListViewItem lvitem;
			count = this.lvSinhVien.Items.Count - 1;
			for (i = count; i >= 0; i--)
			{
				lvitem = this.lvSinhVien.Items[i];
				if (lvitem.Checked)
					qlSV.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
			}
			this.LoadListView();
			this.btnDefault.PerformClick();
		}

		private int SoSanhTheoMa(object obj1, object obj2)
		{
			SinhVien sv = obj2 as SinhVien;
			return sv.MaSo.CompareTo(obj1);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnDefault_Click(object sender, EventArgs e)
		{
			this.mtxtMaSo.Text = "";
			this.txtHoTen.Text = "";
			this.dtpNgaySinh.Value = DateTime.Now;
			this.txtDiaChi.Text = "";
			this.cboLop.Text = this.cboLop.Items[0].ToString();
			this.txtHinh.Text = "";
			this.pbHinh.ImageLocation = "";
			this.rbNam.Checked = true;
			for (int i = 0; i < this.clbChuyenNganh.Items.Count - 1; i++)
				this.clbChuyenNganh.SetItemChecked(i, false);
		}

		private void btnFix_Click(object sender, EventArgs e)
		{
			try
			{
				SinhVien sv = GetSinhVien();
				qlSV.Sua(sv, sv.MaSo, SoSanhTheoMa); 
					 this.LoadListView();
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message, "Lỗi sửa thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void totalBar()
		{
			sttLabelTongSV.Text = "Tổng Số Sinh Viên: " + qlSV.dsSinhVien.Count;
		}
		private void btnBrowse_Click(object sender, EventArgs e)
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

		private void menuItemOpen_Click(object sender, EventArgs e)
		{
			btnBrowse.PerformClick();
		}

		private void menuItemExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void menuItemAdd_Click(object sender, EventArgs e)
		{
			btnAdd.PerformClick();
		}

		private void menuItemDelete_Click(object sender, EventArgs e)
		{
			btnDelete.PerformClick();
		}

		private void menuItemEdit_Click(object sender, EventArgs e)
		{
			btnFix.PerformClick();
		}

		private void menuItemFontChu_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = fontDialog1;
			var fontChu = fontDialog.ShowDialog();

			if (fontChu == DialogResult.OK)
			{
				lvSinhVien.Font = fontDialog.Font;
			}
		}

		private void menuItemFontMau_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			var fontMau = colorDialog.ShowDialog();

			if (fontMau == DialogResult.OK)
			{
				lvSinhVien.ForeColor = colorDialog.Color;
			}
		}

		private void menuItemSapXep_Click(object sender, EventArgs e)
		{
			var formTuyChon = new frmTuyChon(qlSV, lvSinhVien, "sort");
			formTuyChon.ShowDialog();
		}

		private void menuItemTimKiem_Click(object sender, EventArgs e)
		{
			var formTuyChon = new frmTuyChon(qlSV, lvSinhVien, "find");
			formTuyChon.ShowDialog();
		}
	}
}
