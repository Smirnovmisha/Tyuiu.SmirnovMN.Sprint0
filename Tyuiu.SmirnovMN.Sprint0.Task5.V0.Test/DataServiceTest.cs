using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint0.Task5.V0.Lib;
namespace Tyuiu.SmirnovMN.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(20, DataService.Subtraction(40, 20));
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(30, DataService.Multiplication(5, 6));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(5, DataService.Division(50, 10));
        }


    }
}