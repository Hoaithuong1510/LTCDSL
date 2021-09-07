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
	public partial class frmLoginForm : Form
	{
		public frmLoginForm()
		{
			InitializeComponent();
		}

		private void txtLoginName_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var loginName = txtLoginName.Text;
			var passWord = txtPassword.Text;

			if (loginName.CompareTo("HoaiThuong") == 0 & passWord.CompareTo("1510") == 0)
			{
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				lblMessage.Text = "Sai tên đăng nhập hoặc mật khẩu";
			}

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmLoginForm_Load(object sender, EventArgs e)
		{

		}
	}
}
