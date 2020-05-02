using SnakeGame.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    public abstract class BaseDot
    {    
        public BaseDot(IPositionalRenderer renderer, string symbol, Coordinate position)
        {
            this.renderer = renderer;
            this.Symbol = symbol;
            this.Position = position;
          
        }
        protected IPositionalRenderer Renderer { get; private set; }

        public Coordinate Position { get; set; }

        public string Symbol { get; set; }


        public void Render()
        {
            Renderer.WriteAtPosition(Position, Symbol);
        }


    }
}

