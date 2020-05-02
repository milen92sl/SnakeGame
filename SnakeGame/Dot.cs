using SnakeGame.Common;
using SnakeGame.Contracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace SnakeGame
{
    public class Dot: BaseDot 
    {
        private readonly IDirection direction;

        public Dot(IPositionalRenderer renderer,IDirection direction,string symbol,Coordinate position)
            :base(renderer,symbol,position)
        {
          
            this.direction = direction;
        }

        public void Move()
        {
            this.Position = this.direction.GetNewPosition(this.Position);
        }

        public void ChageDirection(Directions direction)
        {
            this.direction.ChageDirection(direction);
        }
    }
}
