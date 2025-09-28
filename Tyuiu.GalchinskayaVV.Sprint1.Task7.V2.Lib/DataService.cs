using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task7.V2.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Sin(x) + Math.Cos(y);
            double denominator = Math.Cos(x) - Math.Sin(y);
            double fraction = numerator / denominator;
            double tangent = Math.Tan(x * y);

            double result = fraction * tangent;
            return Math.Round(result, 3);
        }
    }
}