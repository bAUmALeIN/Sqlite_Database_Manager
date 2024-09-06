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
            this.panelControlBar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelInhalt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewDB = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelControlBar.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControlBar
            // 
            this.panelControlBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelControlBar.Controls.Add(this.btnSettings);
            this.panelControlBar.Controls.Add(this.btnRefresh);
            this.panelControlBar.Location = new System.Drawing.Point(-2, 25);
            this.panelControlBar.Name = "panelControlBar";
            this.panelControlBar.Size = new System.Drawing.Size(1007, 35);
            this.panelControlBar.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(938, 7);
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
            this.btnRefresh.Location = new System.Drawing.Point(817, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 22);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Aktualisieren";
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
            this.btnMini.Location = new System.Drawing.Point(970, 2);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(17, 17);
            this.btnMini.TabIndex = 6;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Sqlite_Database_Manager.Properties.Resources.icons8_close_15_trans;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(987, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 17);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl
            // 
            this.tabControl.BackColor = global::Sqlite_Database_Manager.Properties.Settings.Default.SILVER;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 97);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(981, 442);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage1.Controls.Add(this.labelInhalt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datenbank Struktur";
            // 
            // labelInhalt
            // 
            this.labelInhalt.AutoSize = true;
            this.labelInhalt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInhalt.ForeColor = System.Drawing.Color.Black;
            this.labelInhalt.Location = new System.Drawing.Point(530, 23);
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
            this.label1.Location = new System.Drawing.Point(25, 23);
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
            this.dataGridView1.Location = new System.Drawing.Point(179, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(788, 352);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.treeViewDB);
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 352);
            this.panel1.TabIndex = 6;
            // 
            // treeViewDB
            // 
            this.treeViewDB.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewDB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewDB.Location = new System.Drawing.Point(4, 3);
            this.treeViewDB.Name = "treeViewDB";
            this.treeViewDB.Size = new System.Drawing.Size(150, 346);
            this.treeViewDB.TabIndex = 0;
            this.treeViewDB.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewDB_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bearbeiten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(973, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SQL";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewDB;
        private System.Windows.Forms.TabPage tabPage3;
        internal System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelInhalt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnSettings;
    }
}

