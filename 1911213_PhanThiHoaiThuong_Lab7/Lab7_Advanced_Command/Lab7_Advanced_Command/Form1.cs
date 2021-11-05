﻿using System;
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
		private void LoadCategory ()
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT ID, Name FROM Category";

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			conn.Open();
			adapter.Fill(dt);
			conn.Close();
			conn.Dispose();

			cbbCategory.DataSource = dt;
			cbbCategory.DisplayMember = "Name";
			cbbCategory.ValueMember = "ID";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.LoadCategory();
		}

		private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbCategory.SelectedIndex == -1)
				return;
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";

			cmd.Parameters.Add("categoryId", SqlDbType.Int);
			if(cbbCategory.SelectedValue is DataRowView)
			{
				DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
				cmd.Parameters["categoryId"].Value = rowView["ID"];
			}
			else
			{
				cmd.Parameters["categoryId"].Value = cbbCategory.SelectedValue;
			}

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable foodTable = new DataTable();
			conn.Open();
			adapter.Fill(foodTable);
			conn.Close();
			conn.Dispose();

			dgvFoodList.DataSource = foodTable;
			lblQuantity.Text = foodTable.Rows.Count.ToString();
			lblCatName.Text = cbbCategory.Text;
		}

		private void tsmCalculateQuantity_Click(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";
			if(dgvFoodList.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				cmd.Parameters.Add("@foodId", SqlDbType.Int);
				cmd.Parameters["@foodId"].Value = rowView["ID"];

				cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
				cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

				conn.Open();

				cmd.ExecuteNonQuery();

				string result = cmd.Parameters["@numSaleFood"].Value.ToString();
				MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + result + " " + rowView["Unit"]);

				conn.Close();
			}
			cmd.Dispose();
			conn.Dispose();
		}
	}
}