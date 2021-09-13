using System;
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
	public partial class frmTuyChon : Form
	{
		QuanLySinhVien quanLySV;
		ListView listView;
		public frmTuyChon()
		{
			InitializeComponent();
		}

		public frmTuyChon(QuanLySinhVien qlsv, ListView lv, string loai)
		{
			InitializeComponent();
			this.quanLySV = qlsv;
			this.listView = lv;

			if (loai == "find")
			{
				btnSapXep.Enabled = false;
			}
			else 
			{
				lbNhap.Enabled = false;
				txtText.Enabled = false;
				btnFind.Enabled = false;
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			SinhVien sinhVien = null;

			if (rbMaSV.Checked)
				sinhVien = quanLySV.dsSinhVien.Find(s => s.MaSo.Trim() == txtText.Text.Trim());
			else if (rbHoTen.Checked)
				sinhVien = quanLySV.dsSinhVien.Find(s => s.HoTen.Contains(txtText.Text.Trim()));
			else if (rbNgaySinh.Checked)
				sinhVien = quanLySV.dsSinhVien.Find(s => s.NgaySinh.Day == int.Parse(txtText.Text));

			if (sinhVien == null)
			{
				MessageBox.Show("Hãy nhập thông tin tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			this.Close();

			ListViewItem item = new ListViewItem(sinhVien.MaSo);
			item.SubItems.Add(sinhVien.HoTen);
			item.SubItems.Add(sinhVien.NgaySinh.ToString("dd/MM/yyyy"));
			item.SubItems.Add(sinhVien.DiaChi);
			item.SubItems.Add(sinhVien.Lop);
			item.SubItems.Add(sinhVien.GioiTinh ? "Nam" : "Nữ");
			item.SubItems.Add(String.Join(", ", sinhVien.ChuyenNganh));
			item.SubItems.Add(sinhVien.Hinh);

			listView.Items.Clear();
			listView.Items.Add(item);
		}

		public class SinhVienSortMaSo : IComparer<SinhVien>
		{
			public int Compare(SinhVien x, SinhVien y)
			{
				return int.Parse(x.MaSo) - int.Parse(y.MaSo);
			}
		}

		public class SinhVienSortHoTen : IComparer<SinhVien>
		{
			public int Compare(SinhVien x, SinhVien y)
			{
				var firstWords = x.HoTen.Split(' ');
				var secondWords = y.HoTen.Split(' ');

				var firstName = firstWords[firstWords.Length - 1];
				var secondName = secondWords[secondWords.Length - 1];

				return firstName.CompareTo(secondName);
			}
		}
		public class SinhVienSortNgaySinh : IComparer<SinhVien>
		{
			public int Compare(SinhVien x, SinhVien y)
			{
				return x.NgaySinh.CompareTo(y.NgaySinh);
			}
		}
		private void btnSapXep_Click(object sender, EventArgs e)
		{
			if (rbMaSV.Checked)
				quanLySV.dsSinhVien.Sort(new SinhVienSortMaSo());
			else if (rbHoTen.Checked)
				quanLySV.dsSinhVien.Sort(new SinhVienSortHoTen());
			else if (rbNgaySinh.Checked)
				quanLySV.dsSinhVien.Sort(new SinhVienSortNgaySinh());

			listView.Items.Clear();
			foreach (var sv in quanLySV.dsSinhVien)
			{
				ListViewItem item = new ListViewItem(sv.MaSo);
				item.SubItems.Add(sv.HoTen);
				item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
				item.SubItems.Add(sv.DiaChi);
				item.SubItems.Add(sv.Lop);
				item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
				item.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
				item.SubItems.Add(sv.Hinh);

				listView.Items.Add(item);
			}

			this.Close();
		}
	}
}
