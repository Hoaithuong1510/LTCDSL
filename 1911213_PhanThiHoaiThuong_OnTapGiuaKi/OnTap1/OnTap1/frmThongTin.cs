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
	public partial class frmThongTin : Form
	{
		private QuanLySinhVien _qlSinhVien;
		public SinhVien sv { get; set; }

		public frmThongTin(QuanLySinhVien qlSinhVien)
		{
			
			InitializeComponent();
			this._qlSinhVien = qlSinhVien;
		}
		private void SetValueCbb()
		{
			foreach (var k in _qlSinhVien.timKhoa(cbbKhoa.Text)._lop)
			{
				cbbLop.Items.Add(k._tenlop);
			}
			cbbLop.SelectedIndex = 0;
		}
		
		private void GetSinhVien()
		{
			SinhVien sv = new SinhVien();
			
		}
		private void SetSV()
		{
			if (sv != null)
			{
				txtMSSV.Text = sv.MaSo;
				txtHo.Text = sv.HoTenLot;
				txtTen.Text = sv.Ten;
				rbNam.Checked = (sv.GioiTinh == true ? true : false);
				rbNu.Checked = (sv.GioiTinh == false ? true : false);
				dtpNgaysinh.Text = DateTime.Now.ToShortDateString();
				cbbLop.Text = sv.Lop;
				cbbKhoa.Text = sv.Khoa;
				txtSdt.Text = sv.SĐT;
				txtDiachi.Text = sv.DiaChi;
			}
		}
		private void UpdateSV()
		{
			sv.HoTenLot = txtHo.Text;
			sv.Ten = txtTen.Text;
			sv.NgaySinh = dtpNgaysinh.Value.Date;
			sv.GioiTinh = (rbNam.Checked == true ? true : false);
			sv.SĐT = txtSdt.Text;
			sv.DiaChi = txtDiachi.Text;
			sv.Lop = cbbLop.Text;
			sv.Khoa = cbbKhoa.Text;
		}

		private void frmThongTin_Load(object sender, EventArgs e)
		{
			foreach (var k in _qlSinhVien.khoas)
			{
				cbbKhoa.Items.Add(k._tenKhoa);
			}
			cbbKhoa.SelectedIndex = 0;
			SetValueCbb();
			if (sv != null)
			{
				SetSV();
			}
			SetSV();
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			string i = "";
			if (String.IsNullOrEmpty(this.txtMSSV.Text))
				i += "MSSV, ";
			if (String.IsNullOrEmpty(this.txtHo.Text))
				i += "Họ và tên lót, ";
			if (String.IsNullOrEmpty(this.txtTen.Text))
				i += "Tên, ";
			if (String.IsNullOrEmpty(this.cbbLop.Text))
				i += "Lớp, ";
			if (String.IsNullOrEmpty(this.cbbKhoa.Text))
				i += "Khoa, ";
			if (this.dtpNgaysinh.Value == DateTime.Today)
				i += "Ngày sinh, ";
			if (i == "")
			{
				if (sv != null)
				{
					DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (result == DialogResult.Yes)
					{
						UpdateSV();
						this.DialogResult = DialogResult.OK;
						this.Close();
					}
				}
				else
				{
					GetSinhVien();
					DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}

		private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbbLop.Items.Clear();
			SetValueCbb();
		}
	}
}
