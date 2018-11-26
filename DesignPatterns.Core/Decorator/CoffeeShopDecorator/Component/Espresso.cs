using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Decorator.CoffeeShopDecorator.Component
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override decimal Value() => 1.99m;
    }
}
