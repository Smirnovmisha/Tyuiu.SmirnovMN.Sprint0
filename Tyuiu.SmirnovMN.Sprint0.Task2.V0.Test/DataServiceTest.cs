﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovMN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SmirnovMN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Миша";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Миша", res)
        }
    }
}
