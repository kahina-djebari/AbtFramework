using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbtFramework;

namespace abtTest
{
    [TestClass]
    public class DummyTest
    {
        [TestMethod]
        public void Test()
        {
            AbtDriver.LoginPage.goTo();
        }
    }
}
