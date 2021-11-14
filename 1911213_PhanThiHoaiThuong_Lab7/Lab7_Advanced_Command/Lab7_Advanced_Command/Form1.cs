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
	public partial class Form1 : Form
	{
		private DataTable foodTable;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadCategory();
		}

		private void LoadCategory()
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			connection.Open();

			command.CommandText = "SELECT ID, Name FROM Category";
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable("Category");

			adapter.Fill(table);

			cbbCategory.DataSource = table;
			cbbCategory.DisplayMember = "Name";
			cbbCategory.ValueMember = "ID";

			connection.Close();
			connection.Dispose();
		}

		private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbCategory.SelectedIndex == -1) return;

			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			command.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";
			command.Parameters.Add("@categoryId", SqlDbType.Int);

			if (cbbCategory.SelectedValue is DataRowView)
			{
				DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
				command.Parameters["@categoryId"].Value = rowView["ID"];
			}
			else
			{
				command.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
			}

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			foodTable = new DataTable();

			connection.Open();

			adapter.Fill(foodTable);

			connection.Close();
			connection.Dispose();

			dgvFoodList.DataSource = foodTable;

			lblQuantity.Text = foodTable.Rows.Count.ToString();
			lblCatName.Text = cbbCategory.Text;
		}

		private void tsmCalculateQuantity_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

			if (dgvFoodList.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];

				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				command.Parameters.Add("@foodId", SqlDbType.Int);
				command.Parameters["@foodId"].Value = rowView["ID"];

				command.Parameters.Add("@numSaleFood", SqlDbType.Int);
				command.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

				connection.Open();

				command.ExecuteNonQuery();

				string result = command.Parameters["@numSaleFood"].Value.ToString();
				string message = $"Tổng số lượng món {rowView["Name"]} đã bán là {result} {rowView["Unit"]}";

				if (string.IsNullOrWhiteSpace(result))
					message = $"Món {rowView["Name"]} chưa bán được {rowView["Unit"]} nào!";

				MessageBox.Show(message);

				connection.Close();
			}

			command.Dispose();
			connection.Dispose();
		}

		private void tsmAddFood_Click(object sender, EventArgs e)
		{
			foodInfoForm formFood = new foodInfoForm();
			formFood.FormClosed += FormFood_FormClosed;

			formFood.Show(this);
		}

		private void FormFood_FormClosed(object sender, FormClosedEventArgs e)
		{
			int index = cbbCategory.SelectedIndex;
			cbbCategory.SelectedIndex = -1;
			cbbCategory.SelectedIndex = index;
		}

		private void tsmUpdateFood_Click(object sender, EventArgs e)
		{
			if (dgvFoodList.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				foodInfoForm foodForm = new foodInfoForm();
				foodForm.FormClosed += new FormClosedEventHandler(FormFood_FormClosed);

				foodForm.Show(this);
				foodForm.DisplayFoodInfo(rowView);
			}
		}

		private void txtSearchByName_TextChanged(object sender, EventArgs e)
		{
			if (foodTable == null) return;
			string filterExpression = "Name like '%" + txtSearchByName.Text + "%'";
			string sortExpression = "Price DESC";
			DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
			DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowStateFilter);
			dgvFoodList.DataSource = foodView;
		}

		private void billToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OrderForm formOrder = new OrderForm();
			formOrder.Show();
		}

		private void accountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AccountForm formAccount = new AccountForm();
			formAccount.Show();
		}
	}
}
