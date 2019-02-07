using DesignPatterns.Core.Command.MailServiceCommand.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Command.MailServiceCommand.Invoker
{
    public class InvokerMail
    {
        public ICommand Command { get; set; }

        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}
