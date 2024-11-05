using MSO_P2;
using System;
using System.Drawing;
using System.Security.Cryptography;
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
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Find the minimum and maximum x and y values in the path history
            int minX = int.MaxValue, minY = int.MaxValue, maxX = int.MinValue, maxY = int.MinValue;
            foreach (Position p in grid.character.pathHistory)
            {
                int x = p.x;
                int y = p.y;
                minX = Math.Min(x, minX);
                minY = Math.Min(y, minY);
                maxX = Math.Max(x, maxX);
                maxY = Math.Max(y, maxY);
            }

            // Calculate total height to flip Y coordinates
            int totalHeight = (maxY - minY + 1) * cellSize;

            // Draw the grid cells
            for (int x = minX; x <= maxX; x++)
            {
                for (int y = minY; y <= maxY; y++)
                {
                    // Flip Y coordinate by subtracting from total height
                    Rectangle cellRect = new Rectangle(
                        (x - minX) * cellSize,
                        totalHeight - ((y - minY + 1) * cellSize),
                        cellSize,
                        cellSize);

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

            // Draw the visited positions line
            Pen pathPen = new Pen(Color.Yellow, 3);
            int lineoffset = cellSize / 2;
            for (int i = 1; i < grid.character.pathHistory.Count; i++)
            {
                Position oldPosition = grid.character.pathHistory[i - 1];
                Position newPosition = grid.character.pathHistory[i];
                int oldX = (oldPosition.x - minX) * cellSize + lineoffset;
                int oldY = totalHeight - ((oldPosition.y - minY + 1) * cellSize) + lineoffset;
                int newX = (newPosition.x - minX) * cellSize + lineoffset;
                int newY = totalHeight - ((newPosition.y - minY + 1) * cellSize) + lineoffset;

                g.DrawLine(pathPen, oldX, oldY, newX, newY);
            }

            void DrawArrow(Graphics graphics, Rectangle bounds, Direction direction)
            {
                int centerX = bounds.X + bounds.Width / 2;
                int centerY = bounds.Y + bounds.Height / 2;
                int arrowSize = Math.Min(bounds.Width, bounds.Height) * 3 / 4;  // Arrow size is 75% of cell size

                Point[] arrowPoints;

                // Create points for the arrow based on direction
                switch (direction)
                {
                    case Direction.North:
                        arrowPoints = new Point[] {
                    new Point(centerX, centerY - arrowSize/2),           // tip
                    new Point(centerX - arrowSize/3, centerY + arrowSize/2),  // left bottom
                    new Point(centerX + arrowSize/3, centerY + arrowSize/2)   // right bottom
                };
                        break;
                    case Direction.South:
                        arrowPoints = new Point[] {
                    new Point(centerX, centerY + arrowSize/2),           // tip
                    new Point(centerX - arrowSize/3, centerY - arrowSize/2),  // left top
                    new Point(centerX + arrowSize/3, centerY - arrowSize/2)   // right top
                };
                        break;
                    case Direction.East:
                        arrowPoints = new Point[] {
                    new Point(centerX + arrowSize/2, centerY),           // tip
                    new Point(centerX - arrowSize/2, centerY - arrowSize/3),  // left top
                    new Point(centerX - arrowSize/2, centerY + arrowSize/3)   // left bottom
                };
                        break;
                    case Direction.West:
                        arrowPoints = new Point[] {
                    new Point(centerX - arrowSize/2, centerY),           // tip
                    new Point(centerX + arrowSize/2, centerY - arrowSize/3),  // right top
                    new Point(centerX + arrowSize/2, centerY + arrowSize/3)   // right bottom
                };
                        break;
                    default:
                        arrowPoints = new Point[] { };
                        break;
                }

                // Draw the arrow
                using (SolidBrush brush = new SolidBrush(Color.Green))
                {
                    graphics.FillPolygon(brush, arrowPoints);
                }
                using (Pen pen = new Pen(Color.DarkGreen, 1))
                {
                    graphics.DrawPolygon(pen, arrowPoints);
                }
            }

            // Draw character as arrow
            Position charPos = grid.character.position;
            Rectangle charRect = new Rectangle(
                (charPos.x - minX) * cellSize,
                totalHeight - ((charPos.y - minY + 1) * cellSize),
                cellSize,
                cellSize);
            DrawArrow(g, charRect, grid.character.direction);

            // Draw the endpoint
            if (grid.Endpoint != null)
            {
                Position endPos = grid.Endpoint;
                Rectangle endRect = new Rectangle(
                    (endPos.x - minX) * cellSize,
                    totalHeight - ((endPos.y - minY + 1) * cellSize),
                    cellSize,
                    cellSize);
                g.FillRectangle(Brushes.Red, endRect);
            }
        }
    }
}