using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Demo
{
	public partial class PictureViewForm : Form
	{
		int count = 0;
		public PictureViewForm()
		{
			InitializeComponent();
		}

		private void newMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dlg = this.openFileDialog.ShowDialog();
			if (dlg == DialogResult.OK)
			{
				{
					PictureForm frm = new PictureForm(openFileDialog.FileName);
					frm.MdiParent = this;
					count++;
					frm.Text = "Picture -" + count + "-" + openFileDialog.FileName;
					frm.Show();
				}
				this.toolStripStatusLabel1.Text = "Tổng số Form con:" + count.ToString();
			}
		}

		private void saveAsMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dlg = this.saveFileDialog1.ShowDialog();
			if (dlg == DialogResult.OK)
			{
				PictureForm frm = this.ActiveMdiChild as PictureForm;
				try
				{
					Image img = frm.pbPicture.Image;
					img.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
				}
				catch
				{
					MessageBox.Show("Lỗi lưu file");
				}
			}
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void statusStripMenuItem_Click(object sender, EventArgs e)
		{
			bool check = this.statusStripMenuItem.Checked;
			if (check)
				this.statusStrip1.Visible = true;
			else
				this.statusStrip1.Visible = false;
		}

		private void toolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool check = this.toolStripMenuItem.Checked;
			if (check)
				this.toolStrip1.Visible = true;
			else
				this.toolStrip1.Visible = false;
		}

		private void arrangeIconsMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void cascadeMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void arrangeHorizontalMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void arrangeVerticalMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void maximizeAllMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form frm in this.MdiChildren)
			    frm.WindowState = FormWindowState.Maximized;
		}

		private void minimizeAllMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form frm in this.MdiChildren)
				frm.WindowState = FormWindowState.Minimized;
		}

		private void zoomInToolStrip_Click(object sender, EventArgs e)
		{
			var currentChildForm = ActiveMdiChild as PictureForm;
			currentChildForm.tsMenuItemZoomIn.PerformClick();
		}

		private void zoomOutToolStrip_Click(object sender, EventArgs e)
		{
			var currentChildForm = ActiveMdiChild as PictureForm;
			currentChildForm.tsMenuItemZoomOut.PerformClick();
		}

		private void paintToolStrip_Click(object sender, EventArgs e)
		{
			var currentChildForm = ActiveMdiChild as PictureForm;
			currentChildForm.tsMenuItemEdit.PerformClick();
		}
	}
}
