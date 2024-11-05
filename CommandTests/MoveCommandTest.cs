using MSO_P2;
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
            Grid grid = new Grid(10, 10); //Grid of a too large size to check. Creates a character at (0,0) facing east
            Position endposition = new Position(3, 0);
            
            //Act
            command.Execute(grid.character);

            //Assert

            Assert.Equal(grid.character.position, endposition); 
        }
    }
}