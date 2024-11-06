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
            Grid grid = new Grid(10, 10, false); //Grid of a too large size to check. Creates a character at (0,0) facing east

            //Act
            command.Execute(grid);

            //Assert
            Assert.Equal(grid.Character.Direction, Direction.South);
        }
    }
}