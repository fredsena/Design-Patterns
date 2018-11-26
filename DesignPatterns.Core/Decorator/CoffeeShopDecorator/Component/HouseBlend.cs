using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Decorator.CoffeeShopDecorator.Component
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override decimal Value()
        {
            return .89M;
        }
    }
}
