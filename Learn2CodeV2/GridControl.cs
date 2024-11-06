using Learn2CodeV2;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Learn2CodeV2
{
    public sealed class GridControl : Control
    {
        private readonly Grid _grid;
        private const int CellSize = 20;

        // Properties to control the grid's position
        public Point GridPosition
        {
            get => Location;
            set => Location = value;
        }

        public GridControl(Grid grid)
        {
            this._grid = grid;
            this.Size = new Size(grid.Width * CellSize, grid.Height * CellSize);

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

            //Find the minimum and maximum x and y values in the path history
            int minX = int.MaxValue, minY = int.MaxValue, maxX = int.MinValue, maxY = int.MinValue;
            if (!_grid.IsExercise)
            {
                foreach (Position p in _grid.Character.PathHistory)
                {
                    int x = p.X;
                    int y = p.Y;
                    minX = Math.Min(x, minX);
                    minY = Math.Min(y, minY);
                    maxX = Math.Max(x, maxX);
                    maxY = Math.Max(y, maxY);
                }
            }
            else
            {
                minX = 0;
                minY = -1 * (_grid.Height - 1);
                maxX = _grid.Width - 1;
                maxY = 0;
            }

            // Calculate total height to flip Y coordinates
            int totalHeight = (maxY - minY + 1) * CellSize;

            // Draw the grid cells
            for (int x = minX; x <= maxX; x++)
            {
                for (int y = minY; y <= maxY; y++)
                {
                    // Flip Y coordinate by subtracting from total height
                    Rectangle cellRect = new Rectangle(
                        (x - minX) * CellSize,
                        totalHeight - ((y - minY + 1) * CellSize),
                        CellSize,
                        CellSize);

                    if (_grid.ClosedPosition.Contains(new Position(x, y)))
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

            // Draw the visited positions line
            Pen pathPen = new Pen(Color.CornflowerBlue, 3);
            int lineoffset = CellSize / 2;
            for (int i = 1; i < _grid.Character.PathHistory.Count; i++)
            {
                Position oldPosition = _grid.Character.PathHistory[i - 1];
                Position newPosition = _grid.Character.PathHistory[i];
                int oldX = (oldPosition.X - minX) * CellSize + lineoffset;
                int oldY = totalHeight - ((oldPosition.Y - minY + 1) * CellSize) + lineoffset;
                int newX = (newPosition.X - minX) * CellSize + lineoffset;
                int newY = totalHeight - ((newPosition.Y - minY + 1) * CellSize) + lineoffset;

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
            Position charPos = _grid.Character.Position;
            Rectangle charRect = new Rectangle(
                (charPos.x - minX) * cellSize,
                totalHeight - ((charPos.y - minY + 1) * cellSize),
                cellSize,
                cellSize);
            DrawArrow(g, charRect, grid.character.direction);   
        }
    }
}