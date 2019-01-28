using DesignPatterns.Core.Factory.PizzaFactory.Product;

namespace DesignPatterns.Core.Factory.PizzaFactory.ConcreteProduct
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Dough = "Regular Crust";
            Sauce = "Marinara Pizza Sauce";
            Toppings.Add("Fresh Mozzarella");
            Toppings.Add("Parmesan");
        }
    }
}
