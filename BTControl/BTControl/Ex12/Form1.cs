using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			frmLoginForm login = new frmLoginForm();
			if (login.ShowDialog() != DialogResult.OK)
			{
				Close();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Bạn có thực sự muốn thêm sinh viên vào danh sách hay không", "Thông báo", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				lbDanhSachSV.Items.Add(txtFullName.Text);
			}

			}
		}
	}
