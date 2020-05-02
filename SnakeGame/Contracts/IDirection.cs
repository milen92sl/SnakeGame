using SnakeGame.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame.Contracts
{
    public interface IDirection
    {
        Coordinate GetNewPosition(Coordinate position);

        void ChageDirection(Directions direction);
    }
}
