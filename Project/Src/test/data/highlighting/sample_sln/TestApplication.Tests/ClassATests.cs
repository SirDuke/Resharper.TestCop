﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCop.TestApplication.Tests
{
    [TestClass]
    public class ClassATests
    {
        [TestMethod]
        public void ReturnsTrueMethodTest()
        {
            Assert.IsTrue(new ClassA().ReturnsTrue());
        }
    }
}