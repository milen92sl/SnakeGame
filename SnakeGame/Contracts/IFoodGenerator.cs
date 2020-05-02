using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame.Contracts
{
    public interface IFoodGenerator
    {
        Food GenerateFood(IPositionalRenderer renderer);

        void RenderFood();
    }
}
