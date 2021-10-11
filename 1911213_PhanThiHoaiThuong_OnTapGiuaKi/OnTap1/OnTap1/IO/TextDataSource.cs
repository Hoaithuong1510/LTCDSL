using OnTap1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap1.IO
{
	public class TextDataSource : IDataSource
	{
		private const string path = "Data/DSSV.txt";
		public List<Khoa> khoa = new List<Khoa>();

		public List<Khoa> GetSV()
		{
			Khoa khoa;
			List<Khoa> dskhoa = new List<Khoa>();
			string line = "";
			if (File.Exists(path))
			{
				using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
				{
					using (var reader = new StreamReader(stream))
					{
						while ((line = reader.ReadLine()) != null)
						{
							SinhVien sinhvien = ParseSV(line);
							int i = dskhoa.FindIndex(x => x._tenKhoa == sinhvien.Khoa);
							if (i == -1)
							{
								khoa = new Khoa(sinhvien.Khoa);
								dskhoa.Add(khoa);
								i = dskhoa.IndexOf(khoa);
							}
							dskhoa[i].AddSV(sinhvien);
						}
					}
				}
			}
			return dskhoa;
		}

		public void Save(List<Khoa> khoas)
		{
			using (var stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
			{
				using (var sw = new StreamWriter(stream))
				{
					foreach (var k in khoas)
					{
						foreach (var sv in k.sinhvien)
						{
							sw.WriteLine(sv);
						}
					}
				}
			}
		}

		public SinhVien ParseSV (string line)
		{
			var parts = line.Split('\t');
			return new SinhVien()
			{
				MaSo = parts[0],
				HoTenLot = parts[1],
				Ten = parts[2],
				NgaySinh = DateTime.MinValue,
				Lop = parts[3],
				SĐT = "",
				Khoa = parts[4],
				DiaChi = ""
			};
		}
		private string SaveFormat(SinhVien sinhvien)
		{
			return string.Format("{0}*{1}*{2}*{3}*{4}*{5}*{6}*{7}*{8}*{9}",
				sinhvien.MaSo,
				sinhvien.HoTenLot,
				sinhvien.Ten,
				sinhvien.NgaySinh.ToShortDateString(),
				sinhvien.Lop,
				sinhvien.SĐT,
				sinhvien.Khoa,
				sinhvien.DiaChi);
		}
	}
}
