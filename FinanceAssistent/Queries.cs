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

            public static readonly string TipDohoda = @"select nazvanie as Название from TipDohoda";

            public static readonly string TipRashoda = @"select nazvanie as Название from TipRashoda";

            public static readonly string Dohod = @"select TipDohoda.nazvanie as 'Тип дохода', Semya.name as 'Член семьи', Dohod.summa as Сумма, Dohod.data as Дата 
                                                    from Dohod, TipDohoda, Semya 
                                                    where Dohod.id_tip_dohoda = TipDohoda.id and Dohod.id_semya = Semya.id";

            public static readonly string Rashod = @"select TipRashoda.nazvanie as 'Тип расхода', Semya.name as 'Член семьи', Rashod.summa as Сумма, Rashod.data as Дата 
                                                    from Rashod, Semya, TipRashoda 
                                                    where Rashod.id_tip_rashoda = TipRashoda.id and Rashod.id_semya = Semya.id";

            public static readonly string Semya = @"select name as 'Член семьи', username as 'Имя пользователя' from Semya";
        }

        public static class InsertQueries
        {
            public static string GetUserInsertSQL(string login, string password, string name)
            {
                return $"insert into Users values('{login}', '{password}', '{name}')";
            }
            
            public static string GetTipDohodaInsertSQL(string nazvanie)
            {
                return $"insert into TipDohoda values('{nazvanie}')";
            }

            public static string GetTipRashodaInsertSQL(string nazvanie)
            {
                return $"insert into TipRashoda values('{nazvanie}')";
            }

            public static string GetSemyaInsertSQL(string user, string name)
            {
                return $"insert into Semya values({user}, '{name}')";
            }

            public static string GetDohodInsertSQL(int idTipDohoda, int idSemya, double summa, string data)
            {
                return $"insert into Dohod values({idTipDohoda}, {idSemya}, {summa}, '{data}')";
            }

            public static string GetRashodInsertSQL(int idTipDohoda, int idSemya, double summa, string data)
            {
                return $"insert into Rashod values({idTipDohoda}, {idSemya}, {summa}, '{data}')";
            }
        }

        public static class UpdateQueries
        {
            public static string GetDohodUpdateSQL(string oldTipDohoda, string oldSemya, double oldSumma, string oldData, string tipDohoda, string semya, double summa, string data)
            {
                return $@"update Dohod set id_tip_dohoda = (select id from TipDohoda where nazvanie = '{tipDohoda}'), id_semya = (select id from Semya where name = '{semya}'), summa = {summa}, data = '{data}'
                        where id_tip_dohoda = (select id from TipDohoda where nazvanie = '{oldTipDohoda}') and id_semya = (select id from Semya where name = '{oldSemya}') and summa = {oldSumma} and data = '{oldData}'";
            }
            public static string GetRashodUpdateSQL(string oldTipRashoda, string oldSemya, double oldSumma, string oldData, string tipRashoda, string semya, double summa, string data)
            {
                return $@"update Rashod set id_tip_rashoda = (select id from TipRashoda where nazvanie = '{tipRashoda}'), id_semya = (select id from Semya where name = '{semya}'), summa = {summa}, data = '{data}'
                        where id_tip_rashoda = (select id from TipRashoda where nazvanie = '{oldTipRashoda}') and id_semya = (select id from Semya where name = '{oldSemya}') and summa = {oldSumma} and data = '{oldData}'";
            }
            public static string GetTipDohodaUpdateSQL(string oldName, string newName)
            {
                return $"update TipDohoda set nazvanie = '{newName}' where nazvanie = '{oldName}'";
            }

            public static string GetTipRashodaUpdateSQL(string oldName, string newName)
            {
                return $"update TipRashoda set nazvanie = '{newName}' where nazvanie = '{oldName}'";
            }
        }
    }
}
