using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Sqlite_Database_Manager;

public class ConnectionManager
{
    private string connectionString;
    private SQLiteConnection connection;
    private SQLiteTransaction transaction;
    private Engine engine;

    public ConnectionManager(string conStr)
    {
        connectionString = conStr;
        connection = new SQLiteConnection(connectionString);
        engine = new Engine();
    }


    private void OpenConnection()
    {
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }


    private void CloseConnection()
    {
        if (connection != null && connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }


    public DataTable GetTables()
    {
        OpenConnection();
        DataTable tables = new DataTable();


        tables = connection.GetSchema("Tables");
        CloseConnection();
        return tables;
    }


    public DataTable GetTableColumns(string tableName)
    {
        OpenConnection();
        DataTable columns = new DataTable();

        string query = $"PRAGMA table_info({tableName})";
        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                columns.Load(reader);
            }
        }
        CloseConnection();
        return columns;
    }

 
    public DataTable GetTableData(string tableName)
    {
        OpenConnection();
        DataTable dt = new DataTable();

        using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {tableName}", connection))
        {
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
            {
                adapter.Fill(dt);
            }
        }
        CloseConnection();
        return dt;
    }


    public DataTable GetColumnData(string tableName, string columnName)
    {
        OpenConnection();
        DataTable dt = new DataTable();

        using (SQLiteCommand command = new SQLiteCommand($"SELECT {columnName} FROM {tableName}", connection))
        {
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
            {
                adapter.Fill(dt);
            }
        }
        CloseConnection();
        return dt;
    }



}
