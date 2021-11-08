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
	public partial class frmFood : Form
	{
		int categoryID;
		public frmFood()
		{
			InitializeComponent();
		}

		private void frmFood_Load(object sender, EventArgs e)
		{

		}
		public void LoadFood(int categoryID)
		{
			this.categoryID = categoryID;
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT Name FROM Category where ID =" + categoryID;

			sqlConnection.Open();

			string catName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;

			sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			DataTable dt = new DataTable("Food");
			da.Fill(dt);
			dgvFood.DataSource = dt;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			for (int i = 0; i < dgvFood.Rows.Count - 1; i++)
			{
				int id = (int)dgvFood.Rows[i].Cells["ID"].Value;
				sqlCommand.CommandText = "SELECT * FROM Food WHERE ID = " + id;
				var checkID = sqlCommand.ExecuteScalar();

				if (checkID == null)
				{
					string query = string.Format("" +
					"INSERT INTO Food(Name, Unit, FoodCategoryID, Price, Notes)" + " " +
					"VALUES (N'{0}', N'{1}', {2}, {3}, N'{4}')",
					dgvFood.Rows[i].Cells["Name"].Value,
					dgvFood.Rows[i].Cells["Unit"].Value,
					categoryID,
					dgvFood.Rows[i].Cells["Price"].Value,
					dgvFood.Rows[i].Cells["Notes"].Value).ToString();
				    sqlCommand.CommandText = query;
				    sqlCommand.ExecuteNonQuery();
					MessageBox.Show("Thêm món ăn mới thành công");
				}
				else
				{
					string query = string.Format(" UPDATE Food SET Name = N'{0}', Unit = N'{1}', FoodCategoryID = {2}, Price = {3}, Notes = N'{4}' WHERE ID = {5}",
					dgvFood.Rows[i].Cells["Name"].Value,
					dgvFood.Rows[i].Cells["Unit"].Value,
					categoryID,
					dgvFood.Rows[i].Cells["Price"].Value,
					dgvFood.Rows[i].Cells["Notes"].Value.ToString(),
					id.ToString());
					sqlCommand.CommandText = query;
					sqlCommand.ExecuteNonQuery();
					MessageBox.Show("Cập nhật thành công");
				}
			}

			sqlConnection.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvFood.SelectedRows.Count == 0) return;

			var selectedRow = dgvFood.SelectedRows[0];

			string foodID = selectedRow.Cells[0].Value.ToString();

			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			string query = "DELETE FROM Food WHERE ID = " + foodID;
			sqlCommand.CommandText = query;

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			if (numOfRowsEffected == 1)
			{
				dgvFood.Rows.Remove(selectedRow);
				MessageBox.Show("Đã xoá món ăn");
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra.");
				return;
			}

			sqlConnection.Close();
		}
	}
}
