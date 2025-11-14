using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint2.Task2.V8.Lib;

namespace Tyuiu.KazachekI.Sprint2.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckPointInArea()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 4;
            bool result = ds.CheckDotInShadedArea(x, y);
            bool expected = true;

            Assert.AreEqual(expected, result);
        }
    }
}