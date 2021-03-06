using Demo_01_09_2021.IO;
using Demo_01_09_2021.RssFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_01_09_2021
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			INewsRepository repository = new NewsRepository();
			NewsParser parse = new NewsParser();
			RssReader reader = new RssReader(parse);
			var manager = new NewsFeedManager(repository, reader);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(manager));
		}
	}
}
