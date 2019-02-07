using DesignPatterns.Core.Command.MailServiceCommand.Client;
using System;
using System.Linq;
using Xunit;

namespace DesignPatterns.Tests
{
    public class MailServiceCommandTests
    {
        [Fact]
        public void TestMethod1()
        {
            var client = new ClientMail();

            client.RunCommand();
        }
    }
}
