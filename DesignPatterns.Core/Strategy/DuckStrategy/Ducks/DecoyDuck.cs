using DesignPatterns.Core.Strategy.DuckStrategy.Algorithm;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Strategy.DuckStrategy.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _iFlyBehavior = new FlyNoWay();
            _iQuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
