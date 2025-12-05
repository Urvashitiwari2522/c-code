using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        LoadData();
    }

    void LoadData()
    {
        string connString = @"Data Source=YOUR_SERVER;
                              Initial Catalog=YOUR_DATABASE;
                              Integrated Security=True";

        using (SqlConnection conn = new SqlConnection(connString))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
