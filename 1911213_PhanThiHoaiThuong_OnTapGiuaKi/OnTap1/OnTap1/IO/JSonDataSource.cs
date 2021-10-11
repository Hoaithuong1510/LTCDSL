using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap1.IO
{
	public class JsonDataSource : ILop
	{
		public void Save(List<SinhVien> sv, string _filePath)
		{
			var studentsData = JsonConvert.SerializeObject(sv);
			File.WriteAllText(_filePath, studentsData);
		}
	}
}
