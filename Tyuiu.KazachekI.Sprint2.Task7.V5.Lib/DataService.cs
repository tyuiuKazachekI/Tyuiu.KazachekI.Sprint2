using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KazachekI.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x < 0)
                return false;

            double lowerBound = x * x;

            double upperBound = Math.Exp(-x);
            bool isAboveParabola = y >= lowerBound;
            bool isBelowExponent = y <= upperBound;

            return isAboveParabola && isBelowExponent;
        }
    }
}