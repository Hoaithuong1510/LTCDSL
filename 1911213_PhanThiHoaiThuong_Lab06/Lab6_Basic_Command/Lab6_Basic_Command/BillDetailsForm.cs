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
	public partial class BillDetailsForm : Form
	{
		public BillDetailsForm()
		{
			InitializeComponent();
		}
		public void LoadBillDetails(int id)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			string query = $"SELECT B.ID,B.[InvoiceID],FOOD.[NAME],B.[Quantity] FROM [BillDetails] as B,[FOOD] WHERE [InvoiceID] = {id} AND [FoodID] = FOOD.ID";
			sqlCommand.CommandText = query;

			sqlConnection.Open();

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			DataTable dt = new DataTable("Food");
			da.Fill(dt);
			da.Dispose();
			sqlConnection.Close();
			sqlConnection.Dispose();
			dgvBillDetails.DataSource = dt;
			dgvBillDetails.Columns["InvoiceID"].HeaderText = "Mã Bill";
			dgvBillDetails.Columns["NAME"].HeaderText = "Tên món";
			dgvBillDetails.Columns["Quantity"].HeaderText = "Số lượng";

		}
	}
}
