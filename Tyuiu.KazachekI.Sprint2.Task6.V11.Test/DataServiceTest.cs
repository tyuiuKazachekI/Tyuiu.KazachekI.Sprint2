using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint2.Task6.V11.Lib;

namespace Tyuiu.KazachekI.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckNextDaySimple()
        {
            DataService ds = new DataService();

            int year = 2023;
            int month = 5;
            int day = 14;
            string result = ds.FindDateOfNextDay(year, month, day);

            string expected = "15.05.2023";

            Assert.AreEqual(expected, result);
        }
    }
}