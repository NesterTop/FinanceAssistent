using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinanceAssistent
{
    public class DataBase
    {
        SqlCommand _sqlCommand;
        SqlConnection _sqlConnection;
        SqlDataReader _reader;
        

        public DataBase(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public void Open()
        {
            _sqlConnection.Open();
        }

        public void Close()
        {
            _sqlConnection.Close();
        }

        public DataSet GetTipDohoda()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = new SqlCommand("select nazvanie as Название from TipDohoda", _sqlConnection);
            adapter.Fill(dataSet);
            return dataSet;
        }
    }
}
