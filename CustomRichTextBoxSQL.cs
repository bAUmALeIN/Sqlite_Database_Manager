using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sqlite_Database_Manager
{
    public class CustomRichTextBoxSQL : RichTextBox
    {
        private readonly Color keywordColorData = Color.BlueViolet;
        private readonly Color keywordColor = Color.Blue;  // Farbe für SQL-Schlüsselwörter
        private readonly Color alternateLineColor = Color.LightGray; // Farbe für alternative Zeilen
        private readonly Color defaultTextColor = Color.Black; // Standardtextfarbe

        public CustomRichTextBoxSQL()
        {
            // Optionale Konfigurationen
            this.Dock = DockStyle.Fill;
            this.AcceptsTab = true;
            this.Font = new Font("Segeo UI", 10);
            this.Multiline = true;
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
            Font syntaxF = new Font("Segeo UI", 10);
            string[] keywords = new[] { "SELECT", "FROM", "WHERE", "INSERT", "UPDATE", "DELETE", "JOIN", "LEFT", "RIGHT", "INNER", "OUTER", "NULL", "COUNT", "´NOT", "CREATE TABLE", "TRUE", "FALSE", "NOT", };
            string[] keywordsData = new[] { "INTEGER", "REAL", "BLOB", "TEXT", "BOOL" };
            string text = this.Text;

            this.SelectAll();
            this.SelectionColor = defaultTextColor;

            foreach (string keyword in keywords)
            {
                int index = 0;
                while ((index = text.IndexOf(keyword, index, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    this.Select(index, keyword.Length);
                    this.SelectionColor = keywordColor;
                    this.SelectionFont = new Font(syntaxF, FontStyle.Bold);
                    index += keyword.Length;
                }
            }

            foreach (string keyword in keywordsData)
            {
                int index = 0;
                while ((index = text.IndexOf(keyword, index, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    this.Select(index, keyword.Length);
                    this.SelectionColor = keywordColorData;
                    this.SelectionFont = new Font(syntaxF, FontStyle.Bold);
                    index += keyword.Length;
                }
            }

            // Zurück zur Standardfarbe
            this.Select(this.TextLength, 0);
            this.SelectionColor = defaultTextColor;
            this.SelectionFont = new Font(this.Font, FontStyle.Regular);
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
