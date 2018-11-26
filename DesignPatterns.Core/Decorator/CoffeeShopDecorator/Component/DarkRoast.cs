using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Decorator.CoffeeShopDecorator.Component
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override decimal Value()
        {
            return .99M;
        }
    }
}
