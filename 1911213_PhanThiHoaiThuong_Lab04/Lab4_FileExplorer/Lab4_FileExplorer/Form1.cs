using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_FileExplorer
{
	public partial class ExploreForm : Form
	{
		public ExploreForm()
		{
			InitializeComponent();
		}

		private void ExploreForm_Load(object sender, EventArgs e)
		{
			TreeNode tnode = new TreeNode();
			tnode.Text = "Desktop";
			tnode.Tag = SpecialDirectories.Desktop;
			tnode.ImageKey = "Desktop";
			tnode.SelectedImageKey = "Desktop";

			treeViewFolder.Nodes.Add(tnode);
		}
	}
}
