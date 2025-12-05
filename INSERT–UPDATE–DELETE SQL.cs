using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connString = @"Data Source=YOUR_SERVER;
                              Initial Catalog=YOUR_DATABASE;
                              Integrated Security=True";

        SqlConnection conn = new SqlConnection(connString);

        try
        {
            conn.Open();
            Console.WriteLine("Connection Opened.");

            // INSERT
            SqlCommand insertCmd = new SqlCommand(
                "INSERT INTO Student (RollNo, Name, Marks) VALUES (4, 'Amit', 88)", conn);
            insertCmd.ExecuteNonQuery();
            Console.WriteLine("Record Inserted!");

            // UPDATE
            SqlCommand updateCmd = new SqlCommand(
                "UPDATE Student SET Marks = 95 WHERE RollNo = 4", conn);
            updateCmd.ExecuteNonQuery();
            Console.WriteLine("Record Updated!");

            // DELETE
            SqlCommand deleteCmd = new SqlCommand(
                "DELETE FROM Student WHERE RollNo = 4", conn);
            deleteCmd.ExecuteNonQuery();
            Console.WriteLine("Record Deleted!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            conn.Close();
            Console.WriteLine("Connection Closed.");
        }

        Console.ReadLine();
    }
}
