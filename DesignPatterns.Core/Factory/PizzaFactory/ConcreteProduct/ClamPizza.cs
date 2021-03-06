﻿using DesignPatterns.Core.Factory.PizzaFactory.Product;

namespace DesignPatterns.Core.Factory.PizzaFactory.ConcreteProduct
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Name = "Clam Pizza";
            Dough = "Thin crust";
            Sauce = "White garlic sauce";
            Toppings.Add("Clams");
            Toppings.Add("Grated parmesan cheese");
        }
    }
}
