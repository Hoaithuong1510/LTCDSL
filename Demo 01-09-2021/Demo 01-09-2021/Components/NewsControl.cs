using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo_01_09_2021.Models;
using System.Diagnostics;

namespace Demo_01_09_2021
{
	public partial class NewsControl : UserControl
	{
		public NewsControl()
		{
			InitializeComponent();
		}

		public void SetArticle(Models.Article news)
		{
			lblTitle.Text = news.Title;
			lblDescription.Text = news.Description;
			lblPublishedDate.Text = news.PuslishedDate.ToString("dd/MM/yyyy HH:mm");
			lblDetails.LinkClicked += (sender, args) =>
			{
				Process.Start(news.Link);
			};
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.DrawRectangle(Pens.Black, 0, 1, Width - 1, Height - 2);
		}
	}
}
