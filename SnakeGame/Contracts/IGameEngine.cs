using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame.Contracts
{
    public interface IGameEngine
    {
        void Start();

        void Terminate();
    }
}
