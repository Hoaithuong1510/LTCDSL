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
	public partial class OrderForm : Form
	{
		public OrderForm()
		{
			InitializeComponent();
		}
		private void LoadBills()
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();
			command.CommandText = "exec GetBillByDate @Date";

			command.Parameters.Add("@date", SqlDbType.SmallDateTime);
			command.Parameters["@date"].Value = dtpDate.Value.ToShortDateString();
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();

			connection.Open();
			adapter.Fill(dt);
			command.CommandText = "Select SUM(Amount) from Bills where CheckoutDate = @date";

			var doanhThu = command.ExecuteScalar();
			lblSum.Text = doanhThu.ToString();
			connection.Close();
			connection.Dispose();

			dgvBills.DataSource = dt;
			dgvBills.Columns[0].HeaderText = "Mã hóa đơn";
			dgvBills.Columns[1].HeaderText = "Tên hóa đơn";
			dgvBills.Columns[2].HeaderText = "Mã bàn";
			dgvBills.Columns[3].HeaderText = "Trị giá hóa đơn";
			dgvBills.Columns[4].HeaderText = "Giảm giá %";
			dgvBills.Columns[5].HeaderText = "Thuế";
			dgvBills.Columns[6].HeaderText = "Đã thanh toán";
			dgvBills.Columns[7].HeaderText = "Ngày thanh toán";
			dgvBills.Columns[8].HeaderText = "Tên tài khoản";
		}

		
		private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvBills.SelectedRows.Count > 0)
			{
				OrderDetailsForm orderDetail = new OrderDetailsForm();
				orderDetail.Show();
				orderDetail.LoadFoods(int.Parse(dgvBills.SelectedRows[0].Cells[0].Value.ToString()));
			}
		}

		private void OrderForm_Load(object sender, EventArgs e)
		{
			LoadBills();
		}

		private void dtpDate_ValueChanged(object sender, EventArgs e)
		{
			LoadBills();
		}
	}
}
