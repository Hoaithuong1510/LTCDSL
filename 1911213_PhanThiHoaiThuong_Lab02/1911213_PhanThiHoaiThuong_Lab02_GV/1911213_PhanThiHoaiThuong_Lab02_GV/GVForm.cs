using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911213_PhanThiHoaiThuong_Lab02_GV
{
	public partial class GiaoVienForm : Form
	{
	    QuanLyGiaoVien quanLyGV = new QuanLyGiaoVien();
		public GiaoVienForm()
		{
			InitializeComponent();
		}

		private void GiaoVienForm_Load(object sender, EventArgs e)
		{
			string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
			this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
			this.cbbMaSo.SelectedItem = this.cbbMaSo.Items[0];
		}

		private void btnChon_Click(object sender, EventArgs e)
		{
			int i = this.lbDanhSachMH.SelectedItems.Count - 1;
			while (i >= 0)
			{
				this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
				this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
				i--;
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int i = this.lbMonHocDay.SelectedItems.Count - 1;
			while (i >= 0)
			{
				this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
				this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
				i--;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void Reset()
		{
			this.cbbMaSo.Text = "";
			this.txtHoTen.Text = "";
			this.txtMail.Text = "";
			this.mktbSoĐT.Text = "";
			this.rdNam.Checked = true;

			for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
				chklbNgoaiNgu.SetItemChecked(i, false);

			foreach (object ob in this.lbMonHocDay.Items)
				this.lbDanhSachMH.Items.Add(ob);
			this.lbMonHocDay.Items.Clear();
		}

		private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string s = e.Link.LinkData.ToString();
			Process.Start(s);
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			TBGiaoVienForm frm = new TBGiaoVienForm();
			frm.SetText(GetGiaoVien().ToString());
			frm.ShowDialog();
		}

		public GiaoVien GetGiaoVien()
		{
			string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
			GiaoVien gv = new GiaoVien();
			gv.MaSo = this.cbbMaSo.Text;
			gv.GioiTinh = gioiTinh;
			gv.HoTen = this.txtHoTen.Text;
			gv.NgaySinh = this.dtpNgaySinh.Value;
			gv.Mail = this.txtMail.Text;
			gv.SoDT = this.mktbSoĐT.Text;

			List<string> ngoaingu = new List<string>();
			for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
			{
				if (chklbNgoaiNgu.GetItemChecked(i))
					ngoaingu.Add(chklbNgoaiNgu.Items[i].ToString());
			}

			DanhMucMonHoc mh = new DanhMucMonHoc();
			foreach (object ob in lbMonHocDay.Items)
			{
				mh.Them(new MonHoc(ob.ToString()));
			}

			gv.dsMonHoc = mh;

			return gv;
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			TimKiemForm frm = new TimKiemForm(quanLyGV);
			frm.ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var giaoVien = GetGiaoVien();

			var success = quanLyGV.Add(giaoVien);
			if (!success)
				MessageBox.Show("Giáo viên có mã số " + giaoVien.MaSo + " đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				MessageBox.Show("Thêm giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
