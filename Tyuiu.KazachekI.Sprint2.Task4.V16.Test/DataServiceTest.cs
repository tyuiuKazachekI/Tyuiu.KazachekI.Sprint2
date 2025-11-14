using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint2.Task4.V16.Lib;

namespace Tyuiu.KazachekI.Sprint2.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSimpleCalculation()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 5;
            double result = ds.Calculate(x, y);

            double expected = 1.082;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}