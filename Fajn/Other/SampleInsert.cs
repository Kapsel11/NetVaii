using System;
using System.Data.SqlClient;

namespace Fajn.Other
{
    public class SampleInsert
    {
        public void InsertData()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-Fajn-714ED4AD-1533-4C81-9C26-F9553BB6104A;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "INSERT INTO AllGames (White,Black,Result,Date,Event,Pgn) VALUES ('Carlsen','Nepomniatchi','1/2','28.11.2021', 'World Chess Championship 2021', 'C:/Users/thedj/Source/Repos/Kapsel11/NetVaii/Fajn/wwwroot/Pgn/Root/Carlsen-Nepomniatchi.pgn'), ('Karpov', 'Kasparov', '0-1', '6.4.1990', 'Fide Chess Cup', 'C:/Users/thedj/Source/Repos/Kapsel11/NetVaii/Fajn/wwwroot/Pgn/Root/Karpov-Kasparov.pgn'), ('Karpov', 'Kasparov', '0-1', '6.7.1985', 'World Chess Championship 1985', 'C:/Users/thedj/Source/Repos/Kapsel11/NetVaii/Fajn/wwwroot/Pgn/Root/Karpov-Kasparov1.pgn'), ('Carlsen', 'Kasparov', '0-1', '11.5.2005', 'Fide Chess Cup', 'C:/Users/thedj/Source/Repos/Kapsel11/NetVaii/Fajn/wwwroot/Pgn/Root/Karpov-Kasparov.pgn'),('Kramnik', 'Gelfand', '1-0', '6.4.1990', 'Fide Chess Cup', 'C:/Users/thedj/Source/Repos/Kapsel11/NetVaii/Fajn/wwwroot/Pgn/Root/Kramnik-Gelfand.pgn'),('Kramnik', 'Kasparov', '1/2', '8.10.2000', 'Wolrd Chess Championship', 'C:/Users/thedj/Source/Repos/Kapsel11/NetVaii/Fajn/wwwroot/Pgn/Root/Kramnik-Kasparov.pgn')";
              
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
