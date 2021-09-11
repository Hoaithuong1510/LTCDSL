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


		public GiaoVien Tim(string value, KieuTim kieu)
		{
			GiaoVien giaoVien = null;
			switch (kieu)
			{
				case KieuTim.TheoMa:
					giaoVien = dsGV.Find(gv => gv.MaSo.Trim() == value.Trim());
					break;
				case KieuTim.TheoHoTen:
					giaoVien = dsGV.Find(gv => gv.HoTen.Trim() == value.Trim());
					break;
				case KieuTim.TheoSDT:
					giaoVien = dsGV.Find(gv => gv.SoDT.Trim() == value.Trim());
					break;
				default:
					break;
			}
			return giaoVien;
		}
	}
}
