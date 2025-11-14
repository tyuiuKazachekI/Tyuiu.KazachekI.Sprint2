using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KazachekI.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            switch (value)
            {
                case 12:
                case 1:
                case 2:
                    return "зима";

                case 3:
                case 4:
                case 5:
                    return "весна";

                case 6:
                case 7:
                case 8:
                    return "лето";

                case 9:
                case 10:
                case 11:
                    return "осень";

                default:
                    return "Введен неверный номер месяца";
            }
        }
    }
}