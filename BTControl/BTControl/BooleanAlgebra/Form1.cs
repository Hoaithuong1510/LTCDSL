using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooleanAlgebra
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void lblOperation_Click(object sender, EventArgs e)
		{

		}

		private void chkOperand1_CheckedChanged(object sender, EventArgs e)
		{
			if (chkOperand1.Checked == true)
				chkOperand1.Text = "True";
			else
				chkOperand1.Text = "False";
		}
        private void chkOperand2_CheckedChanged(object sender, EventArgs e)
		{
			if (chkOperand2.Checked == true)
				chkOperand2.Text = "True";
			else
				chkOperand2.Text = "False";
		}
		private void chkResult_CheckedChanged(object sender, EventArgs e)
		{
			if (chkResult.Checked == true)
				chkResult.Text = "True";
			else
				chkResult.Text = "False";
		}

		private void btnNewOperation_Click(object sender, EventArgs e)
		{
			string[] strBooleanValues = { "True", "False" };
			string[] strOperation = { "A ^ B", "A V B" };
			Random rnd = new Random();

			chkOperand1.Text = strBooleanValues[rnd.Next(2)];
			chkOperand2.Text = strBooleanValues[rnd.Next(2)];

			if (chkOperand1.Checked == true)
				chkOperand1.Text = "True";
			else
				chkOperand1.Text = "False";

			if (chkOperand2.Checked == true)
				chkOperand2.Text = "True";
			else
				chkOperand2.Text = "False";
			lblOperation.Text = strOperation[rnd.Next(2)];
		}

		private void btnCheckOperation_Click(object sender, EventArgs e)
		{
			if (lblOperation.Text == "A ^ B")
				// If A = true
				if (chkOperand1.Checked == true)
				{
					if (chkOperand2.Checked == true)
					{
						if (chkResult.Checked == true)
						{
							MessageBox.Show(" Bravo - Good answer");
						}
						else if (chkResult.Checked == false)
						{
							MessageBox.Show(" Wrong - Get it right next time!");
						}
					}
					else if (chkOperand2.Checked == false)
					{
						if (chkResult.Checked == false)
						{
							MessageBox.Show("Bravo - Good answer");
						}
						else if (chkResult.Checked == true)
						{
							MessageBox.Show("Wrong - Get it right next time!");
						}
					}
				}
				else if (chkOperand1.Checked == false)
				{
					if (chkOperand2.Checked == true)
					{
						if (chkResult.Checked == false)
						{
							MessageBox.Show("Bravo - Good answer");
						}
						else if (chkResult.Checked == true)
						{
							MessageBox.Show("Wrong - Get it right next time!");
						}
					}
					else if (chkOperand2.Checked == false)
					{
						if (chkResult.Checked == false)
						{
							MessageBox.Show("Bravo - Good answer");
						}
						else if (chkResult.Checked == true)
						{
							MessageBox.Show("Wrong - Get it right next time!");
						}
					}
				}
				else if (lblOperation.Text == "A V B") 
				{
					if (chkOperand1.Checked == true)
					{
						if (chkOperand2.Checked == true)
						{
							if (chkResult.Checked == true)
							{
								MessageBox.Show("Bravo - Good answer");
							}
							else if (chkResult.Checked == false)
							{
								MessageBox.Show("Wrong - Get it right next time!");
							}
						}
						else if (chkOperand2.Checked == false)
						{
							if (chkResult.Checked == true)
							{
								MessageBox.Show("Bravo - Good answer");
							}
							else if (chkResult.Checked == false)
							{
								MessageBox.Show("Wrong - Get it right next time!");
							}
						}
					}
					else if (chkOperand1.Checked == false)
					{
						if (chkOperand2.Checked == true)
						{
							if (chkResult.Checked == true)
							{
								MessageBox.Show("Bravo - Good answer");
							}
							else if (chkResult.Checked == false)
							{
								MessageBox.Show("Wrong - Get it right next time!");
							}
						}
						else if (chkOperand2.Checked == false)
						{
							if (chkResult.Checked == false)
							{
								MessageBox.Show("Bravo - Good answer");
							}
							else if (chkResult.Checked == true)
							{
								MessageBox.Show("Wrong - Get it right next time!");
							}
						}
					}
				}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
