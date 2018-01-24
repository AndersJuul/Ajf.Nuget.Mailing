using System.IO;
using System.Net;
using NUnit.Framework;

namespace Ajf.Nuget.Logging.Tests
{
    [TestFixture]
    public class MailSenderTests
    {
        [Test]
        public void TestThatMailCanBeSend()
        {
            File.WriteAllText("dummy.txt","Lazy hound, quick fox etc");

            var mailSender = new MailSender();
            var httpStatusCode = mailSender.SendMailAsync("andersjuulsfirma@gmail.com", "andersjuulsfirma@gmail.com",
                "andersjuulsfirma@gmail.com", "TestEmail: Subject", "<html><html>", new string[] {"dummy.txt" }).Result;

            Assert.AreEqual(HttpStatusCode.Accepted, httpStatusCode);
        }
    }
}