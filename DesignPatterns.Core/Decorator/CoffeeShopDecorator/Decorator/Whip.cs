using DesignPatterns.Core.Decorator.CoffeeShopDecorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Decorator.CoffeeShopDecorator.Decorator
{
    public class Whip: CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription() => beverage.GetDescription() + ", Whip";

        public override decimal Value() => .10M + beverage.Value();
    }
}
