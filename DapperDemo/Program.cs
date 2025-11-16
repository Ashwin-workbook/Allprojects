using System;
using System.Data;
using Microsoft.Data.SqlClient; // Ensure you have the NuGet package 'System.Data.SqlClient' installed
using Dapper;
using System.Linq;

class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    private static string connString = "Data Source=DESKTOP-NRN0EQ3;Initial Catalog=TestDB;Integrated Security=True;Encrypt=False";

    public static void Main()
    {
        using (var db = new SqlConnection(connString))
        {
            db.Open();
            
        }
        // Your code here
    }
}