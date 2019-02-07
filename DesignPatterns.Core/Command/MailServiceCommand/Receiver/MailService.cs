using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Command.MailServiceCommand.Receiver
{
    public class MailService
    {
        public void AddMember(string contact, string contactGroup)
        {
            Console.WriteLine("Added " + contact + " to " + contactGroup);
        }

        public void RemoveMember(string contact, string contactGroup)
        {
            Console.WriteLine("Removed " + contact + " from " + contactGroup);
        }
    }
}
