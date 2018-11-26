using DesignPatterns.Core.Decorator.CoffeeShopDecorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Decorator.CoffeeShopDecorator.Decorator
{
    public class Soy: CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription() => beverage.GetDescription() + ", Soy";

        public override decimal Value() => .15M + beverage.Value();
    }
}
