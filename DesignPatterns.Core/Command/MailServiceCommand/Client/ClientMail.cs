using DesignPatterns.Core.Command.MailServiceCommand.Commands;
using DesignPatterns.Core.Command.MailServiceCommand.Invoker;
using DesignPatterns.Core.Command.MailServiceCommand.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Command.MailServiceCommand.Client
{
    public class ClientMail
    {
        public void RunCommand()
        {
            var receiver = new MailService();
            var invoker = new InvokerMail();

            invoker.Command = new AddMemberCommand("email@email.com", "emailName", receiver);
            invoker.ExecuteCommand();
        }
    }
}
