using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linije_73_2019
{
    public class LinijaDb : ILinija
    {
        public static int IdStatic;

        private SqlConnection _connection = DbConnection.Connection;

        public void ubaciRezulatate(int Id, int Poeni, String Timer, DateTime Datum)
        {
            _connection.Open();

            string query = "INSERT INTO najboljiRezultati(Id, Poeni, Timer, Datum) VALUES (@Id, @Poeni, @Timer, @Datum)";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Poeni", Poeni);
            command.Parameters.AddWithValue("@Timer", Timer);
            command.Parameters.AddWithValue("@Datum", Datum);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public List<Result> dajSveRezultate()
        {
            List<Result> rezultati = new List<Result>();

            _connection.Open();

            String query = @"select * from najboljiRezultati;";

            SqlCommand command = new SqlCommand(query, _connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                rezultati.Add(new Result(
                                            int.Parse(reader["Id"].ToString()),
                                            int.Parse(reader["Poeni"].ToString()),
                                            reader["Timer"].ToString(),
                                            DateTime.Parse(reader["Datum"].ToString())
                                            ));
            }

            _connection.Close();
            return rezultati;

        }
        
        public string dajNajboljiRezultat()
        {
            string najbolji;
            
            _connection.Open();

            String query = @"select nr1.*
                            from najboljiRezultati nr1 left join najboljiRezultati nr2
                            on nr1.Poeni < nr2.Poeni
                            where nr2.Poeni is null";

            SqlCommand command = new SqlCommand(query, _connection);

            SqlDataReader reader = command.ExecuteReader();

            najbolji = reader["Poeni"].ToString();
            
            _connection.Close();
            return najbolji;
        }
    }
}
