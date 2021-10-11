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

namespace Lab4_Demo
{
	public partial class PictureForm : Form
	{
		Point p = new Point();
		bool ctrlZoom;
		public PictureBox pbPicture;

		public PictureForm()
		{
			InitializeComponent();
		}

		public PictureForm(string name)
		{
			InitializeComponent();
			this.pbHinh.ImageLocation = name;
			this.toolStripStatusLabel1.Text = name;
			pbPicture = this.pbHinh;
		}
		private void tsMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void PictureForm_Load(object sender, EventArgs e)
		{
			p = this.pbHinh.Location;
			ctrlZoom = false;

			this.MouseWheel += FrmPicture_MouseWheel;
			this.KeyDown += FrmPicture_KeyDown;
			this.KeyUp += FrmPicture_KeyUp;

			pbHinh.SizeMode = PictureBoxSizeMode.StretchImage;
		}
		private void FrmPicture_KeyUp(object sender, KeyEventArgs e)
		{
			this.ctrlZoom = e.Control;
		}

		private void FrmPicture_KeyDown(object sender, KeyEventArgs e)
		{
			this.ctrlZoom = e.Control;
		}
		private void FrmPicture_MouseWheel(object sender, MouseEventArgs e)
		{
			bool isGoUp = e.Delta > 0 ? true : false
			if (ctrlZoom)
			{
				int hStep = (int)(this.pbHinh.Image.Width * 0.02);
				int vStep = (int)(this.pbHinh.Image.Height * 0.02);

				if (isGoUp)
				{
					this.pbHinh.Width += hStep;
					this.pbHinh.Height += vStep;
				}
				else
				{
					this.pbHinh.Width -= hStep;
					this.pbHinh.Height -= vStep;
				}
			}
			else
			{
				if (isGoUp && this.vScrollBar.Value > 5)
				{
					this.vScrollBar.Value -= 5;
				}
				if (!isGoUp && this.vScrollBar.Value < this.vScrollBar.Maximum - 5)
				{
					this.vScrollBar.Value += 5;
				}

				pbHinh.Location = new Point(p.X, p.Y - this.vScrollBar.Value);
			}
		}
		private void tsMenuItemReload_Click(object sender, EventArgs e)
		{
			DialogResult dlg = this.openFileDialog.ShowDialog();
			String title = "";
			if (dlg == DialogResult.OK)
			{
				title = openFileDialog.FileName;
				this.Text = title;
				this.pbHinh.ImageLocation = openFileDialog.FileName;
			}
		}

		public void tsMenuItemZoomIn_Click(object sender, EventArgs e)
		{
			this.pbHinh.Width += 50;
			this.pbHinh.Height += 50;
		}

		public void tsMenuItemZoomOut_Click(object sender, EventArgs e)
		{
			this.pbHinh.Width -= 50;
			this.pbHinh.Height -= 50;
		}

		public void tsMenuItemEdit_Click(object sender, EventArgs e)
		{
			Process.Start("mspaint", this.pbHinh.ImageLocation);
		}

		private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			this.pbHinh.Location = new Point(p.X, p.Y - e.NewValue);
		}

		private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			this.pbHinh.Location = new Point(p.X, e.NewValue - p.Y);
		}

		private void frmPicture_KeyUp(object sender, KeyEventArgs e)
		{
			this.ctrlZoom = e.Control;
		}


		private void frmPicture_KeyDown(object sender, KeyEventArgs e)
		{
			this.ctrlZoom = e.Control;
		}
	}
}
