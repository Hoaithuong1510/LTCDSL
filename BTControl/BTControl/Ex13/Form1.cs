using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex13
{
	public partial class Form1 : Form
	{
		string extention = ".jpg";
		public Form1()
		{
			InitializeComponent();
			LoadImageName();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		
		void LoadImageName()
		{
			List<string> ListImage = new List<string>() { "demo1", "demo2", "demo3", "demo4" };
			cbImage.DataSource = ListImage;
		}

		private void cbImage_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox cb = sender as ComboBox;
			if (cb.SelectedValue != null)
			{
				Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedValue.ToString() + extention);
				pcbImage.Image = bm;
			}
		}
	}
}
