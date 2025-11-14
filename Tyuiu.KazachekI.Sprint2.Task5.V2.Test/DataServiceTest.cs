using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint2.Task5.V2.Lib;

namespace Tyuiu.KazachekI.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckWinterMonth()
        {
            DataService ds = new DataService();

            int month = 1;
            string result = ds.FindMonthSeason(month);

            string expected = "зима";

            Assert.AreEqual(expected, result);
        }
    }
}