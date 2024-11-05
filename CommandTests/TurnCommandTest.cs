using MSO_P2;
using Learn2CodeV2;

namespace CommandTests
{
    public class TurnCommandTest
    {
        [Fact]
        public void MoveRight()
        {
            //Assign
            ICommand command = new TurnCommand("right");
            Grid grid = new Grid(10, 10); //Grid of a too large size to check. Creates a character at (0,0) facing east

            //Act
            command.Execute(grid.character);

            //Assert
            Assert.Equal(grid.character.direction, Direction.South);
        }
    }
}