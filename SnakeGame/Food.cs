using SnakeGame.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    public class Food : BaseDot
    {
        public Food(IPositionalRenderer renderer, string symbol, Coordinate position)
            :base(renderer,symbol,position)
        {

        }
    }
}
