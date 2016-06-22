using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerSettingProvider;

namespace ServerSettingProvider.Test
{
    [TestClass]
    public class ServerSettingsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Guid.Parse("081b8162-8a2a-4a34-8c28-1c081b6768ee"), ServerSettings.GetSystemUserId());
        }
    }
}
