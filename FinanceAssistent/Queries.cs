using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAssistent
{
    public class Queries
    {
        public static class SelectQueries
        {
            public static readonly string TipDohoda = "select nazvanie as Название from TipDohoda";
            public static readonly string TipRashoda = "select nazvanie as Название from TipRashoda";
            public static readonly string User = $"select * from Users";
        }

        public static class InsertQueries
        {
            public static string GetUserInsertSQL(int id, string login, string password, string name)
            {
                return $"insert into Users values({id}, '{login}', '{password}', '{name}')";
            }

            
        }
    }
}
