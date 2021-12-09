﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class AccountDA
	{
		public List<Account> GetAll()
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.Account_GetAll;

			SqlDataReader reader = command.ExecuteReader();
			List<Account> list = new List<Account>();
			while (reader.Read())
			{
				Account account = new Account();
				account.AccountName = reader[0].ToString();
				account.Password = reader[1].ToString();
				account.FullName = reader[2].ToString();
				account.Email = reader[3].ToString();
				account.Tell = reader[4].ToString();
				Console.WriteLine(reader[5].ToString());
				account.DateCreated = DateTime.Parse(reader[5].ToString() == "" ? DateTime.MinValue.Date.ToString() : reader[5].ToString());
				list.Add(account);
			}
			sqlConn.Close();
			return list;
		}
		public int Insert_Update_Delete(Account account, int action)
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.Account_InsertUpdateDelete;

			SqlParameter IDPara = new SqlParameter("@AccountName", SqlDbType.NVarChar);
			IDPara.Direction = ParameterDirection.InputOutput;

			command.Parameters.Add(IDPara).Value = account.AccountName;

			command.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = account.FullName;
			command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = account.Email;
			command.Parameters.Add("@Tell", SqlDbType.NVarChar).Value = account.Tell;
			command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = account.Password;
			command.Parameters.Add("@DateCreated", SqlDbType.DateTime).Value = account.DateCreated;
			command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

			int result = command.ExecuteNonQuery();

			if (result > 0)
				return (int)command.Parameters["@ID"].Value;
			return 0;
		}

	}
}
