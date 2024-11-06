using System.Globalization;
using Learn2CodeV2;

namespace PresetToCommandTest
{
    public class MoveStringToCommandTest
    {
        [Fact]
        public void MoveToCommand()
        {
            //assign
            string MoveTen = "Move 10";

            //act
            TxtToCommand txtToCommand = new TxtToCommand();
            ICommand command = txtToCommand.ToCommand(MoveTen);

            //assert
            Assert.Equal(command.ToString(), new MoveCommand(10).ToString());
        }
    }

    public class TurnStringToCommandTest
    {
        [Fact]
        public void TurnToCommand()
        {
            //assign
            string TurnLeft = "Turn Left";

            //act
            TxtToCommand txtToCommand = new TxtToCommand();
            ICommand command = txtToCommand.ToCommand(TurnLeft);

            //assert
            Assert.Equal(command.ToString(), new TurnCommand("left").ToString());
        }
    }
}