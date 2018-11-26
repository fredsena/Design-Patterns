
using System;
using System.Linq;
using Xunit;
using DesignPatterns.Core.Decorator.CoffeeShopDecorator.Component;
using DesignPatterns.Core.Decorator.CoffeeShopDecorator.Decorator;

namespace DesignPatterns.Tests
{
    public class CoffeeShopDecoratorTests
    {
        [Fact]
        public void Expresso_WhenInstantiated_ReturnsCorrectValues()
        {
            Beverage beverage = new Espresso();
            Assert.Equal(nameof(Espresso), beverage.GetDescription());
            Assert.Equal(1.99m, beverage.Value());
        }

        [Fact]
        public void HouseBlend_WhenAddDecorators_ValueIsIncreased()
        {
            Beverage houseBlend = new HouseBlend();
            decimal value = houseBlend.Value();
            houseBlend = new Soy(houseBlend);
            houseBlend = new Mocha(houseBlend);

            Assert.NotEqual(value, houseBlend.Value());

            Assert.Equal(houseBlend.Description, houseBlend.GetDescription());
        }
    }
}
