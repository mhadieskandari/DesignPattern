using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.DesignPatterns;
using OOP.DesignPatterns.Structural;

namespace OOP.Test
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void IsPolicyASingleton()
        {
            Assert.AreEqual(Policy.Instance, Policy.Instance);
        }
    }
}
