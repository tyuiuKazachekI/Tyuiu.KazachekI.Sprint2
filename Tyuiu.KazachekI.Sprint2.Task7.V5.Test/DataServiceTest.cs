using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint2.Task7.V5.Lib;
using System;

namespace Tyuiu.KazachekI.Sprint2.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void CheckPointInArea()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = 0.5;
            bool result = ds.CheckDotInShadedArea(x, y);


            bool expected = true;

            Assert.AreEqual(expected, result);
        }
    }
}