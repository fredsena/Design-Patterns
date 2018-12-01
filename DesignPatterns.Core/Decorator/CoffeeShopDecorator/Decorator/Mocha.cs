using DesignPatterns.Core.Decorator.CoffeeShopDecorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Decorator.CoffeeShopDecorator.Decorator
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription() => beverage.GetDescription() + ", Mocha";

        public override decimal Value() => .20M + beverage.Value();
    }
}
