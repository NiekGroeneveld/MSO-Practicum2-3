
using System;

namespace Learn2CodeV2
{
    public class MoveCommand : ICommand
    {
        public int Steps {  get; private set; }

        public MoveCommand(int steps)
        {
            Steps = steps;
        }

        public void Execute(Grid grid)
        {

            switch (grid.Character.Direction)
            {
                case Direction.North:
                    grid.Character.Position.Y += Steps;
                    break;
                case Direction.East:
                    grid.Character.Position.X += Steps;
                    break;
                case Direction.South:
                    grid.Character.Position.Y -= Steps;
                    break;
                case Direction.West:
                    grid.Character.Position.X -= Steps;
                    break;
            }

            Position newPos = new Position(grid.Character.Position.X, grid.Character.Position.Y);

            if (grid.IsExercise)
            {
                if (!grid.IsValidPosition(newPos))
                    throw new MoveException("Character is in an invalid position");

                if (grid.IsOutOfBounds(newPos))
                    throw new MoveException("Character is out of bounds");
            }

            //New line to add the position where the character has been.
            grid.Character.PathHistory.Add(new Position(grid.Character.Position.X, grid.Character.Position.Y));
          
            Console.Write($"Move {Steps}, ");
        }

        public int CountCommands()
        {
            return 1;
        }

        public override string ToString()
        {
            return $"MOVE {Steps}";
        }
    }
}
