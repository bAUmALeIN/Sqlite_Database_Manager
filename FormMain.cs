using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sqlite_Database_Manager
{
    public partial class FormMain : Form
    {

        private ConnectionManager connectionManager;
        private Engine engine;
         public static Logger logger;



        private Point mouseOffset;
        private bool isMouseDown = false;




        public FormMain()
        {
            InitializeComponent();
            logger = new Logger();
            engine = new Engine();

            if (Config.logging)
            {
                logger.Show();
            }

            if (checkDBexists() == true) {
                connectionManager = new ConnectionManager(Config.ConnectionString);
                LoadDatabaseStructure();
                this.StartPosition = FormStartPosition.CenterScreen;
                Config.foundDB = true;
                return;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
            logger.WriteLine($"FormMain | Keine Datenbank Datei hinterlegt");

        }

        private void Refresh()
        {
            if (checkDBexists() == true)
            {
                logger.WriteLine($"FormMain.Refresh | Datenbank gefunden.");
                connectionManager = new ConnectionManager(Config.ConnectionString);
                LoadDatabaseStructure();
                Config.dbPathChanged = false;
                return;
            }
            else
            {
                logger.WriteLine($"FormMain.Refresh | Keine Datenbank Datei hinterlegt");
            }
        }


        private bool checkDBexists()
        {
            
            if (File.Exists(Config.dbPath))
            {
                logger.WriteLine($"checkDBexists | DB gefunden unter: {Config.dbPath}");
                return true;

            }
            else { return false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                

                btnRefresh.Image = engine.scaleImage(16, 16, Properties.Resources.icons8_refresh_30);
                pictureBox1.Image = engine.scaleImage(20, 20, Properties.Resources.Logo);
                btnSettings.Image = engine.scaleImage(18, 18, Properties.Resources.icons8_settings_20);


        }

        private void LoadDatabaseStructure()
        {

            if (Config.foundDB == true) {
                treeViewDB.Nodes.Clear();

                using (SQLiteConnection conn = new SQLiteConnection(Config.ConnectionString))
                {
                    conn.Open();
                    logger.WriteLine("LoadDatabaseStructure | Connection.Open OK");
                    DataTable tables = conn.GetSchema("Tables");

                    foreach (DataRow row in tables.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();

                        TreeNode tableNode = new TreeNode(tableName);
                        treeViewDB.Nodes.Add(tableNode);


                        string query = $"PRAGMA table_info({tableName})";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string columnName = reader["name"].ToString();
                                    TreeNode columnNode = new TreeNode(columnName);
                                    tableNode.Nodes.Add(columnNode);
                                }
                            }
                        }
                    }
                }

            }

        }

        private void TreeViewDB_AfterSelect(object sender, TreeViewEventArgs e)
        {
            labelInhalt.Visible = true;
            if (e.Node.Parent == null) // Hauptnode -> Tabelle
            {

                var tableName = e.Node.Text;
                DataTable tableData = connectionManager.GetTableData(tableName);
                dataGridView1.DataSource = tableData;
            }
            else // UnterNode -> Spalte
            {
  
                var tableName = e.Node.Parent.Text;
                var columnName = e.Node.Text;
                DataTable columnData = connectionManager.GetColumnData(tableName, columnName);
                dataGridView1.DataSource = columnData;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);                
                this.Location = mousePos;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDatabaseStructure();
            dataGridView1.DataSource = null;
            labelInhalt.Visible = false;    
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FormSettings)
                {
                   openForm.BringToFront();
                    return ;
                }
            }
            FormSettings settings = new FormSettings();
            settings.StartPosition = FormStartPosition.CenterScreen;
            settings.FormClosed += (s, args) => Refresh();
            settings.Show();


        }
    }
}
