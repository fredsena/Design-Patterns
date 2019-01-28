using DesignPatterns.Core.Factory.PizzaFactory.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Factory.PizzaFactory.ConcreteProduct
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            Dough = "Crust";
            Sauce = "Marinara sauce";
            Toppings.Add("Sliced Pepperoni");
            Toppings.Add("Sliced Onion");
            Toppings.Add("Grated parmesan cheese");
        }
    }
}
