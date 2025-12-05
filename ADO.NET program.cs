using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connString = @"Data Source=YOUR_SERVER;
                              Initial Catalog=YOUR_DATABASE;
                              Integrated Security=True";

        using (SqlConnection conn = new SqlConnection(connString))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", conn);

            // CommandBuilder auto-generates INSERT, UPDATE, DELETE
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Student");

            Console.WriteLine("Original Marks of RollNo=1: " +
                ds.Tables["Student"].Rows[0]["Marks"]);

            // Modify DataSet value
            ds.Tables["Student"].Rows[0]["Marks"] = 99;

            // Apply update to database
            da.Update(ds, "Student");

            Console.WriteLine("Database Updated!");
        }

        Console.ReadLine();
    }
}
