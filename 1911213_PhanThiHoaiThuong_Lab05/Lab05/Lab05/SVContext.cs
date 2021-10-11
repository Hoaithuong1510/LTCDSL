using Lab05.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
	public class SVContext
	{

		private static SVContext singleObject;
		private List<SinhVien> listSV;
		private IDataSource dataSource;

		public SVContext(IDataSource dataSource)
		{
			this.dataSource = dataSource;
		}


		internal static SVContext getInstance(IDataSource dataSource)
		{
			if (singleObject == null)
			{
				singleObject = new SVContext(dataSource);
			}
			return singleObject;
		}

		public List<SinhVien> GetSV()
		{
			if (listSV == null) listSV = dataSource.GetSV();
			return listSV;
		}

		public void SaveSV()
		{
			dataSource.Save(listSV);
		}
	}
}
