using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
	public class SinhVien
	{
		public string MaSo { get; set; }
		public string HoTenLot { get; set; }
		public string Ten { get; set; }
		public bool GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public string Lop { get; set; }
		public string SoCMND { get; set; }
		public string SĐT { get; set; }
		public string DiaChi { get; set; }
		
		public List<string> dsDangKyMonHoc { get; set; }

		public SinhVien()
		{
			
		}

		public SinhVien(string maSo, string hoTenLot, string ten, bool gioiTinh, DateTime ngaySinh,
			string lop, string soCMND, string sdt, string diaChi,  List<string> dsDangKyMonHoc)
		{
			this.MaSo = maSo;
			this.HoTenLot = hoTenLot;
			this.Ten = ten;
			this.GioiTinh = gioiTinh;
			this.NgaySinh = ngaySinh;
			this.Lop = lop;
			this.SoCMND = soCMND;
			this.SĐT = sdt;
			this.DiaChi = diaChi;
			this.dsDangKyMonHoc = dsDangKyMonHoc;
		}
	}
}
