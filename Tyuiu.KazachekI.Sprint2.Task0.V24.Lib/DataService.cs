using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.KazachekI.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x + 620 == y;      // 135 + 620 = 755 → True
            result[1] = x != y;            // 135 ≠ 755 → True
            result[2] = x > y;             // 135 > 755 → False
            result[3] = x + 1000 < y;      // 1135 < 755 → False
            result[4] = x <= y;            // 135 ≤ 755 → True
            result[5] = x + 620 >= y;      // 755 ≥ 755 → True

            return result;
        }
    }
}
   