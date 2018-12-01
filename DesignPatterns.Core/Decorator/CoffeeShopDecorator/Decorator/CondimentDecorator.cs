using DesignPatterns.Core.Decorator.CoffeeShopDecorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Decorator.CoffeeShopDecorator.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();
    }
}
