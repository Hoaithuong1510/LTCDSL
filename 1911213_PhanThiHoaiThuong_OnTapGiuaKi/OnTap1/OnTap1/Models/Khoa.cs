using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap1.Models
{
	public class Khoa
	{
		public string _tenKhoa { get; set; }
		public List<SinhVien> sinhvien { get; set; }
		public List<Lop> _lop { get; set; }
		public Khoa(string tenKhoa)
		{
			this._tenKhoa = tenKhoa;
			sinhvien = new List<SinhVien>();
			_lop = new List<Lop>();
		}
		public void AddSV(SinhVien sv)
		{
			int i = sinhvien.FindIndex(x => x.MaSo == sv.MaSo);
			sinhvien.Add(sv);
			int j = _lop.FindIndex(x => x._tenlop == sv.Lop);
			if (j == -1)
			{
				Lop lop = new Lop(sv.Lop);
				lop.sinhvien.Add(sv);
				_lop.Add(lop);
			}
			else
			{
				_lop[j].sinhvien.Add(sv);
			}
		}
	}
}
