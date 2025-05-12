using Microsoft.Data.Sqlite;
using System.Windows;
namespace YouFitness;

public partial class App : Application
{
    public App()
    {
        //InitializeComponent();

        //string connectionString = "Data Source=../../../DB/DataBase.db";

        //using (var connection = new SqliteConnection(connectionString))
        //{
        //    connection.Open();
        //    string createTable = "CREATE TABLE IF NOT EXISTS Users " +
        //        "(Id INTEGER PRIMARY KEY," +
        //        "Name TEXT)";

        //    using (var command = new SqliteCommand("PRAGMA foreign_keys = ON;", connection))
        //    {
        //        command.ExecuteNonQuery();
        //    }

        //    using (var command = new SqliteCommand(createTable, connection))
        //    {
        //        command.ExecuteNonQuery();
        //    }
        //}
    }
}
