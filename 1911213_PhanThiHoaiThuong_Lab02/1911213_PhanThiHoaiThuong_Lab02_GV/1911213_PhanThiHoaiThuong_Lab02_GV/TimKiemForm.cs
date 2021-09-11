using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911213_PhanThiHoaiThuong_Lab02_GV
{
	public partial class TimKiemForm : Form
	{
		private QuanLyGiaoVien quanlyGV;
		public TimKiemForm()
		{
			InitializeComponent();
		}

		public TimKiemForm(QuanLyGiaoVien qlGV) : this()
		{
			quanlyGV = qlGV;
		}

		private void rdMaGV_CheckedChanged(object sender, EventArgs e)
		{
			if (rbMaGV.Checked)
			{
				lbFind.Text = rbMaGV.Text;
				txtFind.Text = "";
			}
		}

		private void rbHoTen_CheckedChanged(object sender, EventArgs e)
		{
			if (rbHoTen.Checked)
			{
				lbFind.Text = rbHoTen.Text;
				txtFind.Text = "";
			}
		}

		private void rbSoDT_CheckedChanged(object sender, EventArgs e)
		{
			if (rbSoDT.Checked)
			{
				lbFind.Text = rbSoDT.Text;
				txtFind.Text = "";
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			var kieu = KieuTim.TheoHoTen;
			if (rbMaGV.Checked)
			{
				kieu = KieuTim.TheoMa;
			}
			else if (rbHoTen.Checked)
			{
				kieu = KieuTim.TheoHoTen;
			}
			else if (rbSoDT.Checked)
			{
				kieu = KieuTim.TheoSDT;
			}

			var gv = quanlyGV.Tim(txtFind.Text, kieu);
			if (gv == null)
			{
				MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				var frmTBGiaoVien = new TBGiaoVienForm();
				frmTBGiaoVien.SetText(gv.ToString());
				frmTBGiaoVien.ShowDialog();
			}
		}
	}

}
