using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.IO
{
	public class TextDataSource : IDataSource
	{
		private string fileName;

        public TextDataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public List<SinhVien> GetSV()
        {
            List<SinhVien> sinhViens = new List<SinhVien>();
            if (File.Exists(fileName))
            {
                using (var reader = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
                {
                    string line;
                    while((line = reader.ReadLine())!= null)
                    {
                        var sinhvien = ParseSV(line);
                        sinhViens.Add(sinhvien);
                    }
                }
            }
            return sinhViens;
        }

        public void Save(List<SinhVien> sv)
        {
            using (var sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite)))
            {
                foreach (var item in sv)
                {
                    var line = SaveFormat(item);
                    sw.WriteLine(line);
                }
            }
        }

        private SinhVien ParseSV(string line)
        {
            var parts = line.Split('*');
            return new SinhVien()
            {
                MaSo = parts[0],
                HoTenLot = parts[1],
                Ten = parts[2],
                NgaySinh = DateTime.Parse(parts[3]),
                Lop = parts[4],
                SoCMND = parts[5],
                SĐT = parts[6],
                DiaChi = parts[7],
                GioiTinh = (int.Parse(parts[8]) == 1 ? true : false),
                dsDangKyMonHoc = addMonHoc(parts[9])
            };
        }
        private string SaveFormat(SinhVien sinhvien)
        {
            string dsMonHoc = string.Join(",", sinhvien.dsDangKyMonHoc);
            if (string.IsNullOrWhiteSpace(dsMonHoc))
                dsMonHoc = "null";
            return string.Format("{0}*{1}*{2}*{3}*{4}*{5}*{6}*{7}*{8}*{9}",
                sinhvien.MaSo, 
                sinhvien.HoTenLot,
                sinhvien.Ten, 
                sinhvien.NgaySinh.ToShortDateString(),
                sinhvien.Lop,
                sinhvien.SoCMND,
                sinhvien.SĐT, 
                sinhvien.DiaChi,
                (sinhvien.GioiTinh == true?"1":"0"),
                dsMonHoc);
        }
        private List<string> addMonHoc(string line)
        {
            List<string> mh = new List<string>();
            string[] chuyennganh = line.Split(',');
            foreach (string item in chuyennganh)
            {
                mh.Add(item);
            }
            return mh;
        }
	}
}
