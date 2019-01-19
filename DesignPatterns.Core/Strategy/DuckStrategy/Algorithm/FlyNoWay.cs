using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Core.Strategy.DuckStrategy.Interfaces;

namespace DesignPatterns.Core.Strategy.DuckStrategy.Algorithm
{
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I can not Fly!!!!";
        }
    }
}
