using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SV
{
	public class QuanLySinhVien
	{
		public delegate int SoSanh(object sv1, object sv2);
		public List<SinhVien> dsSV;

		public QuanLySinhVien()
		{
			this.dsSV = new List<SinhVien>();
		}

		public void Them(SinhVien sv)
		{
			this.dsSV.Add(sv);
		}

		public SinhVien this[int index]
		{
			get { return dsSV[index]; }
			set { dsSV[index] = value; }
		}
		public void Xoa(object obj, SoSanh ss)
		{
			int i = dsSV.Count - 1;
			for (; i > 0; i--)
				if (ss(obj, this[i]) == 0)
					this.dsSV.RemoveAt(i);
		}
		public SinhVien Tim(object obj, SoSanh ss)
		{
			SinhVien sv = null;
			foreach (SinhVien item in dsSV)
			{
				if (ss(obj, item) == 0)
				{
					sv = item;
					break;
				}
			}
			return sv;
		}
		public bool Sua(SinhVien svSua, object obj, SoSanh ss)
		{
			int i, count;
			bool kq = false;
			count = this.dsSV.Count - 1;
			for (i = 0; i < count; i++)
			{
				if (ss(obj, this[i]) == 0)
				{
					this[i] = svSua;
					kq = true;
					break;
				}
			}
			return kq;
		}

		public void DocTuFile()
		{
			string fileName = "DSSV.txt", t;
			string[] s;
			SinhVien sv;
			StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
			while ((t = sr.ReadLine()) != null)
			{
				s = t.Split('*');
				sv = new SinhVien();
				sv.MSSV = s[0];
				sv.HoTen = s[1];
				bool gt = (s[2] == "1" ? true : false);
				sv.Phai = gt;
				sv.NgaySinh = DateTime.Parse(s[3]);
				sv.Lop = s[4];
				sv.Sdt = s[5];
				sv.Email = s[6];
				sv.DiaChi = s[7];
				sv.Hinh = s[8];
				Them(sv);
			}
		}
		public List<SinhVien> LayDSSV()
		{
			return dsSV;
		}
		public void GhiVaoFile(List<SinhVien> list)
		{
			string fileName = "DSSV.txt";
			using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
			{
				foreach (var sv in list)
				{
					sw.WriteLine(sv.ToString());
				}
			}
		}
	}
}
			