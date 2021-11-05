using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnTap1.IO;
using OnTap1.Models;

namespace OnTap1
{
	public class QuanLySinhVien
	{
		public List<Khoa> khoas = new List<Khoa>();
		public List<SinhVien> sinhviens { get; set; }
		private IKhoa _IKhoa;
		private ILop _ILop;

		public QuanLySinhVien()
		{
			_IKhoa = new TextDataSource();
			khoas = _IKhoa.Read();
		}
		public void Them(Khoa khoa)
		{
			this.khoas.Add(khoa);
		}
		
	
		public Khoa timKhoa(string tenKhoa)
		{
			return khoas.Find(x => x._tenKhoa == tenKhoa);
		}

		public List<SinhVien> sinhViens(string k)
		{
			return timKhoa(k).sinhvien;
		}

		public List<SinhVien> sinhvien(string k, string l)
		{
			return timKhoa(k)._lop.Find(x => x._tenlop == l).sinhvien;
		}

		public bool AddSinhVien(SinhVien sv)
		{
			var i = sinhViens(sv.Khoa).Find(x => x.MaSo == sv.MaSo);
			if (i == null)
			{
				sinhViens(sv.Khoa).Add(sv);
				sinhvien(sv.Khoa, sv.Lop).Add(sv);
				_IKhoa.Save(khoas);
				return true;
			}
			return false;
		}

		public bool UpdateSinhVien(SinhVien sv)
		{
			var i = sinhViens(sv.Khoa).FindIndex(x => x.MaSo == sv.MaSo);
			if (i == -1)
			{
				return false;
			}
			sinhViens(sv.Khoa)[i] = sv;
			_IKhoa.Save(khoas);
			return true;
		}

		public void RemoveSV(SinhVien sv)
		{
			sinhViens(sv.Khoa).RemoveAll(x => x.MaSo == sv.MaSo);
			sinhvien(sv.Khoa, sv.Lop).RemoveAll(x => x.MaSo == sv.MaSo);
		}

		public void SaveJSON(List<SinhVien> sv, string path)
		{
			ILop lop = new JsonDataSource();
			lop.Save(sv, path);
		}

		public void SaveExcel(List<SinhVien> sv, string path)
		{
			ILop lop = new ExcelDataSource();
			lop.Save(sv, path);
		}
		
	}

}
