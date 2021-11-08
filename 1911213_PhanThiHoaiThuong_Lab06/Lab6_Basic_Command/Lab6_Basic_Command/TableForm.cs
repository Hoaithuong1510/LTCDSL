using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
	public partial class TableForm : Form
	{
		public TableForm()
		{
			InitializeComponent();
			LoadTable();
		}
		public void LoadTable()
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			sqlCommand.CommandText = "SELECT * FROM [Table]";

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Tables");
			da.Fill(dt);
			dgvTable.DataSource = dt;

			dgvTable.Columns["ID"].HeaderText = "Mã Bàn";
			dgvTable.Columns["Name"].HeaderText = "Tên bàn";
			dgvTable.Columns["Status"].HeaderText = "Trạng thái";
			dgvTable.Columns["Capacity"].HeaderText = "Lượng người ngồi";

			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void tsmDeleteTable_Click(object sender, EventArgs e)
		{
			if (dgvTable.Rows.Count > 0)
			{
				DataGridViewRow row = dgvTable.SelectedRows[0];
				string id = row.Cells[0].Value.ToString();

				string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
				SqlConnection sqlConnection = new SqlConnection(connectionString);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "Delete FROM [Table] Where [ID] = " + id;

				int numOfRowEffered = sqlCommand.ExecuteNonQuery();

				if (numOfRowEffered == 1)
				{
					MessageBox.Show("Xóa bàn thành cônng");
					this.LoadTable();
				}
				else
				{
					MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại sau");
				}

				sqlConnection.Close();
				sqlConnection.Dispose();
			}
		}

		private void tsmBill_Click(object sender, EventArgs e)
		{
			if (dgvTable.SelectedRows.Count > 0)
			{
				DataGridViewRow currow = dgvTable.SelectedRows[0];
				BillsForm bills = new BillsForm();
				if (currow.Cells[0].Value.ToString() == "") return;
				bills.LoadBill(int.Parse(currow.Cells[0].Value.ToString()));
				bills.ShowDialog();
			}
		}

		private void tsmBillDiary_Click(object sender, EventArgs e)
		{

		}
	}
}
