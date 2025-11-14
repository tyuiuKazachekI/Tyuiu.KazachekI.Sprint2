using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KazachekI.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = (a > b) & (c == d);

            result[1] = (b >= d) | (a == c);

            result[2] = (a < c) ^ (b > d);

            result[3] = (c > d) && (a != a);

            result[4] = !(b < c) | (d > a);

            result[5] = (a == b) && (c <= d);

            return result;
        }
    }
}