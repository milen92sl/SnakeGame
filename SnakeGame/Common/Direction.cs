using SnakeGame.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame.Common
{
    public class Direction : IDirection
    {
        private Directions direction;
        private int width;
        private int height;

        public Direction(int width, int height)
        {
            direction = Directions.Right;
            this.width = width;
            this.height = height;
        }

        public void ChageDirection(Directions direction)
        {
            this.direction = direction;
        }

        public Coordinate GetNewPosition(Coordinate position)
        {
            Coordinate positionToReturn = new Coordinate(position.X, position.Y) ;
            switch (direction)
            {
                case Directions.Left: 
                    if (positionToReturn.X <= 0)
                    {
                        positionToReturn.X = this.width - 1;                      
                    }
                    else
                    {
                        positionToReturn.X--;
                    }
                    positionToReturn.X--;
                    break;
                case Directions.Right: 
                    if (positionToReturn.X >= width - 1)
                    {
                        positionToReturn.X = 0;                        
                    }
                    else
                    {
                        positionToReturn.X++;
                    }
                    
                    break;
                case Directions.Up:
                    if (positionToReturn.Y <= 0)
                    {
                        positionToReturn.Y = height - 1;                        
                    }
                    else
                    {
                        positionToReturn.Y--;
                    }
                    
                    break;
                case Directions.Down:
                    if (positionToReturn.Y >= height - 1)
                    {
                        positionToReturn.Y = 0;          
                    }
                    else
                    {
                        positionToReturn.Y++;
                    }
                    
                    break;
                default:
                    break;
            }
            return positionToReturn;
        }
        public void ChangeDirection(Directions direction)
        {
            this.direction = direction;
            
        }
    }
}
