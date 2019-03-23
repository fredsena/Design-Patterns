using DesignPatterns.Core.Command.CalculatorCommand.Invoker;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests
{
    public class CalculatorCommandTests
    {
        [Fact]
        public void Compute_WhenComputes_ReturnsCorrectValue()
        {
            var invoker = new InvokerUser();

            invoker.Compute('+', 100);
            invoker.Compute('+', 100);
            invoker.Compute('-', 50);

            invoker.calculator.CurrentValue.Should().Be(150);
        }

        [Fact]
        public void Compute_WhenUndo_ReturnsCorrectValue()
        {
            var invoker = new InvokerUser();

            invoker.Compute('+', 100);
            invoker.Compute('+', 100);
            invoker.Compute('-', 50);
            invoker.Compute('*', 10);
            invoker.Compute('/', 2);

            invoker.Undo(4);

            invoker.calculator.CurrentValue.Should().Be(100);
        }
    }
}
