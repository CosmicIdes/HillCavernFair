using Microsoft.Data.Sqlite;
using Spectre.Console;

namespace HillCavernFair
{
    public class Connection
	{
        public static SqliteConnection CreateConnection()
        {

            SqliteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SqliteConnection("Data Source=Story.db;");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                AnsiConsole.Markup("[red]SQLite Connection didn't work! Please restart the app![/]");
            }
            return sqlite_conn;
        }
    }
}

