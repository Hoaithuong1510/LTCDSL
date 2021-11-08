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
	public partial class BillsForm : Form
	{
		public BillsForm()
		{
			InitializeComponent();
			LoadBills();
		}
		public void LoadBills()
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT * FROM Bills";

			sqlConnection.Open();

			string categoryName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách toàn bộ hóa đơn";

			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvHoaDon.DataSource = table;
			dgvHoaDon.Columns[0].ReadOnly = true;
			sqlConnection.Close();
		}
		public void LoadBill(int idTable)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			string query = $"SELECT * FROM BILLS where [TableID] = {idTable}";
			sqlCommand.CommandText = query;

			sqlConnection.Open();

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable table = new DataTable("Bills");
			da.Fill(table);
			dgvHoaDon.DataSource = table;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
		private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
		{
			BillDetailsForm billDetails = new BillDetailsForm();
			string billID = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
			billDetails.LoadBillDetails(int.Parse(billID));
			billDetails.Show();
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			string query = $"set dateformat dmy select * from Bills where '{dtpStart.Value.ToString("dd/MM/yyyy")}' <= CHECKOUTDATE and CHECKOUTDATE<= '{dtpEnd.Value.ToString("dd/MM/yyyy")}'";
			Console.WriteLine(query);
			sqlCommand.CommandText = query;
			sqlConnection.Open();
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Bills");
			da.Fill(dt);
			dgvHoaDon.DataSource = dt;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
	}
}
