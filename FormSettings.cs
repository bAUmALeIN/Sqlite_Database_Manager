using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlite_Database_Manager
{
    public partial class FormSettings : Form
    {
        SQLiteConnectionStringBuilder connectionStringBuilder;
        private Point mouseOffset;
        private bool isMouseDown = false;
        private Engine engine;

        public FormSettings()
        {
            InitializeComponent();
            engine = new Engine();
            connectionStringBuilder = new SQLiteConnectionStringBuilder();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = engine.scaleImage(20, 20, Properties.Resources.Logo);

            if (Properties.Settings.Default.DBPATH != null && FormMain.loadDefault)
            {
                tbDbPfad.Text = Properties.Settings.Default.DBPATH;

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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Database Files (*.db)|*.db|All Files (*.*)|*.*";

           DialogResult result =  ofd.ShowDialog();
            if (result == DialogResult.OK) {
                var filePath = ofd.FileName;
                tbDbPfad.Text = filePath;
               



            }
            else
            {
               return;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config.dbPath = tbDbPfad.Text;
            Config.dbPathChanged = true;
            Config.foundDB = true;

            connectionStringBuilder.DataSource = Config.dbPath;
            FormMain.logger.WriteLine($"Config.ConnectionString | {connectionStringBuilder.ConnectionString}");
            Config.ConnectionString = connectionStringBuilder.ConnectionString;

            // Abfragen ob DB im Programm gespeichert werden soll... wip 
            DialogResult resultSaveConnection = MessageBox.Show("Soll die Verbindung gespeichert werden ?","Speichern",MessageBoxButtons.OKCancel);
            if (resultSaveConnection == DialogResult.OK)
            {
                Properties.Settings.Default.DBPATH = Config.dbPath;
                Properties.Settings.Default.DBCONNECTIONSTRING = Config.ConnectionString;
                Properties.Settings.Default.Save();
                FormMain.logger.WriteLine($" SPEICHER VERBINDUNG | CONNECTIONSTRIN: {Properties.Settings.Default.DBCONNECTIONSTRING} | DBPATH: {Properties.Settings.Default.DBPATH}");
            }
            else
            {
                Properties.Settings.Default.DBPATH = "_";
                Properties.Settings.Default.DBCONNECTIONSTRING = "_";
                Properties.Settings.Default.Save();
            }

            this.Close();
        }



    }
}
