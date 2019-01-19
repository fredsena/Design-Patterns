using DesignPatterns.Core.Strategy.DuckStrategy.Algorithm;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Strategy.DuckStrategy.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _iFlyBehavior = new FlyNoWay();
            _iQuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model Duck");
        }
    }
}
