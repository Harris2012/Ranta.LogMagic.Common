using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Ranta.LogMagic.Common.Generic;

namespace Ranta.LogMagic.Common.Test
{
    [TestClass]
    public class MsmqTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var msmq = new Msmq<MessageBase<string>>(ConfigurationManager.AppSettings["RantaLogQueue"]);

            var message = new MessageBase<string> { Guid = Guid.NewGuid(), Content = "Hello World" };

            msmq.Enqueue(message);

            var message2 = msmq.Dequeue();

            Assert.IsNotNull(message2);

            Assert.AreEqual(message.Guid, message2.Guid);
            Assert.AreEqual(message.Content, message2.Content);
        }
    }
}
