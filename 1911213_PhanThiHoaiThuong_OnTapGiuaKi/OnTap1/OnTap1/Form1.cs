using OnTap1.IO;
using OnTap1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap1
{
	public partial class Form1 : Form
	{
		private QuanLySinhVien _qlSinhVien;
		private const string _holderText = "Nhập thông tin cần tìm !!!!";
		private List<SinhVien> _sinhvien;
		private string _node;
		private string _parent;

		public Form1()
		{
			InitializeComponent();
			_qlSinhVien = new QuanLySinhVien();
			_sinhvien = new List<SinhVien>();

		}

		private void ThemSV(SinhVien sv)
		{
			ListViewItem item = new ListViewItem(sv.MaSo);
			item.SubItems.Add(sv.HoTenLot);
			item.SubItems.Add(sv.Ten);
			item.SubItems.Add(sv.GioiTinh == true ? "Nam" : "Nu");
			item.SubItems.Add(sv.NgaySinh.ToShortDateString());
			item.SubItems.Add(sv.SĐT);
			item.SubItems.Add(sv.Khoa);
			item.SubItems.Add(sv.Lop);
			item.SubItems.Add(sv.DiaChi);

			lvDSSV.Items.Add(item);
		}

		private void LoadSVToListView(List<SinhVien> dssv)
		{
			lvDSSV.Items.Clear();
			foreach (SinhVien sv in dssv)
				ThemSV(sv);
		}

		private SinhVien GetSVLV(ListViewItem item)
		{
			return new SinhVien()
			{
				MaSo = item.SubItems[0].Text,
				HoTenLot = item.SubItems[1].Text,
				Ten = item.SubItems[2].Text,
				GioiTinh = item.SubItems[3].Text == "Nam" ? true : false,
				NgaySinh = DateTime.Parse(item.SubItems[4].Text),
				SĐT = item.SubItems[5].Text,
				Lop = item.SubItems[6].Text,
				Khoa = item.SubItems[7].Text,
				DiaChi = item.SubItems[8].Text
			};
		}

	

		private void ShowFeedOnTreeView()
		{
			tvDSKhoa.Nodes.Clear();
			lvDSSV.Items.Clear();
			foreach (var khoa in _qlSinhVien.khoas)
			{
				var khoaNode = tvDSKhoa.Nodes.Add(khoa._tenKhoa);
				foreach (var lop in khoa._lop)
				{
					khoaNode.Nodes.Add(lop._tenlop);
				}
			}
			tvDSKhoa.ExpandAll();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			ShowFeedOnTreeView();
			SearchText();
		}
		private void SearchText()
		{
			txtTim.Text = _holderText;
			txtTim.GotFocus += RemoveText;
			txtTim.LostFocus += ShowText;
		}

		private void ShowText(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTim.Text))
				txtTim.Text = _holderText;
		}

		private void RemoveText(object sender, EventArgs e)
		{
			if (txtTim.Text == _holderText)
				txtTim.Text = "";
		}
		public List<SinhVien> GetSvID(string id)
		{
			List<SinhVien> ds = new List<SinhVien>();
			foreach (var x in _sinhvien)
				if (x.MaSo.Contains(id))
					ds.Add(x);
			return ds;
		}
		public List<SinhVien> GetSvPhone(string id)
		{
			List<SinhVien> ds = new List<SinhVien>();
			foreach (var x in _sinhvien)
				if (x.SĐT.Contains(id))
					ds.Add(x);
			return ds;
		}
		public List<SinhVien> GetSvName(string id)
		{
			List<SinhVien> ds = new List<SinhVien>();
			foreach (var x in _sinhvien)
				if (x.HoTenLot.Contains(id))
					ds.Add(x);
			return ds;
		}
		private void txtTim_TextChanged(object sender, EventArgs e)
		{
			if (this.rbMSSV.Checked) LoadSVToListView(GetSvID(this.txtTim.Text));
			if (this.rbSDT.Checked) LoadSVToListView(GetSvPhone(this.txtTim.Text));
			if (this.rbHoten.Checked) LoadSVToListView(GetSvName(this.txtTim.Text));
		}

		private void tvDSKhoa_AfterSelect(object sender, TreeViewEventArgs e)
		{
			lvDSSV.Items.Clear();
			if (e.Node.Level == 0)
			{
				_sinhvien = _qlSinhVien.sinhViens(e.Node.Text);
				_node = "";
				_parent = e.Node.Text;
			}
			else if (e.Node.Level == 1)
			{
				_parent = e.Node.Parent.Text;
				_node = e.Node.Text;
				_sinhvien = _qlSinhVien.sinhvien(_parent, _node);
			}
			LoadSVToListView(_sinhvien);
		}

		private void tsmiThem_Click(object sender, EventArgs e)
		{
			frmThongTin frm = new frmThongTin(_qlSinhVien);
			frm.ShowDialog();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadSVToListView(_qlSinhVien.sinhvien(frm.sv.Khoa, frm.sv.Lop));
			}
		}

		private void tsmiXoa_Click(object sender, EventArgs e)
		{
			int i;
			ListViewItem lvitem;
			DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dlg == DialogResult.Yes)
			{
				for (i = lvDSSV.SelectedItems.Count - 1; i >= 0; i--)
				{
					lvitem = lvDSSV.SelectedItems[i];
					var sv = _qlSinhVien.sinhViens(_parent).Find(x => x.MaSo == lvitem.SubItems[0].Text);
					_qlSinhVien.RemoveSV(sv);
				}
				LoadSVToListView(_sinhvien);
			}
		}

		private void lvDSSV_DoubleClick(object sender, EventArgs e)
		{
			ListViewItem lvitem;
			int i = lvDSSV.SelectedItems.Count;
			if (i > 0)
			{
				lvitem = lvDSSV.SelectedItems[0];
				frmThongTin frm = new frmThongTin(_qlSinhVien);
				frm.sv = _sinhvien.Find(x => x.MaSo == lvitem.SubItems[0].Text);
				frm.ShowDialog();
				if (frm.DialogResult == DialogResult.OK)
				{
					LoadSVToListView(_sinhvien);
				}
			}
		}

		private void tsmiExcel_Click(object sender, EventArgs e)
		{
			SaveFileDialog sf = new SaveFileDialog();
			sf.InitialDirectory = @"D:\";
			sf.FileName = _node;
			sf.Filter = "Excel 2007 file(xlsx>(*.xlsx)|*.xlsx";
			sf.FilterIndex = 1;
			if (sf.ShowDialog() == DialogResult.OK)
			{
				_qlSinhVien.SaveExcel(_qlSinhVien.sinhvien(_parent, _node), sf.FileName);
				MessageBox.Show("Bạn đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void tsmiJSon_Click(object sender, EventArgs e)
		{
			SaveFileDialog sf = new SaveFileDialog();
			sf.InitialDirectory = @"D:\";
			sf.FileName = _node;
			sf.Filter = "Json file(json)(*.json)|*.json";
			sf.FilterIndex = 2;
			if (sf.ShowDialog() == DialogResult.OK)
			{
				_qlSinhVien.SaveJSON(_qlSinhVien.sinhvien(_parent, _node), sf.FileName);
				MessageBox.Show("Bạn đã lưu thành công ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
	}
}
