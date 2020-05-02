using SnakeGame.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame.IO
{
    public class ConsoleReader
    {
        public string ReadKey()
        {
           
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                return key.Key.ToString();
            }
            return null;
        }
    }
}
