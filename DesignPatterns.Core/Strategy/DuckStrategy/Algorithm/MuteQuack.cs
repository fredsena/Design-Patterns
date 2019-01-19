using DesignPatterns.Core.Strategy.DuckStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Strategy.DuckStrategy.Algorithm
{
    public class MuteQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "<< Silence >>";
        }
    }
}
