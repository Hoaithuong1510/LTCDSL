using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap1
{
	public class SinhVien
	{
		public string MaSo { get; set; }
		public string HoTenLot { get; set; }
		public string Ten { get; set; }
		public bool GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public string SĐT { get; set; }
		public string Lop { get; set; }
		public string Khoa { get; set; }
		public string DiaChi { get; set; }

		public SinhVien()
		{

		}

		public SinhVien(string maSo, string hoTen, string ten, bool gioiTinh, DateTime ngaySinh, string sđt, 
			string lop, string khoa, string diaChi)
		{
			MaSo = maSo;
			HoTenLot = hoTen;
			Ten = ten;
			GioiTinh = gioiTinh;
			NgaySinh = ngaySinh;
			SĐT = sđt;
			Lop = lop;
			Khoa = khoa;
			DiaChi = diaChi;
		}

	}
}
