using MSO_P2;
using System;
using System.IO;

namespace Learn2CodeV2
{
    public class TxtToGrid
    {
        public Grid FileToGrid(string filePath)
        {
            string[] rows = File.ReadAllLines(filePath);
            Grid grid = new Grid(rows[0].Length, rows.Length, true);

            int y = 0;
            foreach (string row in rows)
            {
                int x = 0;
                foreach (char c in row)
                {
                    if (c == '+')
                    {
                        Position position = new Position(x, y);
                        grid.closedPosition.Add(position);
                    }
                    if (c == 'x')
                    {
                        Position position = new Position(x, y);
                        grid.Endpoint = position;
                    }
                    x++;
                }
                y--;
            }

            return grid;
        }
    }
}
