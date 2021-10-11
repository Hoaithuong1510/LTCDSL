using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
	public partial class frmSinhVien : Form
	{
		SVContext context;
		private List<string> dsMon;
		private List<SinhVien> dssv;
		QuanLySinhVien qlsv;

		public frmSinhVien(SVContext context)
		{
			InitializeComponent();
			this.context = context;
			dssv = context.GetSV();
			dsMon = new List<string>
			{
				"Mạng máy tính",
				"Hệ điều hành",
				"Lập trình CSDL",
				"Lập trình mạng",
				"Đồ án cơ sở",
				"Phương pháp NCKH",
				"Lập trình trên thiết bị di động",
				"An toàn và bảo mật hệ thống"
			};
		}

		private void ThemSV(SinhVien sv)
		{
			ListViewItem item = new ListViewItem(sv.MaSo);
			item.SubItems.Add(sv.HoTenLot);
			item.SubItems.Add(sv.Ten);
			item.SubItems.Add(sv.NgaySinh.ToShortDateString());
			item.SubItems.Add(sv.Lop);
			item.SubItems.Add(sv.SoCMND);
			item.SubItems.Add(sv.SĐT);
			item.SubItems.Add(sv.DiaChi);
			item.SubItems.Add(sv.GioiTinh == true ? "Nam" : "Nu");
			item.SubItems.Add(string.Join(",", sv.dsDangKyMonHoc));

			lvDanhSachSV.Items.Add(item);
		}

		private void LoadSVToListView(List<SinhVien> danhsach)
		{
			lvDanhSachSV.Items.Clear();
			foreach (SinhVien sv in danhsach)
				ThemSV(sv);
		}

		private SinhVien GetSVLV(ListViewItem item)
		{
			SinhVien sv = new SinhVien();
			sv.MaSo = item.SubItems[0].Text;
			sv.HoTenLot = item.SubItems[1].Text;
			sv.Ten = item.SubItems[2].Text;
			sv.NgaySinh = DateTime.Parse(item.SubItems[3].Text);
			sv.Lop = item.SubItems[4].Text;
			sv.SoCMND = item.SubItems[5].Text;
			sv.SĐT = item.SubItems[6].Text;
			sv.DiaChi = item.SubItems[7].Text;
			sv.GioiTinh = item.SubItems[8].Text == "Nam" ? true : false;
			sv.dsDangKyMonHoc = new List<string>(item.SubItems[9].Text.Split(new string[] { "," }, StringSplitOptions.None));

			return sv;
		}

		private void ThietLapControl(SinhVien sv)
		{
			txtMSSV.Text = sv.MaSo;
			txtHoTenLot.Text = sv.HoTenLot;
			txtTen.Text = sv.Ten;
			dtpNgaySinh.Value = sv.NgaySinh;
			cboLop.Text = sv.Lop;
			txtCMND.Text = sv.SoCMND;
			txtSĐT.Text = sv.SĐT;
			txtDiaChi.Text = sv.DiaChi;
			rbNam.Checked = (sv.GioiTinh == true ? true : false);
			rbNu.Checked = (sv.GioiTinh == false ? true : false);
			for (int i = 0; i < clbMonHocDK.Items.Count; i++)
				clbMonHocDK.SetItemChecked(i, false);
			foreach (var mh in sv.dsDangKyMonHoc)
			{
				for (int i = 0; i < clbMonHocDK.Items.Count; i++)
				{
					if (clbMonHocDK.Items[i].ToString().CompareTo(mh) == 0)
						clbMonHocDK.SetItemChecked(i, true);
				}
			}
		}

		private SinhVien GetSVControl()
		{
			SinhVien sv = new SinhVien();
			sv.MaSo = txtMSSV.Text;
			sv.HoTenLot = txtHoTenLot.Text;
			sv.Ten = txtTen.Text;
			sv.NgaySinh = dtpNgaySinh.Value;
			sv.Lop = cboLop.Text;
			sv.SoCMND = txtCMND.Text;
			sv.SĐT = txtSĐT.Text;
			sv.DiaChi = txtDiaChi.Text;
			sv.GioiTinh = (rbNam.Checked == true ? true : false);
			List<string> dsmh = new List<string>();
			foreach (var item in clbMonHocDK.CheckedItems)
			{
				dsmh.Add(item as string);
			}
			sv.dsDangKyMonHoc = dsmh;
			return sv;
		}

		private SinhVien UpdateSV(SinhVien sv)
		{
			SinhVien svUpdate = GetSVControl();
			sv.MaSo = svUpdate.MaSo;
			sv.HoTenLot = svUpdate.HoTenLot;
			sv.Ten = svUpdate.Ten;
			sv.NgaySinh = svUpdate.NgaySinh;
			sv.Lop = svUpdate.Lop;
			sv.SoCMND = svUpdate.SoCMND;
			sv.SĐT = svUpdate.SĐT;
			sv.DiaChi = svUpdate.DiaChi;
			sv.GioiTinh = svUpdate.GioiTinh;
			sv.dsDangKyMonHoc = svUpdate.dsDangKyMonHoc;
			return sv;
		}

		private void frmSinhVien_Load(object sender, EventArgs e)
		{
			foreach (var item in dsMon)
				clbMonHocDK.Items.Add(item, false);
			qlsv = new QuanLySinhVien(context);
			LoadSVToListView(qlsv.dssv);
		}

		private void lvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
		{
			int count = lvDanhSachSV.SelectedItems.Count;
			if (count > 0)
			{
				ListViewItem item = lvDanhSachSV.SelectedItems[0];
				ThietLapControl(GetSVLV(item));
			}
		}
	}
}
