using SnakeGame.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class FoodGenerator : IFoodGenerator
    {
        private Food food;

        public Food Food { get; set; }
        public Food GenerateFood(IPositionalRenderer renderer)
        {
            this.Food = new Food(renderer, GlobalConstants.FoodSymbol, Coordinate.GetRandomPosition(GlobalConstants.ConsoleWidth, GlobalConstants.ConsoleHeight));
            this.RenderFood();
            return this.Food;
        }

        public void RenderFood()
        {
            this.food.Render();
        }
    }
}
