using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Core.Strategy.DuckStrategy.Interfaces;

namespace DesignPatterns.Core.Strategy.DuckStrategy
{
    public abstract class Duck
    {
        public IFlyBehavior _iFlyBehavior;
        public IQuackBehavior _iQuackBehavior;

        public void SetFlyBehavior(IFlyBehavior iFlyBehavior)
        {
            _iFlyBehavior = iFlyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior iQuackBehavior)
        {
            _iQuackBehavior = iQuackBehavior;
        }

        public string Swim()
        {
            return "All Ducks float!!!";
        }

        public void DoQuack()
        {
            _iQuackBehavior.Quack();
        }

        public void DoFly()
        {
            _iFlyBehavior.Fly();
        }

        public abstract void Display();
    }
}
