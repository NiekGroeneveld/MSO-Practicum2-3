using MSO_P2;
using Learn2CodeV2;

namespace TestsLearn2Code
{
    public class MoveCommandTest
    {
        [Fact]
        public void Test1()
        {
        Grid grid = new Grid(10, 10);
        ICommand command = new MoveCommand(10);
        command.Execute(grid.character);

        Position endPosition = new Position(0, 10);
        Assert.True(endPosition == grid.character.position);
        }
    }
}