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

    /// <summary>
    /// Öffnet die Verbindung zur SQLite-Datenbank, falls sie nicht bereits geöffnet ist.
    /// </summary>
    private void OpenConnection()
    {
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    /// <summary>
    /// Schließt die Verbindung zur SQLite-Datenbank.
    /// </summary>
    private void CloseConnection()
    {
        if (connection != null && connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }

    /// <summary>
    /// Gibt eine Liste der Tabellennamen in der Datenbank zurück.
    /// </summary>
    /// <returns>Liste der Tabellennamen</returns>
    public DataTable GetTables()
    {
        OpenConnection();
        DataTable tables = new DataTable();

        // Hole die Tabellenliste aus der SQLite-Datenbank
        tables = connection.GetSchema("Tables");

        return tables;
    }

    /// <summary>
    /// Gibt die Spalten einer bestimmten Tabelle zurück.
    /// </summary>
    /// <returns>DataTable mit Spalteninformationen</returns>
    public DataTable GetTableColumns(string tableName)
    {
        OpenConnection();
        DataTable columns = new DataTable();

        // PRAGMA-Abfrage für die Tabellenspalten
        string query = $"PRAGMA table_info({tableName})";
        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                columns.Load(reader);
            }
        }

        return columns;
    }

    /// <summary>
    /// Gibt die Daten einer Tabelle zurück.
    /// </summary>
    /// <returns>DataTable mit Tabellendaten</returns>
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

        return dt;
    }

    /// <summary>
    /// Gibt die Daten einer bestimmten Spalte zurück.
    /// </summary>
    /// <returns>DataTable mit Tabellendaten</returns>
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

        return dt;
    }

    /// <summary>
    /// Schließt die Verbindung manuell, wenn sie nicht mehr benötigt wird.
    /// </summary>
    public void Close()
    {
        CloseConnection();
    }
}
