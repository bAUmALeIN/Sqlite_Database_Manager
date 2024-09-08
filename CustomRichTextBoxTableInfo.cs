using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sqlite_Database_Manager
{
    public class CustomRichTextBoxTableInfo : RichTextBox
    {
        private readonly Color keywordColorData = Color.BlueViolet;
        private readonly Color keywordColor = Color.Blue;  // Farbe für SQL-Schlüsselwörter
        private readonly Color alternateLineColor = Color.LightGray; // Farbe für alternative Zeilen
        private readonly Color defaultTextColor = Color.Black; // Standardtextfarbe
        private bool isUpdating = false; // Flag, um Schleifen zu verhindern

        public CustomRichTextBoxTableInfo()
        {
            this.AcceptsTab = true;
            this.Font = new Font("Consolas", 8);
            this.Multiline = true;
            ApplySyntaxHighlighting();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ApplySyntaxHighlighting();
            Invalidate(); // Veranlasst das Steuerelement, sich neu zu zeichnen
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ApplyAlternateRowColor(e.Graphics);
        }

        private void ApplySyntaxHighlighting()
        {
            Font syntaxF = new Font("Segeo UI", 8);
            string[] keywords = new[]
            {
            "SELECT", "FROM", "WHERE", "INSERT", "UPDATE", "DELETE", "JOIN", "LEFT", "RIGHT",
            "INNER", "OUTER", "FULL", "CROSS", "ON", "NULL", "NOT", "AND", "OR", "LIKE",
            "IN", "EXISTS", "BETWEEN", "AS", "DISTINCT", "GROUP BY", "ORDER BY", "HAVING",
            "UNION", "ALL", "ANY", "LIMIT", "OFFSET", "CASE", "WHEN", "THEN", "ELSE", "END",
            "IS", "NULLIF", "COALESCE", "CREATE TABLE", "DROP TABLE", "ALTER TABLE", "TRUNCATE",
            "PRIMARY KEY", "FOREIGN KEY", "REFERENCES", "DEFAULT", "AUTO_INCREMENT", "CHECK",
            "VIEW", "INDEX", "TRIGGER", "PROCEDURE", "FUNCTION", "CURSOR", "DECLARE",
            "BEGIN", "END", "COMMIT", "ROLLBACK", "SAVEPOINT", "TRANSACTION", "SET", "SHOW",
            "GRANT", "REVOKE", "DESCRIBE", "EXPLAIN", "USE", "DATABASE", "SCHEMA", "TRUE", "FALSE"
             };

            string[] keywordsData = new[]
            {
            "INTEGER", "REAL", "BLOB", "TEXT", "BOOLEAN", "VARCHAR", "CHAR", "DECIMAL",
            "NUMERIC", "FLOAT", "DOUBLE", "DATE", "TIME", "TIMESTAMP", "DATETIME", "TINYINT",
            "SMALLINT", "BIGINT", "MEDIUMINT", "SERIAL", "BIT", "ENUM", "SET", "YEAR"
              };

            string text = this.Text;


            this.SelectAll();
            this.SelectionColor = defaultTextColor;

            foreach (string keyword in keywords)
            {
                HighlightWord(text, keyword, keywordColor, syntaxF);
            }

  
            foreach (string keyword in keywordsData)
            {
                HighlightWord(text, keyword, keywordColorData, syntaxF);
            }

            // Zurück zur Standardfarbe
            this.Select(this.TextLength, 0);
            this.SelectionColor = defaultTextColor;
        }


        private void HighlightWord(string text, string keyword, Color color, Font font)
        {
            string pattern = $@"\b{Regex.Escape(keyword)}\b"; // \b steht für Wortgrenzen
            foreach (Match match in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
            {
                this.Select(match.Index, match.Length);
                this.SelectionColor = color;
                this.SelectionFont = new Font(font, FontStyle.Bold);
            }
        }

        private void ApplyAlternateRowColor(Graphics graphics)
        {
            int lineCount = this.Lines.Length;
            int lineHeight = this.Font.Height;

            // Hintergrundfarbe für jede Zeile zeichnen
            for (int i = 0; i < lineCount; i++)
            {
                if (i % 2 != 0) // Jede zweite Zeile
                {
                    int start = this.GetPositionFromCharIndex(this.GetFirstCharIndexFromLine(i)).Y;
                    int end = start + lineHeight;
                    using (Brush brush = new SolidBrush(alternateLineColor))
                    {
                        graphics.FillRectangle(brush, 0, start, this.ClientSize.Width, lineHeight);
                    }
                }
            }
        }

       

    }
}
