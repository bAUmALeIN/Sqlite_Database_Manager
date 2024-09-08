namespace Sqlite_Database_Manager
{
    partial class FormTableInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.dataGridViewColumInfo = new System.Windows.Forms.DataGridView();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTableName = new System.Windows.Forms.Label();
            this.columName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columNN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columPK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBoxInfo);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 25);
            this.panel4.TabIndex = 4;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(172, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "SQlite Datenbank Manager | Tabellen Information";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Location = new System.Drawing.Point(150, 1);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(21, 21);
            this.pictureBoxInfo.TabIndex = 7;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBoxInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBoxInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // dataGridViewColumInfo
            // 
            this.dataGridViewColumInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewColumInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewColumInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColumInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columName,
            this.columTyp,
            this.columNN,
            this.columPK});
            this.dataGridViewColumInfo.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewColumInfo.Name = "dataGridViewColumInfo";
            this.dataGridViewColumInfo.RowHeadersVisible = false;
            this.dataGridViewColumInfo.Size = new System.Drawing.Size(676, 150);
            this.dataGridViewColumInfo.TabIndex = 5;
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbort.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbort.ForeColor = System.Drawing.Color.Brown;
            this.btnAbort.Location = new System.Drawing.Point(607, 396);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(85, 27);
            this.btnAbort.TabIndex = 42;
            this.btnAbort.Text = "Abbrechen";
            this.btnAbort.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOk.Location = new System.Drawing.Point(516, 396);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 27);
            this.btnOk.TabIndex = 41;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ausgewähle Tabelle:";
            // 
            // labelTableName
            // 
            this.labelTableName.AutoSize = true;
            this.labelTableName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableName.ForeColor = System.Drawing.Color.Brown;
            this.labelTableName.Location = new System.Drawing.Point(198, 39);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(36, 25);
            this.labelTableName.TabIndex = 44;
            this.labelTableName.Text = "-/-";
            // 
            // columName
            // 
            this.columName.HeaderText = "Name";
            this.columName.Name = "columName";
            this.columName.ReadOnly = true;
            // 
            // columTyp
            // 
            this.columTyp.HeaderText = "Typ";
            this.columTyp.Name = "columTyp";
            this.columTyp.ReadOnly = true;
            // 
            // columNN
            // 
            this.columNN.HeaderText = "Not Null";
            this.columNN.Name = "columNN";
            this.columNN.ReadOnly = true;
            // 
            // columPK
            // 
            this.columPK.HeaderText = "Primary Key";
            this.columPK.Name = "columPK";
            this.columPK.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(87, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "CREATE Anweisung";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 288);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(331, 130);
            this.richTextBox1.TabIndex = 47;
            this.richTextBox1.Text = "";
            // 
            // FormTableInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dataGridViewColumInfo);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTableInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTableInfo";
            this.Load += new System.EventHandler(this.FormTableInfo_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.DataGridView dataGridViewColumInfo;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columTyp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columNN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columPK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}