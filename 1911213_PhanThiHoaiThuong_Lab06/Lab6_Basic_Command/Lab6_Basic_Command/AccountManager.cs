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
	public partial class AccountManager : Form
	{
		public AccountManager()
		{
			InitializeComponent();
			LoadAccount();
		}
		public void LoadAccount()
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT * FROM Account";

			sqlConnection.Open();

			string catName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách toàn bộ tài khoản";

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			DataTable dt = new DataTable("Account");
			da.Fill(dt);

			dgvAccount.DataSource = dt;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void tsmiActive_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " FROM RoleAccount A, Account B, Role C " +
					 " WHERE A.AccountName = B.AccountName and C.ID= A.RoleID and A.Actived = 1 ";

			sqlConnection.Open();

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Account");
			da.Fill(dt);

			dgvAccount.DataSource = dt;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void tsmiNotActive_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and A.Actived = 0 ";

			sqlConnection.Open();

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			dgvAccount.DataSource = dt;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void tsmiAdmin_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and C.RoleName = 'Adminstrator'";

			sqlConnection.Open();

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			dgvAccount.DataSource = dt;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void tsmiAccountant_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and C.RoleName = N'Kế toán'";

			sqlConnection.Open();

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			dgvAccount.DataSource = dt;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void tsmiPay_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and C.RoleName = N'Nhân viên thanh toán'";

			sqlConnection.Open();

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			dgvAccount.DataSource = dt;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void tsmiServer_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and C.RoleName = N'Nhân viên phục vụ'";

			sqlConnection.Open();

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			dgvAccount.DataSource = dt;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void tsmiAll_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID ";

			sqlConnection.Open();

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			dgvAccount.DataSource = dt;
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{

		}
		private void tsmDelete_Click(object sender, EventArgs e)
		{
			if (dgvAccount.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgvAccount.SelectedRows[0];
				string accountName = row.Cells[0].Value.ToString();
				string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();
				sqlCommand.CommandText = "UPDATE RoleAccount SET [Actived] = 0 WHERE [AccountName] = N'" + accountName + "'";
				int numOfRowsEffered = sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
				if (numOfRowsEffered > 0)
				{
					MessageBox.Show("Xóa tài khoản thành công");
					this.LoadAccount();
				}
				else
				{
					MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
				}
			}
		}

		private void tsmRole_Click(object sender, EventArgs e)
		{
			if (dgvAccount.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgvAccount.SelectedRows[0];
				string accountName = row.Cells[0].Value.ToString();
				RoleForm frmRole = new RoleForm();
				frmRole.Show(this);
				frmRole.LoadRoles(accountName);
			}
		}

		private void tsmResetPass_Click(object sender, EventArgs e)
		{
			if (dgvAccount.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgvAccount.SelectedRows[0];
				string accountName = row.Cells[0].Value.ToString();
				string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlCommand.CommandText = "update Account set [Password] = 1 where [AccountName]= N'" + accountName + "'";

				sqlConnection.Open();
				int numOfRowsEffered = sqlCommand.ExecuteNonQuery();

				if (numOfRowsEffered == 1)
				{
					MessageBox.Show("Reset mật khẩu thành công");
					this.LoadAccount();
				}
				else
				{
					MessageBox.Show("Reset mật khẩu thất bại. Vui lòng thử lại");
				}
				sqlConnection.Close();
				sqlConnection.Dispose();
			}
		}

		private void tsmAdd_Click(object sender, EventArgs e)
		{
			
		}
	}
}
