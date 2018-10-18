using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Core.Strategy.DuckStrategy.Interfaces;

namespace DesignPatterns.Core.Strategy.DuckStrategy.Algorithm
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can not fly...");
        }
    }
}
