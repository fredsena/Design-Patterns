using DesignPatterns.Core.Command.MailServiceCommand.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Command.MailServiceCommand.Commands
{
    public class AddMemberCommand: ICommand
    {
        private string _emailAddress;
        private string _listName;
        protected MailService _receiver;

        public AddMemberCommand(string email, string listName, MailService receiver)
        {
            _emailAddress = email;
            _listName = listName;
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.AddMember(_emailAddress, _listName);
        }
    }
}
