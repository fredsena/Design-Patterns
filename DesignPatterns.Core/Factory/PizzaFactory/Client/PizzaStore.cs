using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Core.Factory.PizzaFactory.FactoryClass;
using DesignPatterns.Core.Factory.PizzaFactory.Product;

namespace DesignPatterns.Core.Factory.PizzaFactory.Client
{
    public class PizzaStore
    {
        private readonly FactoryPizza factory;

        public PizzaStore(FactoryPizza factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPizza(String type)
        {
            Pizza pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
