namespace Sqlite_Database_Manager
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControlBar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.labelTextDataType = new System.Windows.Forms.Label();
            this.labelDataType = new System.Windows.Forms.Label();
            this.labelInhalt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewDB = new System.Windows.Forms.TreeView();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxTables = new System.Windows.Forms.ComboBox();
            this.dataGridViewEditTable = new System.Windows.Forms.DataGridView();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TabControlSQL = new Sqlite_Database_Manager.CustomTabControl();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSaveSQL = new System.Windows.Forms.Button();
            this.btnOpenSQL = new System.Windows.Forms.Button();
            this.btnRunSQL = new System.Windows.Forms.Button();
            this.dataGridViewSQLquery = new System.Windows.Forms.DataGridView();
            this.richTextBoxAusgabeQuery = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelControlBar.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditTable)).BeginInit();
            this.tabPageSQL.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQLquery)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlBar
            // 
            this.panelControlBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelControlBar.Controls.Add(this.btnSettings);
            this.panelControlBar.Controls.Add(this.btnRefresh);
            this.panelControlBar.Location = new System.Drawing.Point(12, 30);
            this.panelControlBar.Name = "panelControlBar";
            this.panelControlBar.Size = new System.Drawing.Size(95, 30);
            this.panelControlBar.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(57, 22);
            this.btnSettings.TabIndex = 35;
            this.btnSettings.Text = "Einst.";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(65, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(27, 22);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btnMini);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1007, 25);
            this.panel4.TabIndex = 3;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(30, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "SQlite Datenbank Manager ";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = global::Sqlite_Database_Manager.Properties.Resources.icons8_minimize_window_152;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMini.Location = new System.Drawing.Point(961, 2);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(20, 20);
            this.btnMini.TabIndex = 6;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Sqlite_Database_Manager.Properties.Resources.icons8_close_15_trans;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(982, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl
            // 
            this.tabControl.BackColor = global::Sqlite_Database_Manager.Properties.Settings.Default.SILVER;
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageEdit);
            this.tabControl.Controls.Add(this.tabPageSQL);
            this.tabControl.Location = new System.Drawing.Point(12, 66);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(981, 473);
            this.tabControl.TabIndex = 4;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPageMain.Controls.Add(this.labelTextDataType);
            this.tabPageMain.Controls.Add(this.labelDataType);
            this.tabPageMain.Controls.Add(this.labelInhalt);
            this.tabPageMain.Controls.Add(this.label1);
            this.tabPageMain.Controls.Add(this.dataGridView1);
            this.tabPageMain.Controls.Add(this.panel1);
            this.tabPageMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(973, 447);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Datenbank Struktur";
            // 
            // labelTextDataType
            // 
            this.labelTextDataType.AutoSize = true;
            this.labelTextDataType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextDataType.ForeColor = System.Drawing.Color.Black;
            this.labelTextDataType.Location = new System.Drawing.Point(759, 9);
            this.labelTextDataType.Name = "labelTextDataType";
            this.labelTextDataType.Size = new System.Drawing.Size(99, 25);
            this.labelTextDataType.TabIndex = 10;
            this.labelTextDataType.Text = "Datentyp:";
            this.labelTextDataType.Visible = false;
            // 
            // labelDataType
            // 
            this.labelDataType.AutoSize = true;
            this.labelDataType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataType.ForeColor = System.Drawing.Color.Black;
            this.labelDataType.Location = new System.Drawing.Point(864, 9);
            this.labelDataType.Name = "labelDataType";
            this.labelDataType.Size = new System.Drawing.Size(20, 25);
            this.labelDataType.TabIndex = 9;
            this.labelDataType.Text = "/";
            this.labelDataType.Visible = false;
            // 
            // labelInhalt
            // 
            this.labelInhalt.AutoSize = true;
            this.labelInhalt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInhalt.ForeColor = System.Drawing.Color.Black;
            this.labelInhalt.Location = new System.Drawing.Point(520, 3);
            this.labelInhalt.Name = "labelInhalt";
            this.labelInhalt.Size = new System.Drawing.Size(87, 32);
            this.labelInhalt.TabIndex = 8;
            this.labelInhalt.Text = "Inhalt:";
            this.labelInhalt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabellen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(179, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(788, 403);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.treeViewDB);
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 403);
            this.panel1.TabIndex = 6;
            // 
            // treeViewDB
            // 
            this.treeViewDB.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewDB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewDB.Location = new System.Drawing.Point(4, 3);
            this.treeViewDB.Name = "treeViewDB";
            this.treeViewDB.Size = new System.Drawing.Size(150, 397);
            this.treeViewDB.TabIndex = 0;
            this.treeViewDB.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewDB_AfterSelect);
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPageEdit.Controls.Add(this.btnCancel);
            this.tabPageEdit.Controls.Add(this.btnSaveTable);
            this.tabPageEdit.Controls.Add(this.label3);
            this.tabPageEdit.Controls.Add(this.ComboBoxTables);
            this.tabPageEdit.Controls.Add(this.dataGridViewEditTable);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 22);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(973, 447);
            this.tabPageEdit.TabIndex = 1;
            this.tabPageEdit.Text = "Datem bearbeiten";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Brown;
            this.btnCancel.Location = new System.Drawing.Point(879, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 27);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Verwerfen";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTable.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTable.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSaveTable.Location = new System.Drawing.Point(788, 414);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(85, 27);
            this.btnSaveTable.TabIndex = 39;
            this.btnSaveTable.Text = "Speichern";
            this.btnSaveTable.UseVisualStyleBackColor = false;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tabelle:";
            // 
            // ComboBoxTables
            // 
            this.ComboBoxTables.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTables.FormattingEnabled = true;
            this.ComboBoxTables.Location = new System.Drawing.Point(113, 11);
            this.ComboBoxTables.Name = "ComboBoxTables";
            this.ComboBoxTables.Size = new System.Drawing.Size(121, 25);
            this.ComboBoxTables.TabIndex = 9;
            this.ComboBoxTables.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTables_SelectedIndexChanged);
            // 
            // dataGridViewEditTable
            // 
            this.dataGridViewEditTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEditTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewEditTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEditTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEditTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditTable.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewEditTable.Name = "dataGridViewEditTable";
            this.dataGridViewEditTable.RowHeadersVisible = false;
            this.dataGridViewEditTable.Size = new System.Drawing.Size(961, 366);
            this.dataGridViewEditTable.TabIndex = 8;
            this.dataGridViewEditTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewEditTable_DataError);
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.panel2);
            this.tabPageSQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Size = new System.Drawing.Size(973, 447);
            this.tabPageSQL.TabIndex = 2;
            this.tabPageSQL.Text = "SQL abfrage";
            this.tabPageSQL.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TabControlSQL);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnSaveSQL);
            this.panel2.Controls.Add(this.btnOpenSQL);
            this.panel2.Controls.Add(this.btnRunSQL);
            this.panel2.Controls.Add(this.dataGridViewSQLquery);
            this.panel2.Controls.Add(this.richTextBoxAusgabeQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 447);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(366, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Datenbank-Abfrage";
            // 
            // TabControlSQL
            // 
            this.TabControlSQL.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControlSQL.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControlSQL.Location = new System.Drawing.Point(4, 36);
            this.TabControlSQL.Name = "TabControlSQL";
            this.TabControlSQL.Padding = new System.Drawing.Point(10, 0);
            this.TabControlSQL.SelectedIndex = 0;
            this.TabControlSQL.Size = new System.Drawing.Size(964, 178);
            this.TabControlSQL.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Image = global::Sqlite_Database_Manager.Properties.Resources.icons8_new_tab_20;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(784, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Neue Abfrage";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSaveSQL
            // 
            this.btnSaveSQL.Image = global::Sqlite_Database_Manager.Properties.Resources.icons8_speichern_20;
            this.btnSaveSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSQL.Location = new System.Drawing.Point(38, 7);
            this.btnSaveSQL.Name = "btnSaveSQL";
            this.btnSaveSQL.Size = new System.Drawing.Size(28, 23);
            this.btnSaveSQL.TabIndex = 5;
            this.btnSaveSQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSQL.UseVisualStyleBackColor = true;
            this.btnSaveSQL.Click += new System.EventHandler(this.btnSaveSQL_Click);
            // 
            // btnOpenSQL
            // 
            this.btnOpenSQL.Image = global::Sqlite_Database_Manager.Properties.Resources.icons8_ordner_öffnen_20;
            this.btnOpenSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenSQL.Location = new System.Drawing.Point(4, 7);
            this.btnOpenSQL.Name = "btnOpenSQL";
            this.btnOpenSQL.Size = new System.Drawing.Size(28, 23);
            this.btnOpenSQL.TabIndex = 4;
            this.btnOpenSQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenSQL.UseVisualStyleBackColor = true;
            this.btnOpenSQL.Click += new System.EventHandler(this.btnOpenSQL_Click);
            // 
            // btnRunSQL
            // 
            this.btnRunSQL.Image = global::Sqlite_Database_Manager.Properties.Resources.icons8_spielen_20;
            this.btnRunSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunSQL.Location = new System.Drawing.Point(913, 7);
            this.btnRunSQL.Name = "btnRunSQL";
            this.btnRunSQL.Size = new System.Drawing.Size(55, 23);
            this.btnRunSQL.TabIndex = 3;
            this.btnRunSQL.Text = "Run";
            this.btnRunSQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunSQL.UseVisualStyleBackColor = true;
            this.btnRunSQL.Click += new System.EventHandler(this.btnRunSQL_Click);
            // 
            // dataGridViewSQLquery
            // 
            this.dataGridViewSQLquery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSQLquery.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSQLquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSQLquery.Location = new System.Drawing.Point(4, 220);
            this.dataGridViewSQLquery.Name = "dataGridViewSQLquery";
            this.dataGridViewSQLquery.RowHeadersVisible = false;
            this.dataGridViewSQLquery.Size = new System.Drawing.Size(964, 143);
            this.dataGridViewSQLquery.TabIndex = 2;
            // 
            // richTextBoxAusgabeQuery
            // 
            this.richTextBoxAusgabeQuery.Location = new System.Drawing.Point(4, 369);
            this.richTextBoxAusgabeQuery.Name = "richTextBoxAusgabeQuery";
            this.richTextBoxAusgabeQuery.Size = new System.Drawing.Size(967, 61);
            this.richTextBoxAusgabeQuery.TabIndex = 1;
            this.richTextBoxAusgabeQuery.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1005, 551);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelControlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.panelControlBar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditTable)).EndInit();
            this.tabPageSQL.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQLquery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewDB;
        private System.Windows.Forms.TabPage tabPageSQL;
        internal System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelInhalt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxTables;
        private System.Windows.Forms.DataGridView dataGridViewEditTable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRunSQL;
        private System.Windows.Forms.DataGridView dataGridViewSQLquery;
        private System.Windows.Forms.RichTextBox richTextBoxAusgabeQuery;
        private System.Windows.Forms.Button btnSaveSQL;
        private System.Windows.Forms.Button btnOpenSQL;
        private System.Windows.Forms.Label labelTextDataType;
        private System.Windows.Forms.Label labelDataType;
        private System.Windows.Forms.Button button3;
        private CustomTabControl TabControlSQL;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
    }
}

