using OnTap1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap1.IO
{
	internal interface IKhoa
	{
		List<Khoa> Read();
		void Save(List<Khoa> khoas);
	}
}
