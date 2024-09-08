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

    }
}
