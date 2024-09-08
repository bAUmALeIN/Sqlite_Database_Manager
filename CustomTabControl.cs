using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


// Made by CHAT GPT :D 



namespace Sqlite_Database_Manager
{
    public class CustomTabControl : TabControl
    {
        private const int ButtonWidth = 12; // Breite des Schließknopfs
        private const int ButtonHeight = 12; // Höhe des Schließknopfs
        private const int ButtonPadding = 4; // Abstand des Schließknopfs vom Tab-Rand
        private const int TabMargin = 10; // Abstand der Tabs

        public CustomTabControl()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Padding = new Point(TabMargin, 0); // Abstand der Tabs von der Control-Rand
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            // Tab-Seiten zeichnen
            Rectangle tabBounds = GetTabRect(e.Index);
            using (Graphics g = e.Graphics)
            {
                // Tab-Hintergrund
                using (Brush backgroundBrush = new LinearGradientBrush(tabBounds, Color.White, Color.LightGray, LinearGradientMode.Vertical))
                {
                    g.FillRectangle(backgroundBrush, tabBounds);
                }

                // Tab-Text
                TextRenderer.DrawText(g, TabPages[e.Index].Text, Font, tabBounds, ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                // Schließknopf zeichnen
                DrawCloseButton(g, tabBounds);
            }
        }

        private void DrawCloseButton(Graphics g, Rectangle tabBounds)
        {
            Rectangle closeButtonBounds = new Rectangle(tabBounds.Right - ButtonWidth - ButtonPadding, tabBounds.Top + ButtonPadding, ButtonWidth, ButtonHeight);

            // Button Hintergrund
            using (Brush buttonBrush = new SolidBrush(Color.FromArgb(240, 240, 240)))
            {
                g.FillRectangle(buttonBrush, closeButtonBounds);
            }

            // Button Rahmen
            using (Pen pen = new Pen(Color.FromArgb(200, 200, 200)))
            {
                g.DrawRectangle(pen, closeButtonBounds);
            }

            // "X" Zeichnen
            using (Pen pen = new Pen(Color.FromArgb(150, 150, 150), 2))
            {
                g.DrawLine(pen, closeButtonBounds.Left + 3, closeButtonBounds.Top + 3, closeButtonBounds.Right - 3, closeButtonBounds.Bottom - 3);
                g.DrawLine(pen, closeButtonBounds.Left + 3, closeButtonBounds.Bottom - 3, closeButtonBounds.Right - 3, closeButtonBounds.Top + 3);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Überprüfen, ob der Schließknopf angeklickt wurde
            for (int i = 0; i < TabPages.Count; i++)
            {
                Rectangle tabBounds = GetTabRect(i);
                Rectangle closeButtonBounds = new Rectangle(tabBounds.Right - ButtonWidth - ButtonPadding, tabBounds.Top + ButtonPadding, ButtonWidth, ButtonHeight);
                if (closeButtonBounds.Contains(e.Location))
                {
                    // Tab schließen
                    TabPages.RemoveAt(i);
                    
                    break;
                }
            }
        }
    }
}
