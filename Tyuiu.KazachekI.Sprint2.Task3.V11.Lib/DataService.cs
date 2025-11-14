using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KazachekI.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 0)
            {
                double fraction = (x - 15) / (x - 19);
                y = x + Math.Pow(fraction, x);
            }
            else if (x == 0)
            {
                y = 12;
            }
            else if (x > -15)
            {
                y = Math.Pow(1 + 1.0 / (x * x), x);
            }
            else
            {
                y = 11 * x - 1.0 / x;
            }

            return Math.Round(y, 3);
        }
    }
}