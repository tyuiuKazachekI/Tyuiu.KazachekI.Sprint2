using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint2.Task1.V9.Lib;

namespace Tyuiu.KazachekI.Sprint2.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLogicOperations()
        {
            DataService ds = new DataService();

            int a = 15;
            int b = 335;
            int c = 174;
            int d = 478;
            bool[] result = ds.GetLogicOperations(a, b, c, d);
            bool expectedThird = true;

            Assert.AreEqual(expectedThird, result[2]);
        }
    }
}