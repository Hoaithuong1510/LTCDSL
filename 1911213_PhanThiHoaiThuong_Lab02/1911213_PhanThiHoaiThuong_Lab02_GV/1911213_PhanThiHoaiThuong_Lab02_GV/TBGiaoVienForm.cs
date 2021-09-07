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
	public partial class TBGiaoVienForm : Form
	{
		public TBGiaoVienForm()
		{
			InitializeComponent();
		}
		public void SetText(string s)
		{
			this.lblThongBao.Text = s;
		}
	}
}
