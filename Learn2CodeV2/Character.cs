using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    internal class Character
    {
        private static Character _instance;

        public Position position;

        public Direction direction;

        private Character()
        {
            position = new Position(0, 0);
            direction = Direction.East;
        }

        public static Character GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Character();
            }

            return _instance;
        }

        public Position GetPosition()
        {
            return position;
        }

        public override string ToString()
        {
            return $"End state ({position.x},{position.y}) facing {direction}.";
        }
    }
}
