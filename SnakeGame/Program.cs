using SnakeGame.Contracts;
using SnakeGame.IO;
using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = GlobalConstants.ConsoleWidth;
            Console.WindowHeight = GlobalConstants.ConsoleHeigth;
            Console.BufferHeight = GlobalConstants.ConsoleHeigth;
            Console.BufferWidth = GlobalConstants.ConsoleWidth;
            Console.CursorVisible = false;

            IPositionalRenderer renderer = new ConsoleRenderer();
            IReader reader = new ConsoleReader();
            IFoodGenerator generator = new FoodGenerator();
            IGameEngine gameEngine = new SnakeEngine(renderer, reader, generator);
            gameEngine.Start();
        }

    }
}
