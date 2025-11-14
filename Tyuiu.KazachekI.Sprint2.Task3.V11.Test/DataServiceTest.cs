using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint2.Task3.V11.Lib;

namespace Tyuiu.KazachekI.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSimpleCalculation()
        {
            DataService ds = new DataService();

            double x = 0;
            double result = ds.Calculate(x);

            double expected = 12.0;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}