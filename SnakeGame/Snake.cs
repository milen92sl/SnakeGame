using SnakeGame.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    public class Snake
    {
        public Dot Head { get; set; }

        public List<BaseDot> Body { get; set; }

        public void Print()
        {
            Head.Render();

            foreach (var dot in this.Body)
            {
                dot.Render();
            }
        }

        public void Move()
        {


            for (int i = 0; i < Body.Count - 1; i++)
            {
                Body[i].Position = new Coordinate(Body[i + 1].Position);
            }
            Body[Body.Count - 1].Position = new Coordinate(Head.Position);
            Head.Move();
            if (CheckIfDead())
            {
                throw new ArgumentException("You are Dead");
            }
        }
        public void EatFood(IPositionalRenderer renderer)
        {
            this.Body.Add(new BaseDot(renderer, GlobalConstants.Symbol, new Coordinate(Body[^1].Position)));
        }
        private bool CheckIfDead()
        {
            foreach (var dot in this.Body)
            {
                if (Head.Position == dot.Position)
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}


