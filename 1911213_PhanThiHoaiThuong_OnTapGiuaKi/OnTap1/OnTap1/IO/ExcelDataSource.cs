using OnTap1.Models;
using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap1.IO
{
	public class ExcelDataSource : ILop
	{
		public void Save(List<SinhVien> sv, string _filepath)
		{
			_Application ex = new Excel.Application();
			Workbook wk = ex.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
			Worksheet ws = wk.Worksheets[1];
			int row = 1;
			ws.Cells[1, 1] = "MSSV";
			ws.Cells[1, 2] = "Họ và tên lót";
			ws.Cells[1, 3] = "Tên";
			ws.Cells[1, 4] = "Giới tính";
			ws.Cells[1, 5] = "Ngày sinh";
			ws.Cells[1, 6] = "Số điện thoại";
			ws.Cells[1, 7] = "Địa chỉ";
			ws.Cells[1, 8] = "Lớp";
			ws.Cells[1, 9] = "Khoa";
			foreach (var x in sv)
			{
				row++;
				ws.Cells[row, 1] = x.MaSo;
				ws.Cells[row, 2] = x.HoTenLot;
				ws.Cells[row, 3] = x.Ten;
				if (x.GioiTinh) ws.Cells[row, 4] = "Nam";
				else ws.Cells[row, 4] = "Nữ";
				ws.Cells[row, 5] = x.NgaySinh.ToString();
				ws.Cells[row, 6] = x.SĐT;
				ws.Cells[row, 7] = x.DiaChi;
				ws.Cells[row, 8] = x.Lop;
				ws.Cells[row, 9] = x.Khoa;
			}
			wk.SaveAs(_filepath);
			wk.Close();
		}
	}
}
