using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Use a proper connection string (Change server/database name)
        string connString = @"Data Source=YOUR_SERVER_NAME;
                              Initial Catalog=YOUR_DATABASE;
                              Integrated Security=True";

        using (SqlConnection conn = new SqlConnection(connString))
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connection State: " + conn.State);
                Console.WriteLine("Connection Successfully Established!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Connection Closed. Current State: " + conn.State);
            }
        }

        Console.ReadLine();
    }
}
