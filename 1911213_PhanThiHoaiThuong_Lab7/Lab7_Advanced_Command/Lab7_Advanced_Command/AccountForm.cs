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
	public partial class AccountForm : Form
	{
		public AccountForm()
		{
			InitializeComponent();
		}

		private void AccountForm_Load(object sender, EventArgs e)
		{
			LoadAccount();
		}
		private void LoadAccount()
		{
			string connString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connString);

			SqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT AccountName, Password, FullName, Email, Tell, DateCreated FROM Account";
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();

			connection.Open();

			adapter.Fill(dt);
			dgvAccount.DataSource = dt;

			dgvAccount.Columns[0].HeaderText = "Tên tài khoản";
			dgvAccount.Columns[1].HeaderText = "Mật khẩu";
			dgvAccount.Columns[2].HeaderText = "Tên đầy đủ";
			dgvAccount.Columns[3].HeaderText = "Email";
			dgvAccount.Columns[4].HeaderText = "Số điện thoại";
			dgvAccount.Columns[5].HeaderText = "Ngày tạo tài khoản";
			connection.Close();
		}

		private void tsmRole_Click(object sender, EventArgs e)
		{
			if (dgvAccount.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgvAccount.SelectedRows[0];
				string accountName = row.Cells[0].Value.ToString();
				RoleForm frm = new RoleForm();
				frm.LoadRoles(accountName);
				if (frm.ShowDialog() == DialogResult.OK)
				{
					this.LoadAccount();
				}
			}
		}

		private void tsmDiary_Click(object sender, EventArgs e)
		{

		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string connString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
				SqlConnection connection = new SqlConnection(connString);

				SqlCommand command = connection.CreateCommand();
				command.CommandText = "EXECUTE InsertAccount @account,@pass,@fullname,@email,@tell,@date";

				command.Parameters.Add("@account", SqlDbType.NVarChar, 100);
				command.Parameters.Add("@pass", SqlDbType.NVarChar, 200);
				command.Parameters.Add("@fullname", SqlDbType.NVarChar, 1000);
				command.Parameters.Add("@email", SqlDbType.NVarChar, 1000);
				command.Parameters.Add("@tell", SqlDbType.NVarChar, 200);
				command.Parameters.Add("@date", SqlDbType.SmallDateTime);

				command.Parameters["@account"].Value = txtAccountName.Text;
				command.Parameters["@pass"].Value = txtPassword.Text;
				command.Parameters["@fullname"].Value = txtFullName.Text;
				command.Parameters["@email"].Value = txtEmail.Text;
				command.Parameters["@tell"].Value = txtTell.Text;
				command.Parameters["@date"].Value = DateTime.Now.ToShortDateString();

				connection.Open();

				int numOfRows = command.ExecuteNonQuery();

				if (numOfRows == 1)
				{
					LoadAccount();
					ResetForm();
					MessageBox.Show("Thêm tài khoản thành công");
				}
				else
				{
					MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				}

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "SQL Error");
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				string connString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
				SqlConnection connection = new SqlConnection(connString);

				SqlCommand command = connection.CreateCommand();
				command.CommandText = "EXECUTE UpdateAccount @account,@pass,@fullname,@email,@tell,@date";

				command.Parameters.Add("@account", SqlDbType.NVarChar, 100);
				command.Parameters.Add("@pass", SqlDbType.NVarChar, 200);
				command.Parameters.Add("@fullname", SqlDbType.NVarChar, 1000);
				command.Parameters.Add("@email", SqlDbType.NVarChar, 1000);
				command.Parameters.Add("@tell", SqlDbType.NVarChar, 200);
				command.Parameters.Add("@date", SqlDbType.SmallDateTime);

				command.Parameters["@account"].Value = txtAccountName.Text;
				command.Parameters["@pass"].Value = txtPassword.Text;
				command.Parameters["@fullname"].Value = txtFullName.Text;
				command.Parameters["@email"].Value = txtEmail.Text;
				command.Parameters["@tell"].Value = txtTell.Text;
				command.Parameters["@date"].Value = DateTime.Now.ToShortDateString();

				connection.Open();

				int numOfRows = command.ExecuteNonQuery();

				if (numOfRows == 1)
				{
					LoadAccount();
					ResetForm();
					MessageBox.Show("Cập nhật tài khoản thành công");
				}
				else
				{
					MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				}

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "SQL Error");
			}
		}
		private void ResetForm()
		{
			txtAccountName.Text = "";
			txtPassword.Text = "";
			txtFullName.Text = "";
			txtEmail.Text = "";
			txtTell.Text = "";
			btnUpdate.Enabled = false;
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvAccount_Click(object sender, EventArgs e)
		{
			int index = dgvAccount.CurrentRow.Index;
			if (index != null)
			{
				txtAccountName.Text = dgvAccount.Rows[index].Cells["AccountName"].Value.ToString();
				txtPassword.Text = dgvAccount.Rows[index].Cells["Password"].Value.ToString();
				txtFullName.Text = dgvAccount.Rows[index].Cells["FullName"].Value.ToString();
				txtEmail.Text = dgvAccount.Rows[index].Cells["Email"].Value.ToString();
				txtTell.Text = dgvAccount.Rows[index].Cells["Tell"].Value.ToString();

				btnUpdate.Enabled = true;
			}
		}
	}
}
