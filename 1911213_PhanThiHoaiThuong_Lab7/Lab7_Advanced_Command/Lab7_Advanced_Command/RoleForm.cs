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
	public partial class RoleForm : Form
	{
		string account;
		int numOfRowsAffered;
		public RoleForm()
		{
			InitializeComponent();
		}
		public void LoadRoles(string accountName)
		{
			account = accountName;
			txtAccountName.Text = accountName;
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);

			SqlCommand command1 = connection.CreateCommand();
			SqlCommand command2 = connection.CreateCommand();

			connection.Open();

			command1.CommandText = "select [ID],[RoleName] from Role";

			SqlDataReader reader = command1.ExecuteReader();

			lvRole.Items.Clear();
			while (reader.Read())
			{
				ListViewItem item = new ListViewItem(reader["ID"].ToString());
				lvRole.Items.Add(item);
				item.SubItems.Add(reader["RoleName"].ToString());
			}

			connection.Close();

			connection.Open();

			command2.CommandText = "select [ID] from RoleAccount A,Role B where A.RoleID = B.ID and A.AccountName = N'" + accountName + "'";
			SqlDataReader reader1 = command2.ExecuteReader();
			while (reader1.Read())
			{
				foreach (ListViewItem item in lvRole.Items)
				{
					if (reader1["ID"].ToString() == item.Text.ToString())
					{
						item.Checked = true;
					}
				}
			}
			connection.Close();
			connection.Dispose();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtRoleName.Text))
				MessageBox.Show("Tên vai trò không được bỏ trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
				SqlConnection connection = new SqlConnection(connectionString);

				SqlCommand command = connection.CreateCommand();
				command.CommandText = "EXEC Role_Insert @RoleID, @RoleName";

				command.Parameters.Add("@RoleID", SqlDbType.Int);
				command.Parameters.Add("@RoleName", SqlDbType.NVarChar);

				command.Parameters["@RoleID"].Direction = ParameterDirection.Output;
				command.Parameters["@RoleName"].Value = txtRoleName.Text;

				connection.Open();
				int numRowAffected = command.ExecuteNonQuery();
				if (numRowAffected == 1)
					MessageBox.Show("Thêm vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Thêm vai trò không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				connection.Close();
				connection.Dispose();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand command = connection.CreateCommand();

			connection.Open();

			command.CommandText = "delete from RoleAccount where [AccountName] = N'" + account + "'";
			command.ExecuteNonQuery();

			foreach (ListViewItem item in lvRole.CheckedItems)
			{
				command.CommandText = "EXEC UpdateRole @RoleID, @RoleName, @Path, @Notes";
				numOfRowsAffered += command.ExecuteNonQuery();
			}
			connection.Close();
			if (numOfRowsAffered == this.lvRole.CheckedItems.Count)
			{
				MessageBox.Show("Cập nhật thành công");
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void RoleForm_Load(object sender, EventArgs e)
		{
		}
	}
}
