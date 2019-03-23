using DesignPatterns.Core.Command.MailServiceCommand.Commands;

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
