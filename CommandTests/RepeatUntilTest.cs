using Learn2CodeV2;

namespace CommandTests
{
    public class RepeatUntilTest
    {
        [Fact]
        public void RepeatUntilWall()
        {
            //assign
            ICommand moveCommand = new MoveCommand(1);
            List<ICommand> repeat = new List<ICommand>();
            repeat.Add(moveCommand);


            ICommand repeatUntilCommand = new RepeatUntilCommand("wall", repeat);
            Grid grid = new Grid(20, 20, false);
            grid.ClosedPosition.Add(new Position(5,0));

            //act
            repeatUntilCommand.Execute(grid);

            //assert
            Assert.Equal(grid.Character.Position, new Position(4, 0));
            
        }


        [Fact]
        public void RepeatUntilEdge()
        {
            //assign
            ICommand moveCommand = new MoveCommand(1);
            List<ICommand> repeat = new List<ICommand>();
            repeat.Add(moveCommand);


            ICommand repeatUntilCommand = new RepeatUntilCommand("edge", repeat);
            Grid grid = new Grid(6, 6, false);
            

            //act
            repeatUntilCommand.Execute(grid);

            //assert
            Assert.Equal(grid.Character.Position, new Position(5, 0));

        }

    }
}
