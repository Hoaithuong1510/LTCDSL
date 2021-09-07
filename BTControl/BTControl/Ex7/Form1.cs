using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void rbNam_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbNam.Checked)
				MessageBox.Show("Giới tính của bạn là: " + rbNam.Text);
		}

		private void rbNu_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbNu.Checked)
				MessageBox.Show("Giới tính của bạn là: " + rbNu.Text);
		}
	}
}
