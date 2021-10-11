using Demo_01_09_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01_09_2021.RssFeed
{
	public class RssReader
	{
		private readonly NewsParser _parse;
		public RssReader(NewsParser parse)
		{
			_parse = parse;
		}

		public List<Article> GetNews(string rssLink)
		{
			var feedData = DownloadFeed(rssLink);
			return _parse.ParseXml(feedData);
		}

		private string DownloadFeed(string rssLink)
		{
			var client = new WebClient()
			{
				Encoding = Encoding.UTF8
			};
			return client.DownloadString(rssLink);
		}
	}
}
