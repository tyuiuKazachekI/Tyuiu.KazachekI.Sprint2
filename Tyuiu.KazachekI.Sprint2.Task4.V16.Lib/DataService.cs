using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KazachekI.Sprint2.Task4.V16.Lib
{
    public class DataService : ISprint2Task4V16
    {
        public double Calculate(double x, double y)
        {
            double result;

            if (2 * x < 2 * y)
            {
                result = Math.Pow(1 + 1.0 / (y * y), x);
            }
            else
            {
                result = y - 1.0 / (x * x);
            }

            return Math.Round(result, 3);
        }
    }
}