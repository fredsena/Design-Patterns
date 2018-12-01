using DesignPatterns.Core.Iterator.MenuIterator.Aggregate;
using DesignPatterns.Core.Iterator.MenuIterator.Iterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;

namespace DesignPatterns.Tests
{
    public class MenuIteratorTests
    {
        [Fact]
        public void MenuIterator_GetIterator()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();

            IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = dinerMenu.CreateIterator();

            var pancakeIteratorResult = PrintMenu(pancakeIterator);
            pancakeIteratorResult.OfType<IEnumerable>().Should().HaveCount(4);

            var dinerIteratorResult = PrintMenu(dinerIterator);
            dinerIteratorResult.OfType<IEnumerable>().Should().HaveCount(6);
        }

        private IEnumerable PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                yield return  iterator.Next().ToString();
            }
        }

    }
}
