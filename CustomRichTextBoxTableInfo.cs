using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sqlite_Database_Manager
{
    public class CustomRichTextBoxTableInfo : RichTextBox
    {
        private readonly Color keywordColor = Color.Blue;  // Farbe für SQL-Schlüsselwörter
        private readonly Color alternateLineColor = Color.LightGray; // Farbe für alternative Zeilen
        private readonly Color defaultTextColor = Color.Black; // Standardtextfarbe
        private bool isUpdating = false; // Flag, um Schleifen zu verhindern

        public CustomRichTextBoxTableInfo()
        {
            this.AcceptsTab = true;
            this.Font = new Font("Segoe UI", 10);
            this.Multiline = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!isUpdating) // Verhindert Endlosschleifen beim Text-Update
            {
                isUpdating = true;
                ApplySyntaxHighlighting();
                ApplyAlternateRowColor();
                isUpdating = false;
            }

            base.OnTextChanged(e);
        }

        private void ApplySyntaxHighlighting()
        {
            // Liste der SQL-Schlüsselwörter
            string[] keywords = new[] { "SELECT", "FROM", "WHERE", "INSERT", "UPDATE", "DELETE", "JOIN", "LEFT", "RIGHT", "INNER", "OUTER", "NULL", "COUNT" };

            int originalSelectionStart = this.SelectionStart;
            int originalSelectionLength = this.SelectionLength;

            // Temporäre Deaktivierung von Textänderungen zur Vermeidung von Flackern
            this.SuspendLayout();

            // Textfarbe auf Standardfarbe setzen
            this.SelectAll();
            this.SelectionColor = defaultTextColor;

            // Durchsuche den Text nach Schlüsselwörtern
            foreach (string keyword in keywords)
            {
                int start = 0;
                while ((start = this.Text.IndexOf(keyword, start, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    // Nur ganze Wörter hervorheben
                    if ((start == 0 || !char.IsLetterOrDigit(this.Text[start - 1])) &&
                        (start + keyword.Length == this.Text.Length || !char.IsLetterOrDigit(this.Text[start + keyword.Length])))
                    {
                        this.Select(start, keyword.Length);
                        this.SelectionColor = keywordColor;
                    }
                    start += keyword.Length;
                }
            }

            // Ursprüngliche Auswahl wiederherstellen
            this.Select(originalSelectionStart, originalSelectionLength);
            this.SelectionColor = defaultTextColor;

            this.ResumeLayout(); // Layout-Wiederaufnahme
        }

        private void ApplyAlternateRowColor()
        {
            int originalSelectionStart = this.SelectionStart;
            int originalSelectionLength = this.SelectionLength;

            // Temporäre Deaktivierung von Textänderungen zur Vermeidung von Flackern
            this.SuspendLayout();

            // Markiere jede zweite Zeile mit der alternierenden Farbe
            for (int i = 0; i < this.Lines.Length; i++)
            {
                int lineStartIndex = this.GetFirstCharIndexFromLine(i);
                int lineLength = this.Lines[i].Length;

                if (lineLength > 0) // Nur nicht-leere Zeilen einfärben
                {
                    if (i % 2 != 0) // Jede zweite Zeile färben
                    {
                        this.Select(lineStartIndex, lineLength);
                        this.SelectionBackColor = alternateLineColor;
                    }
                    else
                    {
                        this.Select(lineStartIndex, lineLength);
                        this.SelectionBackColor = this.BackColor; // Standard-Hintergrundfarbe für ungerade Zeilen
                    }
                }
            }

            // Ursprüngliche Auswahl wiederherstellen
            this.Select(originalSelectionStart, originalSelectionLength);

            this.ResumeLayout(); // Layout-Wiederaufnahme
        }
    }
}
