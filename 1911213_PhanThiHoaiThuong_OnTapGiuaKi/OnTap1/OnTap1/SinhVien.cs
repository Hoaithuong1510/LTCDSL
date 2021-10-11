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


		public SinhVien(string maSo, string hoTenLot, string ten, bool gioiTinh, DateTime ngaySinh, string sdt, string lop, string khoa, string diaChi)
		{
			this.MaSo = maSo;
			this.HoTenLot = hoTenLot;
			this.Ten = ten;
			this.GioiTinh = gioiTinh;
			this.NgaySinh = ngaySinh;
			this.SĐT = sdt;
			this.Lop = lop;
			this.Khoa = Khoa;
			this.DiaChi = diaChi;
		}
		public SinhVien()
		{

		}

	}
}
