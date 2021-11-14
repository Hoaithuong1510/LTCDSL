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
	public partial class CategoryForm : Form
	{
		public CategoryForm()
		{
			InitializeComponent();
		}
		private void LoadType()
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);

			SqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT DISTINCT Type From Category";

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();

			connection.Open();

			adapter.Fill(dt);
			connection.Close();

			cbbCateType.DataSource = dt;
			cbbCateType.DisplayMember = "Type";
		}
		private void ResetText()
		{
			txtCateName.ResetText();
			cbbCateType.ResetText();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
				SqlConnection connection = new SqlConnection(connectionString);

				SqlCommand command = connection.CreateCommand();
				command.CommandText = "EXECUTE InsertCategory @id output, @name, @type";

				command.Parameters.Add("@id", SqlDbType.Int);
				command.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				command.Parameters.Add("@type", SqlDbType.Int);

				command.Parameters["@id"].Direction = ParameterDirection.Output;
				command.Parameters["@name"].Value = txtCateName.Text;
				command.Parameters["@type"].Value = cbbCateType.Text;

				connection.Open();

				int numRowAffected = command.ExecuteNonQuery();

				if (numRowAffected > 0)
				{
					string foodID = command.Parameters["@id"].Value.ToString();
					MessageBox.Show($"Successfully adding new category", "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Adding category fail");
				}

				connection.Close();
				connection.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Sql Error");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CategoryForm_Load(object sender, EventArgs e)
		{
			LoadType();
		}
	}
}
			

