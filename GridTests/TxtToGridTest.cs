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
            string filePath = "TestGridTxt.txt";

            //Act
            Grid grid = txtToGrid.FileToGrid(filePath);
            List<Position> closedPositions = grid.ClosedPosition;
            Position closedPosition = new Position(1, 0);

            //Assert
            Assert.True(closedPositions.Contains(closedPosition)); //Verifies that position gets added
            Assert.True(closedPositions.Count() == 1);
        }
    }
}