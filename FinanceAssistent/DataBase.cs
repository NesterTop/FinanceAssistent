using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinanceAssistent
{
    public class DataBase : IDisposable
    {
        public string ConnectionString { get; set; } = @"Data Source=DESKTOP-A9MP2FF\SQLEXPRESS;Initial Catalog=DataBase;Integrated Security=True";
        SqlConnection _sqlConnection = new SqlConnection();

        public DataBase()
        {
            _sqlConnection.ConnectionString = this.ConnectionString;
        }
        public void Open()
        {
            _sqlConnection.Open();
        }

        public bool Close()
        {
            _sqlConnection.Close();
            
            if( _sqlConnection.State != ConnectionState.Closed)
            {
                return false;
            }

            return true;
        }

        public SqlConnection GetConnection() { return _sqlConnection; }

        public DataTable SelectData(string sql)
        {
            DataTable dt = new DataTable();
            dt.Load(new SqlCommand(sql, _sqlConnection).ExecuteReader());
                       
            return dt;
        }

        public object SelectScalar(string sql)
        {
            object result = new SqlCommand(sql, _sqlConnection).ExecuteScalar();
            return result;
        }
        public bool InsertOrDeleteData(string sql)
        {
            SqlCommand command = new SqlCommand(sql, _sqlConnection);

            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить действие");
                return false;
            }
        }

        public void Dispose()
        {
            Close();
        }
    }
}
