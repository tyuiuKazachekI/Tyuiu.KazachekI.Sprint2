using Tyuiu.KazachekI.Sprint2.Task0.V24.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void CheckFirstComparison()
    {
        DataService ds = new DataService();

        int x = 135;
        int y = 755;

        bool[] result = ds.GetCompareOperations(x, y);

        bool expectedFirst = true;

        Assert.AreEqual(expectedFirst, result[0]);
    }
}