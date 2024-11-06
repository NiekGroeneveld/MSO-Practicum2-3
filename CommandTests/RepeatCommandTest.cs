using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Learn2CodeV2;

namespace CommandTests
{
    public class RepeatCommandTest
    {
        [Fact]
        public void RepeatMoveTurn()
        {
            //assign
            ICommand moveCommand = new MoveCommand(10);
            ICommand turnCommand = new TurnCommand("right");
            List<ICommand> repeat = new List<ICommand>();
            repeat.Add(moveCommand);
            repeat.Add(turnCommand);
            
            ICommand repeatCommand = new RepeatCommand(2, repeat);
            Grid grid = new Grid(20, 20, false);
            
            //act
            repeatCommand.Execute(grid);

            //assert
            Assert.Equal(grid.Character.Position, new Position(10,-10));
            Assert.True(grid.Character.Direction == Direction.West);
        }

    }
}
