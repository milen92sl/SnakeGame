using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame.Contracts
{
    public interface IPositionalRenderer
    {
        public void WriteAtPosition(Coordinate coordinate, object input);

        void Clear();

        void PrintGameOver();
    }
}
