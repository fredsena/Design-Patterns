using DesignPatterns.Core.Strategy.DuckStrategy.Algorithm;
using DesignPatterns.Core.Strategy.DuckStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Strategy.DuckStrategy.Ducks
{
    public class RubberDuck : Duck
    {
        IFlyBehavior flyBehavior = new FlyNoWay();
        IQuackBehavior quackBehavior = new Squeak();

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duckie");
        }
    }
}
