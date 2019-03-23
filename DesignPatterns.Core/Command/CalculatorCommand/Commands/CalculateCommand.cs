using DesignPatterns.Core.Command.CalculatorCommand.Receiver;
using System;

namespace DesignPatterns.Core.Command.CalculatorCommand.Commands
{
    public class CalculateCommand : ICommand
    {
        private char _operator;
        private int _operand;
        private CalculatorService _calculator;

        // Constructor
        public CalculateCommand(CalculatorService calculator,
          char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        // Gets operator
        public char Operator
        {
            set { _operator = value; }
        }

        // Get operand
        public int Operand
        {
            set { _operand = value; }
        }

        // Execute new command
        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        // Unexecute last command
        public void Revert()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        // Returns opposite operator for given operator
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new
            ArgumentException("@operator");
            }
        }
    }
}
