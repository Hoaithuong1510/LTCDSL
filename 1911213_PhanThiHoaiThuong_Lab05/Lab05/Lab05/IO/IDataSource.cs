using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.IO
{
	public interface IDataSource
	{
		List<SinhVien> GetSV();

		void Save(List<SinhVien> sv);
	}
}
