using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloFunction;

namespace HelloFunction_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Program prg = new Program();

            // Act 
            var result = prg.getString();

            // Assert
            Assert.AreEqual(result, "HelloFunction");
        }
    }
}
