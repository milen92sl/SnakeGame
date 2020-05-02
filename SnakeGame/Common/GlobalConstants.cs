using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace SnakeGame
{
    public static class GlobalConstants
    {
        public static readonly int ConsoleWidth = 70;

        public static readonly int ConsoleHeigth = 30;

        public static readonly Coordinate Center = new Coordinate(ConsoleWidth / 2, ConsoleHeigth / 2);

        public static readonly string Symbol = "*";

        public static readonly string HeadSymbol = "@";

        public static readonly string FoodSymbol = "#";


        public static readonly int InitialSize = 10;

        public static readonly string GameOverText = "You can't play become better and come back!";
    }
}
