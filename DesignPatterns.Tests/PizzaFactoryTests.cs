using DesignPatterns.Core.Factory.PizzaFactory.Client;
using DesignPatterns.Core.Factory.PizzaFactory.FactoryClass;
using DesignPatterns.Core.Factory.PizzaFactory.Product;
using System;
using System.Linq;
using Xunit;
using FluentAssertions;
using DesignPatterns.Core.Factory.PizzaFactory.ConcreteProduct;

namespace DesignPatterns.Tests
{
    public class PizzaFactoryTests
    {
        [Fact]
        public void FactoryPizzaCreation_WhenInstantiated_CreateCorrectType()
        {
            FactoryPizza factory = new FactoryPizza();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza("cheese");
            pizza.Should().BeOfType<CheesePizza>();

            var log = pizza.ToString();

            pizza = store.OrderPizza("veggie");
            pizza.Should().BeOfType<VeggiePizza>();
        }
    }
}
