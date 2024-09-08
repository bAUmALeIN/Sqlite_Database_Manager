using System;
using System.Drawing;
using System.Windows.Forms;

// made by Chatgpt :D

namespace Sqlite_Database_Manager
{
    public class CustomRichTextBox : RichTextBox
    {
        private readonly Color keywordColor = Color.Blue;  // Farbe für SQL-Schlüsselwörter
        private readonly Color alternateLineColor = Color.LightGray; // Farbe für alternative Zeilen
        private readonly Color defaultTextColor = Color.Black; // Standardtextfarbe

        public CustomRichTextBox()
        {
            // Optionale Konfigurationen
            this.Dock = DockStyle.Fill;
            this.AcceptsTab = true;
            this.Font = new Font("Consolas", 10);
            this.Multiline = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ApplySyntaxHighlighting();
            ApplyAlternateRowColor();
        }

        private void ApplySyntaxHighlighting()
        {
            string[] keywords = new[] { "SELECT", "FROM", "WHERE", "INSERT", "UPDATE", "DELETE", "JOIN", "LEFT", "RIGHT", "INNER", "OUTER", "NULL","COUNT" };
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
                    index += keyword.Length;
                }
            }

            // Zurück zur Standardfarbe
            this.Select(this.TextLength, 0);
            this.SelectionColor = defaultTextColor;
        }

        private void ApplyAlternateRowColor()
        {
            // Entfernen der vorherigen Formatierungen
            this.SelectAll();
            this.SelectionBackColor = this.BackColor;

            // Alternierende Zeilenfarben anwenden
            int lineCount = this.Lines.Length;
            for (int i = 0; i < lineCount; i++)
            {
                if (i % 2 != 0) // Jede zweite Zeile
                {
                    int start = this.GetFirstCharIndexFromLine(i);
                    int length = this.Lines[i].Length;
                    if (start >= 0)
                    {
                        this.Select(start, length);
                        this.SelectionBackColor = alternateLineColor;
                    }
                }
            }

            // Zurück zur Standardfarbe
            this.Select(this.TextLength, 0);
            this.SelectionBackColor = this.BackColor;
        }
    }
}
