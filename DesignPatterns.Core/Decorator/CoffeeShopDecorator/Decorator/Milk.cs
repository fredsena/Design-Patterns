using DesignPatterns.Core.Decorator.CoffeeShopDecorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Decorator.CoffeeShopDecorator.Decorator
{
    public class Milk : CondimentDecorator
    {
        readonly Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }

        public override decimal Value() => .10M + beverage.Value();
    }
}
