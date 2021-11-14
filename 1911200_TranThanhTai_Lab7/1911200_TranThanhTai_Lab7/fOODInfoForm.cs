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

namespace _1911200_TranThanhTai_Lab7
{
	public partial class fOODInfoForm : Form
	{
		public fOODInfoForm()
		{
			InitializeComponent();
		}

		private void fOODInfoForm_Load(object sender, EventArgs e)
		{
			this.InitValues();
		}

		private void InitValues()
		{
			string connectionString = @"Data Source=WINDOWS-10\TRANTHANHTAI;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);

			SqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT ID, Name FROM Category";

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataSet dataset = new DataSet();

			connection.Open();

			adapter.Fill(dataset, "Category");

			cbbCatName.DataSource = dataset.Tables["Category"];
			cbbCatName.DisplayMember = "Name";
			cbbCatName.ValueMember = "ID";

			connection.Close();
		}

		private void ResetText()
		{
			txtFoodID.ResetText();
			txtName.ResetText();
			txtNotes.ResetText();
			txtUnit.ResetText();
			cbbCatName.ResetText();
			nudPrice.ResetText();
		}


		private void btnAddFood_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = @"Data Source=WINDOWS-10\TRANTHANHTAI;Initial Catalog=RestaurantManagement;Integrated Security=True";
				SqlConnection connection = new SqlConnection(connectionString);

				SqlCommand command = connection.CreateCommand();
				command.CommandText = "EXECUTE InsertFood @id OUTPUT, @name, @unit, @foodCategoryID, @price, @notes";

				command.Parameters.Add("@id", SqlDbType.Int);
				command.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				command.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
				command.Parameters.Add("@foodCategoryID", SqlDbType.Int);
				command.Parameters.Add("@price", SqlDbType.Int);
				command.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

				command.Parameters["@id"].Direction = ParameterDirection.Output;

				command.Parameters["@name"].Value = txtName.Text;
				command.Parameters["@unit"].Value = txtUnit.Text;
				command.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;
				command.Parameters["@price"].Value = nudPrice.Value;
				command.Parameters["@notes"].Value = txtNotes.Text;

				connection.Open();

				int numRowAffected = command.ExecuteNonQuery();

				if (numRowAffected > 0)
				{
					string foodID = command.Parameters["@id"].Value.ToString();
					MessageBox.Show($"Successfully adding new food. Food ID = {foodID}", "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Adding food fail");
				}

				connection.Close();
				connection.Dispose();
			}
			catch (SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}

		public void DisplayFoodInfo(DataRowView rowView)
		{
			try
			{
				txtFoodID.Text = rowView["ID"].ToString();
				txtName.Text = rowView["Name"].ToString();
				txtUnit.Text = rowView["Unit"].ToString();
				txtNotes.Text = rowView["Notes"].ToString();
				nudPrice.Value = decimal.Parse(rowView["Price"].ToString());

				cbbCatName.SelectedIndex = -1;

				for (int index = 0; index < cbbCatName.Items.Count; index++)
				{
					DataRowView cat = cbbCatName.Items[index] as DataRowView;
					if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
					{
						cbbCatName.SelectedIndex = index;
						break;
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
				this.Close();
			}
		}

		private void btnUpdateFood_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = @"Data Source=WINDOWS-10\TRANTHANHTAI;Initial Catalog=RestaurantManagement;Integrated Security=True";
				SqlConnection connection = new SqlConnection(connectionString);

				SqlCommand command = connection.CreateCommand();
				command.CommandText = "EXECUTE UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

				command.Parameters.Add("@id", SqlDbType.Int);
				command.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				command.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
				command.Parameters.Add("@foodCategoryID", SqlDbType.Int);
				command.Parameters.Add("@price", SqlDbType.Int);
				command.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

				command.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
				command.Parameters["@name"].Value = txtName.Text;
				command.Parameters["@unit"].Value = txtUnit.Text;
				command.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;
				command.Parameters["@price"].Value = nudPrice.Value;
				command.Parameters["@notes"].Value = txtNotes.Text;

				connection.Open();

				int numRowAffected = command.ExecuteNonQuery();

				if (numRowAffected > 0)
				{
					MessageBox.Show("Successfully updateing food", "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Adding food fail");
				}

				connection.Close();
				connection.Dispose();
			}
			catch (SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}

		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void CategoryForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			InitValues();
		}
	}
}
