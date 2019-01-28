using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Factory.PizzaFactory.Product
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings = new List<string>();

        public void Prepare()
        {
            ToString("Preparing: " + Name);
        }

        public void Bake()
        {
            ToString("Baking: " + Name);
        }

        public void Cut()
        {
            ToString("Cutting: " + Name);
        }

        public void Box()
        {
            ToString("Boxing: " + Name);
        }

        public string ToString(string value)
        {
            var display = new StringBuilder();
            display.Append("---- ").Append(Name).Append(" ----\n");
            display.Append(Dough).Append("\n");
            display.Append(Sauce).Append("\n");

            foreach (var item in Toppings)
            {
                display.Append(item).Append("\n");
            }

            display.Append(value).Append("\n");

            return display.ToString();
        }
    }
}
