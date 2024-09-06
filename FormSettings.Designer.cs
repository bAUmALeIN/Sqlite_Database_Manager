namespace Sqlite_Database_Manager
{
    partial class FormSettings
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.labelInhalt = new System.Windows.Forms.Label();
            this.tbDbPfad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btnMini);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 25);
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
            this.label2.Location = new System.Drawing.Point(30, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Einstellungen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = global::Sqlite_Database_Manager.Properties.Resources.icons8_minimize_window_152;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMini.Location = new System.Drawing.Point(443, 3);
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
            this.btnClose.Location = new System.Drawing.Point(464, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 17);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbDbPfad);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.labelInhalt);
            this.panel1.Location = new System.Drawing.Point(6, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 267);
            this.panel1.TabIndex = 5;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = global::Sqlite_Database_Manager.Properties.Resources.icons8_add_file_20;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(352, 16);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(119, 23);
            this.btnSettings.TabIndex = 36;
            this.btnSettings.Text = "Datenbank öffnen";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // labelInhalt
            // 
            this.labelInhalt.AutoSize = true;
            this.labelInhalt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInhalt.ForeColor = System.Drawing.Color.Black;
            this.labelInhalt.Location = new System.Drawing.Point(6, 18);
            this.labelInhalt.Name = "labelInhalt";
            this.labelInhalt.Size = new System.Drawing.Size(137, 21);
            this.labelInhalt.TabIndex = 9;
            this.labelInhalt.Text = "Datenbank Pfad:";
            // 
            // tbDbPfad
            // 
            this.tbDbPfad.Location = new System.Drawing.Point(10, 42);
            this.tbDbPfad.Name = "tbDbPfad";
            this.tbDbPfad.Size = new System.Drawing.Size(461, 20);
            this.tbDbPfad.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(386, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 38;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(489, 302);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInhalt;
        internal System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TextBox tbDbPfad;
        private System.Windows.Forms.Button button1;
    }
}