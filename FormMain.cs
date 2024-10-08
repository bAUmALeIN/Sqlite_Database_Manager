﻿using System;
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


// SQLite DB Broweser Version 2


namespace Sqlite_Database_Manager
{
    public partial class FormMain : Form
    {
        public static Logger logger;
        public static ConnectionManager connectionManager;
        public static bool loadDefault = false;
        private Engine engine;


        private Point mouseOffset;
        private bool isMouseDown = false;


        private DataTable lastEditTable;

        



        public FormMain()
        {
            InitializeComponent();
            logger = new Logger();
            engine = new Engine();

            if (Config.Showlogging)
            {
                logger.Show();
            }

            if (Properties.Settings.Default.DBCONNECTIONSTRING.Length > 1) {
                logger.WriteLine($"MainLoad | ConnectionString gefunden: {Properties.Settings.Default.DBCONNECTIONSTRING}");
                DialogResult resultUseSavedCon = MessageBox.Show("Soll die hinterlegte Verbindung geladen werden ?", "Verbindung gefunden", MessageBoxButtons.OKCancel);
                if (resultUseSavedCon == DialogResult.OK)
                {
                    Config.ConnectionString = Properties.Settings.Default.DBCONNECTIONSTRING;
                    loadDefault = true;
                }
                else
                {
                    Properties.Settings.Default.DBCONNECTIONSTRING = "";
                    Properties.Settings.Default.DBPATH = "";
                    Properties.Settings.Default.Save();
                }

            }


            if (checkDBexists() == true) {
                Config.foundDB = true;
                connectionManager = new ConnectionManager(Config.ConnectionString);
                LoadDatabaseStructure();
                this.StartPosition = FormStartPosition.CenterScreen;
                return;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
            logger.WriteLine($"FormMain | Keine Datenbank Daten hinterlegt");

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
                logger.WriteLine($"FormMain.Refresh | Keine Datenbank Daten hinterlegt");
            }
        }


        private bool checkDBexists()
        {

            if (File.Exists(Config.dbPath) || File.Exists(Properties.Settings.Default.DBPATH) && loadDefault == true)
            {
                logger.WriteLine($"checkDBexists | Config : DB gefunden unter: {Config.dbPath} || Properties : {Properties.Settings.Default.DBPATH}");
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
                ComboBoxTables.Items.Clear();

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
                        ComboBoxTables.Items.Add(tableName);

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
                labelDataType.Visible = false;
                labelTextDataType.Visible = false;
                labelInfoTextTable.Visible = true;
            }
            else // UnterNode -> Spalte
            {
                
                var tableName = e.Node.Parent.Text;
                var columnName = e.Node.Text;
                DataTable columnData = connectionManager.GetColumnData(tableName, columnName);
                dataGridView1.DataSource = columnData;
                labelDataType.Text = connectionManager.GetColumnDataType(tableName, columnName);
                labelDataType.Visible = true;
                labelTextDataType.Visible = true;
                labelInfoTextTable.Visible = false;
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

        private void ComboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            String selectedValue = ComboBoxTables.SelectedItem.ToString();
            DataTable dt = connectionManager.GetTableData(selectedValue);
            dataGridViewEditTable.DataSource = dt;


        }

        private void useless()
        {

        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridViewEditTable.DataSource;
            string tablename = ComboBoxTables.SelectedItem.ToString();

            connectionManager.UpdateTable(dt,tablename);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string tablename = ComboBoxTables.SelectedItem.ToString();
            DataTable dt = connectionManager.GetTableData(tablename);
            dataGridViewEditTable.DataSource = dt;
            logger.WriteLine("Main | Verwerfe änderungen");
        }

        private void dataGridViewEditTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            logger.WriteLine($"Fehler im DGV {e.Exception.Message}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addNewTabePage();


        }

        private void btnRunSQL_Click(object sender, EventArgs e)
        {
            richTextBoxAusgabeQuery.Text = "";
            richTextBoxAusgabeQuery.BackColor = Color.White;
            String query = "";
            int rows = 0;
            TabPage selectedTab = TabControlSQL.SelectedTab;
            foreach (TabPage tabPage in TabControlSQL.TabPages) { 
            
                if (tabPage == selectedTab)
                {
                    foreach (Control control in tabPage.Controls) {
                        if (control is CustomRichTextBoxSQL) { 
                        query = control.Text;
                        }
                    }

                }

            }

            if (query != "")
            {
                if (connectionManager != null) {
                    DataTable dt = connectionManager.ExecuteQuery(query);
                    logger.WriteLine($"Main | SQL Query: {query}");
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            rows++;
                        }
                        dataGridViewSQLquery.DataSource = dt;
                        if (rows > 0) {
                            richTextBoxAusgabeQuery.Text = $" Abfrage erfolgreich ausgeführt. {rows.ToString()} Zeilen(n) betroffen";
                            richTextBoxAusgabeQuery.ForeColor = Color.White;
                            richTextBoxAusgabeQuery.BackColor = Color.SeaGreen ;
                        }
                        else
                        {
                            richTextBoxAusgabeQuery.Text = $"Abfrage hat 0 Zeilen betroffen";
                        }
                        
                    }
                    else
                    {

                        richTextBoxAusgabeQuery.Text = $"Die Abfrage hat einen Fehler verursacht:" + Environment.NewLine;
                        richTextBoxAusgabeQuery.AppendText(Config.lasQueryFailText);
                        richTextBoxAusgabeQuery.ForeColor = Color.White;
                        richTextBoxAusgabeQuery.BackColor = Color.IndianRed;
                        dataGridViewSQLquery.DataSource = null;
                        dataGridViewSQLquery.Refresh();
                    }
                }
                else {
                    logger.WriteLine($"Main | Keine Verbindung hinterlegt: {query}");
                }
                



            }
        }

