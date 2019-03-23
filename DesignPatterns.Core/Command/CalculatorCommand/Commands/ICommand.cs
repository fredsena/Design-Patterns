using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Command.CalculatorCommand.Commands
{
    public interface ICommand
    {
        void Execute();
        void Revert();
    }
}
