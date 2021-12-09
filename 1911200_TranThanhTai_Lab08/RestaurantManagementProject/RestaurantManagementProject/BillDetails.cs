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

namespace RestaurantManagementProject
{
	public partial class BillDetails : Form
	{
		public BillDetails()
		{
			InitializeComponent();
		}
		public void LoadOrderDetails(string IDBills)
		{
			string connectionString = @"Data Source=HOAITHUONG\HTK43;Initial Catalog=RestaurantManagement1;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
			sqlConnection.Open();
			sqlCommand.CommandText = "select A.[ID],B.[Name] as 'Tên món ăn',B.[Price] as 'Đơn giá',[Quantity] as 'Số lượng',B.Price*Quantity as 'Thành tiền' " +
				 "from BillDetails A,Food B where A.FoodID = B.ID and[InvoiceID] = " + IDBills;

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Bills");
			da.Fill(dt);
			dgvBillDetails.DataSource = dt;

			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
	}
}
