﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinanceAssistent
{
    public class DataBase : IDisposable
    {
        public string ConnectionString { get; set; } = @"Data Source=DESKTOP-A9MP2FF\SQLEXPRESS;Initial Catalog=DataBase;Integrated Security=True";
        SqlConnection _sqlConnection = new SqlConnection();

        public void Open()
        {
            _sqlConnection.ConnectionString = this.ConnectionString;
            _sqlConnection.Open();
        }

        public void Close()
        {
            _sqlConnection.Close();
        }

        public DataTable SelectData(string sql)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = new SqlCommand(sql, _sqlConnection);
            adapter.Fill(dataSet);
            
            return dataSet.Tables[0];
        }

        public void InsertOrDeleteData(string sql)
        {
            SqlCommand command = new SqlCommand(sql, _sqlConnection);
            command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            Close();
        }
    }
}
