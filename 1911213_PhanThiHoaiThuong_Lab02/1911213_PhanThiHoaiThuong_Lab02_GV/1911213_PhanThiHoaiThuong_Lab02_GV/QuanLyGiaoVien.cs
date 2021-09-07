using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911213_PhanThiHoaiThuong_Lab02_GV
{
	public class QuanLyGiaoVien
	{
		public List<GiaoVien> dsGV;
		public QuanLyGiaoVien()
		{
			dsGV = new List<GiaoVien>();
		}

		public GiaoVien this[int index]
		{
			get { return dsGV[index]; }
			set { dsGV[index] = value; }
		}

		public bool Add(GiaoVien giaoVien)
		{
			var add = dsGV.Exists(gv => gv.MaSo == giaoVien.MaSo);
			if (add) return false;

			dsGV.Add(giaoVien);

			return true;
		}

		public GiaoVien Find(string value, KieuTim kieuTim)
		{
			GiaoVien giaoVien = null;

			switch (kieuTim)
			{
				case KieuTim.TheoHoTen:
					giaoVien = dsGV.Find(gv => gv.HoTen == value);
					break;
				case KieuTim.TheoMa:
					giaoVien = dsGV.Find(gv => gv.MaSo == value);
					break;
				case KieuTim.TheoSDT:
					giaoVien = dsGV.Find(gv => gv.SoDT == value);
					break;
			}

			return giaoVien;
		}
	}
}
