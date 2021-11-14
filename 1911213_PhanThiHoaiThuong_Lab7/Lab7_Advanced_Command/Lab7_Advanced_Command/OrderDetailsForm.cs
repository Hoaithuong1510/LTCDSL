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

namespace Lab7_Advanced_Command
{
	public partial class OrderDetailsForm : Form
	{
		public OrderDetailsForm()
		{
			InitializeComponent();
		}
		public void LoadFoods(int billID)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT A.ID, B.Name, Quantity, B.Price, B.Price * Quantity as Summary FROM BillDetails A, Food B WHERE A.FoodID = B.ID AND A.InvoiceID = @BillID";

			command.Parameters.Add("@BillID", SqlDbType.Int);
			command.Parameters["@BillID"].Value = Convert.ToInt32(billID);

			connection.Open();

			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			sqlDataAdapter.Fill(dt);
			dgvBillDetails.DataSource = dt;

			dgvBillDetails.Columns[0].HeaderText = "Mã số";
			dgvBillDetails.Columns[1].HeaderText = "Tên món ăn";
			dgvBillDetails.Columns[2].HeaderText = "Số lượng";
			dgvBillDetails.Columns[3].HeaderText = "Đơn giá";
			dgvBillDetails.Columns[4].HeaderText = "Thành tiền";

			connection.Close();
			connection.Dispose();
			this.Text = "Danh sách món ăn của hoá đơn: " + billID;
		}
	}
}
