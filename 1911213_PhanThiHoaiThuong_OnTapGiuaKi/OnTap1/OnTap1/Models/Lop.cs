using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap1.Models
{
	public class Lop
	{
		public string _tenlop { get; set; }
		public List<SinhVien> sinhvien { get; set; }
		
		public Lop(string tenlop)
		{
			_tenlop = tenlop;
			sinhvien = new List<SinhVien>();
		}

	}
}
