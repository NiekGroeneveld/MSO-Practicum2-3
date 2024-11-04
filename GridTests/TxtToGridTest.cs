using MSO_P2;
using Learn2CodeV2;
using System.Runtime.CompilerServices;

namespace GridTests
{
    public class TxtToGridTest
    {
        [Fact]
        public void StringArrayToGrid()
        {
            //Assign
            TxtToGrid txtToGrid = new TxtToGrid();
            string filePath = "C:\\Users\\ncgre\\source\\repos\\Learn2CodeV2\\GridTests\\TestGridTxt.txt";

            //Act
            Grid grid = txtToGrid.FileToGrid(filePath);
            List<Position> closedPositions = grid.closedPosition;
            Position closedPosition = new Position(1, 0);

            //Assert
            Assert.True(closedPositions.Contains(closedPosition)); //Verifies that position gets added
            Assert.True(closedPositions.Count() == 1);
        }
    }
}