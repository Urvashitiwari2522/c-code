using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connString = @"Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True";

        using (SqlConnection conn = new SqlConnection(connString))
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT RollNo, Name, Marks FROM Student", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("RollNo\tName\tMarks");
            Console.WriteLine("---------------------------");

            while (dr.Read())
            {
                Console.WriteLine(dr["RollNo"] + "\t" + dr["Name"] + "\t" + dr["Marks"]);
            }
        }

        Console.ReadLine();
    }
}