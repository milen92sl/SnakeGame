using SnakeGame.Common;
using SnakeGame.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SnakeGame
{
    public class SnakeEngine : IGameEngine
    {
        private readonly IPositionalRenderer renderer;
        private readonly IFoodGenerator foodGenerator;
        private readonly IReader reader;
        private Snake snake;
        private Food currentFood;
        public SnakeEngine(IPositionalRenderer renderer)
        {
            this.renderer = renderer;
        }

        public SnakeEngine(IPositionalRenderer renderer, IReader reader, IFoodGenerator foodGenerator)
        {
            this.reader = reader;
            this.renderer = renderer;
            this.foodGenerator = foodGenerator;
            currentFood = foodGenerator.GenerateFood(renderer);
            this.snake = SnakeFactory.CreateSnake(renderer);
            this.snake.Body.Reverse();
        }
        public void Start()
        {
            while (true)
            {
                ChangeDirection();
                CheckIfFoodisEaten();
                this.snake.Render();
                this.foodGenerator.RenderFood();
                
                try
                {
                    this.snake.Move();
                }
                catch (Exception)
                {
                    this.Terminate();
                    return;
                }



                Thread.Sleep(100);
                renderer.Clear();
            }
        }

        private void CheckIfFoodisEaten()
        {
            if (this.currentFood.Position == this.snake.Head.Position)
            {
                this.currentFood = foodGenerator.GenerateFood(renderer);
                this.snake.EatFood(currentFood.Position);
            }
        }

        private void ChangeDirection()
        {
            string keyPressed = reader.ReadKey();
            if (keyPressed != null)
            {
                switch (keyPressed)
                {
                    case "LeftArrow":
                        snake.Head.ChageDirection(Directions.Left);
                        break;
                    case "RightArrow":
                        snake.Head.ChageDirection(Directions.Right);
                        break;
                    case "DownArrow":
                        snake.Head.ChageDirection(Directions.Down);
                        break;
                    case "UpArrow":
                        snake.Head.ChageDirection(Directions.Up);
                        break;
                    default:
                        break;
                }
            }
        }
        public void Terminate()
        {
            renderer.PrintGameOver();
        }
    }
}
