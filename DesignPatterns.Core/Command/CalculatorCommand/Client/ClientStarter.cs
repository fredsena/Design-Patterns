using DesignPatterns.Core.Command.CalculatorCommand.Invoker;

namespace DesignPatterns.Core.Command.CalculatorCommand.Client
{
    public class ClientStarter
    {
        public InvokerUser invoker = new InvokerUser();

        public void RunCommand()
        {
            invoker.Compute('+', 100);
            invoker.Compute('+', 100);
            invoker.Compute('-', 50);
            invoker.Compute('*', 10);
            invoker.Compute('/', 2);

            // Undo 4 commands
            invoker.Undo(4);

            // Redo 3 commands
            invoker.Redo(3);
        }
    }
}
