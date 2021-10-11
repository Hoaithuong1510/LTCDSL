using OnTap1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap1.IO
{
	public interface IDataSource
	{
		List<Khoa> GetSV();
		void Save(List<Khoa> khoa);
	}
}
