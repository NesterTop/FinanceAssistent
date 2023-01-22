using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinanceAssistent
{
    public class DataBaseContext
    {
        SqlCommand _sqlCommand;
        SqlConnection _connection;
        SqlDataReader _reader = null;
        public List<User> Users = new List<User>();
        public List<TipDohoda> TipDohoda = new List<TipDohoda>();

        public DataBaseContext(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public void Open()
        {
            Users.Clear();
            TipDohoda.Clear();

            _connection.Open();
            _sqlCommand = new SqlCommand();

            _sqlCommand.CommandText = "select * from TipDohoda";
            _sqlCommand.Connection = _connection;
             _reader = _sqlCommand.ExecuteReader();

            while (_reader.Read())
            {
                TipDohoda.Add(new TipDohoda()
                {
                    Id = (int)_reader["id"],
                    Nazvanie = (string)_reader["nazvanie"]
                });
            }
            _reader.Close();

            char c = '"';
            _sqlCommand.CommandText = $"select * from {c}User{c}";
            _reader = _sqlCommand.ExecuteReader();

            while (_reader.Read())
            {
                Users.Add(new User()
                {
                    Id = (int)_reader["id"],
                    Login = (string)_reader["login"],
                    Password = (string)_reader["password"]
                });
            }
            _reader.Close();
        }

        public void Close()
        {
            _connection.Close();
        }

        public void SaveChanges()
        {
            char c = '"';
            _sqlCommand.CommandText = "DELETE FROM TipDohoda";
            _sqlCommand.ExecuteNonQuery();
            
            _sqlCommand.CommandText = $"DELETE FROM {c}User{c}";
            _sqlCommand.ExecuteNonQuery();

            for (int i = 0; i < Users.Count; i++)
            {

                _sqlCommand.CommandText = $"INSERT INTO {c}User{c} VALUES({i},'{Users[i].Login}','{Users[i].Password}')";
                _sqlCommand.ExecuteNonQuery();
            }

            for (int i = 0; i < TipDohoda.Count; i++)
            {
                _sqlCommand.CommandText = $"INSERT INTO TipDohoda VALUES({i},'{TipDohoda[i].Nazvanie}')";
                _sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
