using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KazachekI.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (g < 1 || m < 1 || m > 12 || n < 1 || n > 31)
                return "Неверная дата";

            int daysInMonth = GetDaysInMonth(m, g);

            if (n > daysInMonth)
                return "Неверная дата";

            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = g;

            if (nextDay > daysInMonth)
            {
                nextDay = 1;
                nextMonth++;

                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }

            string dayStr = nextDay.ToString("00");
            string monthStr = nextMonth.ToString("00");

            return $"{dayStr}.{monthStr}.{nextYear}";
        }

        private int GetDaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return 28; 
                default:
                    return 0;
            }
        }
    }
}