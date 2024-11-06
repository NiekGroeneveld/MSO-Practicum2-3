using Learn2CodeV2;

namespace CommandTests
{
    public class MoveCommandTest
    {
        [Fact]
        public void MoveThree()
        {
            //Assign
            ICommand command = new MoveCommand(3);
            Grid grid = new Grid(10, 10, false); //Grid of a too large size to check. Creates a character at (0,0) facing east
            Position endposition = new Position(3, 0);
            
            //Act
            command.Execute(grid);

            //Assert

            Assert.Equal(grid.Character.Position, endposition); 
        }
    }
}