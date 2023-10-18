using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KlokovIA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KlokovIA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(45, DataService.Calc(1, 3, 5));
        }
    }
}
