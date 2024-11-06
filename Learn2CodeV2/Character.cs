﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    public class Character
    {
        public Position position;

        public Direction direction;

        public List<Position> pathHistory = new List<Position>();   

        public Character()
        {
            position = new Position(0, 0);
            direction = Direction.East;
            pathHistory.Add(new Position(0,0));
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
