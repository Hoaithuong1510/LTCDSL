using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911213_PhanThiHoaiThuong_Lab02_GV
{
	public class GiaoVien
	{
		public string MaSo { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh;
		public DanhMucMonHoc dsMonHoc;
		public string GioiTinh;
		public List<string> NgoaiNgu;
		public string SoDT;
		public string Mail;
		public GiaoVien()
		{
			dsMonHoc = new DanhMucMonHoc();
			NgoaiNgu = new List<string>();
		}
		public GiaoVien
			(
				string maSo, string hoTen,
				DateTime ngaySinh, DanhMucMonHoc ds,
				string gioiTinh, List<string> ngoaiNgu,
				string sdt, string mail
			)
		{
			this.MaSo = maSo;
			this.HoTen = hoTen;
			this.NgaySinh = ngaySinh;
			this.dsMonHoc = ds;
			this.GioiTinh = gioiTinh;
			this.NgoaiNgu = ngoaiNgu;
			this.SoDT = sdt;
			this.Mail = mail;
		}
		public override string ToString()
		{
			string s = "Mã số: " + MaSo + "\n" + "Họ tên: " + HoTen + "\n"
				 + "Ngày sinh: " + NgaySinh.ToString() + "\n"
				 + "Giới tính: " + GioiTinh + "\n"
				 + "Số ĐT: " + SoDT + "\n"
				 + "Mail: " + Mail + "\n";
		    string language = "Ngoại ngữ:";
			foreach (string t in NgoaiNgu)
				language += t + ";";
			string Monday = "Danh sách môn dạy:";
			foreach (MonHoc mh in dsMonHoc.ds)
				Monday += mh + ";";
			s += "\n" + language + "\n" + Monday;
			return s;

		}
	}
}
