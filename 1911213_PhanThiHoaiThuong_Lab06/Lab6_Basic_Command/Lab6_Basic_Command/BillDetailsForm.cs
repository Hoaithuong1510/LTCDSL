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
		int billID;
		public BillDetailsForm()
		{
			InitializeComponent();
		}
		public void LoadBillDetails(int billID)
		{
			this.billID = billID;
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT Name FROM Bills WHERE ID = " + billID;

			sqlConnection.Open();

			string billName = sqlCommand.ExecuteScalar().ToString();
			this.Text = billName + " ID + " + billID;

			string query = string.Format(
				"SELECT Name, Unit, Price, Quantity, Price * Quantity AS Total FROM BillDetails " +
				"JOIN Food ON BillDetails.FoodID = Food.ID " +
				"WHERE BillDetails.BillID = {0}", billID).ToString();
			sqlCommand.CommandText = query;

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			dgvBillDetails.DataSource = dt;

			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
	}
}
