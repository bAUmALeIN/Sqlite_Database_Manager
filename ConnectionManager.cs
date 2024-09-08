using System;
using System.Data;
using System.Data.SQLite;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Sqlite_Database_Manager;

public class ConnectionManager
{
    private string connectionString;
    private SQLiteConnection connection;
    private SQLiteTransaction transaction;

    public ConnectionManager(string conStr)
    {
        connectionString = conStr;
        connection = new SQLiteConnection(connectionString);
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

    public DataTable ExecuteQuery(string query)
    {
        DataTable dt = new DataTable();
        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    FormMain.logger.WriteLine($"ConnectionManager.ExecuteQuery | query: {query}");

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            
            FormMain.logger.WriteLine($"ConnectionManager.ExecuteQuery | Fehler beim Ausführen der Abfrage: {ex.Message}");
            Config.lasQueryFailText = ex.Message;
            return null;
        }
        
        return dt;
    }

    public DataTable GetTableColumns(string tableName)          // nicht benötigt, iwann vllt
    {
        OpenConnection();
        DataTable columns = new DataTable();

        string query = $"PRAGMA table_info({tableName})";
        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                columns.Load(reader);
                if (reader != null)
                {
                    FormMain.logger.WriteLine($"ConnectionManager.GetTableColums | From {tableName}");

                }
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
                if (dt != null)
                {
                    FormMain.logger.WriteLine($"ConnectionManager.GetTableData| From {tableName}");

                }
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
                if (dt != null)
                {
                    FormMain.logger.WriteLine($"ConnectionManager.GetColumData | Colum : {columnName} from {tableName}");

                }
            }
        }
        CloseConnection();

        return dt;
    }

    public string GetColumnDataType(string tableName, string columnName)
    {
        string columnType = string.Empty;

        OpenConnection();

        string query = $"PRAGMA table_info({tableName})";
        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["name"].ToString() == columnName)
                    {
                        columnType = reader["type"].ToString();
                        break;
                    }
                }
            }
        }

        CloseConnection();
        FormMain.logger.WriteLine($"ConnectionManager.GetColumDataType | {columnName} TYP:  {columnType}");
        return columnType;
    }

    public void UpdateTable(DataTable updatedTable, string tableName)
    {
        // Benötigt einen PK in der Tabelle, sonst execption (: 
        try
        {
            OpenConnection();

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter($"SELECT * FROM {tableName}", connection))
            {
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);

                adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                adapter.InsertCommand = commandBuilder.GetInsertCommand();
                adapter.DeleteCommand = commandBuilder.GetDeleteCommand();


                adapter.Update(updatedTable);

                updatedTable.AcceptChanges();
                FormMain.logger.WriteLine($"ConnectionManager.UpdateTable | Tabellen Update Erfolgreich!");
            }
        }
        catch (Exception ex)
        {
            FormMain.logger.WriteLine($"ConnectionManager.UpdateTable | Fehler: {ex.Message}");
            throw new Exception($"Fehler beim Aktualisieren der Tabelle '{tableName}': {ex.Message}");
        }
        finally
        {
            CloseConnection();
        }
    }
}
