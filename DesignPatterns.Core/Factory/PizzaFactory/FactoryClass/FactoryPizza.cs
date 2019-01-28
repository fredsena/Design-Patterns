using DesignPatterns.Core.Factory.PizzaFactory.ConcreteProduct;
using DesignPatterns.Core.Factory.PizzaFactory.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Factory.PizzaFactory.FactoryClass
{
    public class FactoryPizza
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }
            return pizza;
        }
    }
}
