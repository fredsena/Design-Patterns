using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Decorator.CoffeeShopDecorator.Component
{
    public abstract class Beverage
    {
        public string Description { get; set; }

        public String GetDescription() => Description;

        public abstract decimal Value();
    }
}
