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
	public partial class RoleForm : Form
	{
		public RoleForm()
		{
			InitializeComponent();
		}
		public void LoadRoles(string accountName)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			sqlCommand.CommandText = "SELECT A.AccountName,C.RoleName from Account A, RoleAccount B,Role C " +
				 "where A.AccountName = B.AccountName and B.RoleID = C.ID and A.AccountName = N'" + accountName + "'";

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Role");
			da.Fill(dt);
			dgvRole.DataSource = dt;
			dgvRole.Columns[0].HeaderText = "Tên tài khoản";
			dgvRole.Columns[0].HeaderText = "Tên vai trò";
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
	}
}
