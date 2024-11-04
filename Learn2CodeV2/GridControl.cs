using MSO_P2;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Learn2CodeV2
{
    public class GridControl : Control
    {
        private Grid grid;
        private int cellSize = 20;

        // Properties to control the grid's position
        public Point GridPosition
        {
            get => Location;
            set => Location = value;
        }

        public GridControl(Grid grid)
        {
            this.grid = grid;
            this.Size = new Size(grid.Width * cellSize, grid.Height * cellSize);

            // Make the control non-docked and moveable
            this.Dock = DockStyle.None;
            this.Location = new Point(0, 0); // Default position
        }

        // Method to set position programmatically
        public void SetPosition(int x, int y)
        {
            this.Location = new Point(x, y);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Draw the grid cells
            for (int x = 0; x < grid.Width; x++)
            {
                for (int y = 0; y < grid.Height; y++)
                {
                    Rectangle cellRect = new Rectangle(x * cellSize, y * cellSize, cellSize, cellSize);
                    if (grid.closedPosition.Contains(new Position(x, y)))
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 230, 230)), cellRect);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.LightGray, cellRect);
                    }
                    g.DrawRectangle(Pens.Black, cellRect);
                }
            }

            //Draw the visitedpositions line
            Pen pathPen = new Pen(Color.Yellow, 3);
            int lineoffset = cellSize / 2;
            for (int i = 1; i < grid.character.pathHistory.Count; i++) 
            {
                Position oldPosition = grid.character.pathHistory[i-1];
                Position newPosition = grid.character.pathHistory[i];
                g.DrawLine(pathPen, (oldPosition.x*cellSize)+lineoffset, -(oldPosition.y*cellSize-lineoffset), newPosition.x*cellSize+lineoffset, -(newPosition.y*cellSize-lineoffset));
            }

            // Draw the character
            Position charPos = grid.character.position;
            Rectangle charRect = new Rectangle(charPos.x * cellSize, charPos.y * cellSize, cellSize, cellSize);
            g.FillRectangle(Brushes.Green, charRect);

            // Draw the endpoint
            if (grid.Endpoint != null)
            {
                Position endPos = grid.Endpoint;
                Rectangle endRect = new Rectangle(endPos.x * cellSize, endPos.y * cellSize, cellSize, cellSize);
                g.FillRectangle(Brushes.Red, endRect);
            }
        }
    }
}