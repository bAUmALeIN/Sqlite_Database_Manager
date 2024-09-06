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
    public partial class Logger : Form
    {
        public Logger()
        {
            InitializeComponent();
        }

        private void Logger_Load(object sender, EventArgs e)
        {

        }

        public void WriteLine(String Message)
        {
            richTextBox1.AppendText(Message);
            richTextBox1.AppendText(Environment.NewLine);
        
        }

    }
}
