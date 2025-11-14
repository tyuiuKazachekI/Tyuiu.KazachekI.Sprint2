using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KazachekI.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x == 2 && y >= 9 && y <= 11) return true;
            if (x == 3 && y >= 3 && y <= 5) return true;
            if (x == 4 && y >= 3 && y <= 5) return true;
            if (x == 5 && y >= 3 && y <= 9) return true;
            if (x == 6 && y >= 3 && y <= 13) return true;
            if (x == 7 && y >= 3 && y <= 14) return true;
            if (x == 8 && (y == 6 || y == 9 || y == 12 || y == 13)) return true;
            if (x == 9 && ((y >= 6 && y <= 9) || y == 12 || y == 13)) return true;
            if (x == 10 && y >= 6 && y <= 9) return true;
            if (x == 11 && y >= 3 && y <= 9) return true;
            if (x == 12 && y >= 7 && y <= 9) return true;

            return false;
        }
    }
}