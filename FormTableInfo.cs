using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlite_Database_Manager
{
    public partial class FormTableInfo : Form
    {

        private string tableName = string.Empty;
        private Point mouseOffset;
        private bool isMouseDown = false;
        

        private Engine engine;

        public FormTableInfo(string tablename)
        {
            InitializeComponent();
            tableName = tablename;  
            engine = new Engine();
            GetTableInfo(tablename, dataGridViewColumInfo);
            customRichTextBoxTableInfo.Text = FormMain.connectionManager.GenerateCreateTableStatement(tablename);

        }
        

        private void FormTableInfo_Load(object sender, EventArgs e)
        {
           labelTableName.Text = tableName;
           pictureBoxInfo.Image = engine.scaleImage(20,20,Properties.Resources.Logo);

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

        public void GetTableInfo(string tableName, DataGridView dgv)
        {
            DataTable columnsTable = FormMain.connectionManager.GetTableColumns(tableName);

            DataTable tableInfo = new DataTable();
            tableInfo.Columns.Add("Name", typeof(string));
            tableInfo.Columns.Add("Type", typeof(string));
            tableInfo.Columns.Add("Not Null", typeof(bool));
            tableInfo.Columns.Add("Primary Key", typeof(bool));

            foreach (DataRow row in columnsTable.Rows)
            {
                string columnName = row["name"].ToString();
                string columnType = row["type"].ToString();
                bool isNotNull = row["notnull"].ToString() == "1";
                bool isPrimaryKey = row["pk"].ToString() == "1";

                tableInfo.Rows.Add(columnName, columnType, isNotNull, isPrimaryKey);
            }

            dgv.DataSource = tableInfo;

            List<DataGridViewColumn> columnsToReplace = new List<DataGridViewColumn>();

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.HeaderText == "Not Null" || column.HeaderText == "Primary Key")
                {
                    columnsToReplace.Add(column);
                }
            }

            foreach (var column in columnsToReplace)
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = column.HeaderText,
                    DataPropertyName = column.DataPropertyName,
                    TrueValue = true,
                    FalseValue = false
                };

                int columnIndex = dgv.Columns.IndexOf(column);
                dgv.Columns.Remove(column);
                dgv.Columns.Insert(columnIndex, checkBoxColumn);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
