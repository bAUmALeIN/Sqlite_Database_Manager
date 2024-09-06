using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlite_Database_Manager
{
    public static class Config
    {
        public const bool Showlogging = true;


        public static string ConnectionString = $"Data Source={dbPath};Version=3;";
        public static bool dbPathChanged = false;


        public static String dbPath = "";
        public static bool foundDB = false;



    }
}