        private void btnSaveSQL_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = TabControlSQL.SelectedTab;

                foreach (TabPage tab in TabControlSQL.TabPages)
                {

                    if (tab == selectedTab)
                    {
                        foreach (Control control in tab.Controls)
                        {
                            if (control is CustomRichTextBoxSQL)
                            {
                                SaveFileDialog sfd = new SaveFileDialog();
                                sfd.Filter = "Text|*.txt|All|*.*";
                                if (sfd.ShowDialog() == DialogResult.OK)
                                {
                                    
                                    System.IO.File.WriteAllText(sfd.FileName, control.Text);
                                }

                            }
                        }


                    }
                }
            


        }

        private void btnOpenSQL_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = TabControlSQL.SelectedTab;
            if (TabControlSQL.TabCount > 0) {
                foreach (TabPage tab in TabControlSQL.TabPages)
                {

                    if (tab == selectedTab)
                    {
                        foreach (Control control in tab.Controls)
                        {
                            if (control is CustomRichTextBoxSQL)
                            {
                                OpenFileDialog ofd = new OpenFileDialog();
                                ofd.Filter = "Text|*.txt|All|*.*";
                                if (ofd.ShowDialog() == DialogResult.OK)
                                {
                                    string file = ofd.FileName;
                                    if (File.Exists(file))
                                    {
                                        using (StreamReader sr = new StreamReader(file))
                                        {
                                            control.Text = sr.ReadToEnd();
                                        }
                                    }
                                }

                            }
                        }


                    }
                }
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text|*.txt|All|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TabPage tp = addNewTabePage();
                    foreach (Control control in tp.Controls)
                    {
                        if (control is CustomRichTextBoxSQL)
                        {

                            string file = ofd.FileName;
                            if (File.Exists(file))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    control.Text = sr.ReadToEnd();
                                }
                            }


                        }
                    }
                }
            }
           
           


        }
        private TabPage addNewTabePage()
        {
            int nextTabNumber = 1; 
            foreach (TabPage tabPage in TabControlSQL.TabPages)
            {
                if (tabPage.Text.StartsWith("SQL") && int.TryParse(tabPage.Text.Substring(3), out int tabNumber))
                {
                    if (tabNumber >= nextTabNumber)
                    {
                        nextTabNumber = tabNumber + 1;
                    }
                }
            }

            TabPage newTabPage = new TabPage($"SQL{nextTabNumber}");
            RichTextBox rtf = new CustomRichTextBoxSQL();
            rtf.Dock = DockStyle.Fill;
            rtf.Name = $"rtfSQLquery{nextTabNumber.ToString()}";
            newTabPage.Controls.Add(rtf);
            TabControlSQL.TabPages.Add(newTabPage);
            return newTabPage;
        }

        private void treeViewDB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //wip
            logger.WriteLine("treeViewDB.MouseDoubleClick event ausgelöst");
            TreeNode node = treeViewDB.GetNodeAt(e.X, e.Y);
            logger.WriteLine($"treeViewDB.MouseDoubleClick event |{e.X.ToString()} {e.Y.ToString()}");
            if (node.Parent== null) {
                    String tablename = node.Text;
                    FormTableInfo tableInfo = new FormTableInfo(tablename);
                    if (engine.checkIfFormIsOpen(tableInfo) == false)
                    {
                        tableInfo.ShowDialog();

                    }
                    

                }



        }

        private void TabControlSQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxAusgabeQuery.Text = "";
            richTextBoxAusgabeQuery.BackColor = SystemColors.Control;
            richTextBoxAusgabeQuery.ForeColor = Color.Black;
            dataGridViewSQLquery.DataSource = null;
            dataGridViewSQLquery.Refresh();
        }
    }
}

