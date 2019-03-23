using DesignPatterns.Core.Command.CalculatorCommand.Commands;
using DesignPatterns.Core.Command.CalculatorCommand.Receiver;
using System.Collections.Generic;

namespace DesignPatterns.Core.Command.CalculatorCommand.Invoker
{
    public class InvokerUser
    {
        public CalculatorService calculator = new CalculatorService();
        private List<ICommand> _commands = new List<ICommand>();
        private int _current;

        public void Compute(char @operator, int operand)
        {
            ICommand command = new CalculateCommand(calculator, @operator, operand);
            command.Execute();
            _commands.Add(command);
            _current++;
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    ICommand command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    ICommand command = _commands[--_current] as ICommand;
                    command.Revert();
                }
            }
        }
    }
}
