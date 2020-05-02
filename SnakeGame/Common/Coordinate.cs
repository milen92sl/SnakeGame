using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SnakeGame
{
    public class Coordinate : IEquatable<Coordinate>
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;

        }
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(Coordinate coord)
        {
            this.X = coord.X;
            this.Y = coord.Y;
        }
        public static Coordinate GetRandomPosition(int width, int height)
        {
            Random rand = new Random();
           return new Coordinate(rand.Next(0, width), rand.Next(0, height));
        }
        public bool Equals(Coordinate other)
        {
            if (other.X == this.X && other.Y == this.Y)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Coordinate first, Coordinate second)
        {
            if (first.X != second || first.Y != second)
            {
                return true;
            }

            return false;
        }
    }
}
