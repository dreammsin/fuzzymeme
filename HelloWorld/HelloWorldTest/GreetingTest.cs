using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld
{
    [TestClass]
    public class GreetingTest
    {
        [TestMethod]
        public void ToStringReturnsAGreeting()
        {
            //arrange
            var instance = new Greeting();

            //act
            var results = instance.ToString();

            //assert
            StringAssert.StartsWith(results,"Hello");
            StringAssert.EndsWith(results, "World");
        }
    }
}
