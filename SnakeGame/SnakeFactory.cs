using SnakeGame.Common;
using SnakeGame.Contracts;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace SnakeGame
{
    public class SnakeFactory
    {
        public static Snake CreateSnake(IPositionalRenderer renderer)
        {
            var snake = new Snake();
            snake.Head = CreateSnakeHead(renderer);
            snake.Body = CreateSnakeBody(renderer, snake.Head);

            return snake;
        }

        private static List<BaseDot> CreateSnakeBody(IPositionalRenderer renderer)
        {
            var body = new List<BaseDot>();
            for (int i = 0; i < GlobalConstants.InitialSize; i++)
            {
                var position = new Coordinate(head.Position.X - i - 1, head.Position.Y);
                var bodyDot = new BaseDot(renderer, GlobalConstants.Symbol, position);
                body.Add(bodyDot);
            }
            return body;
        }
        private static Dot(IPositionalRenderer renderer)
        {
            return new Dot(renderer, new Direction(GlobalConstants, ConsoleWidth,
                GlobalConstants, ConsoleHeight), GlobalConstants.HeadSymbol, GlobalConstants.Center);
        }
    }
}
