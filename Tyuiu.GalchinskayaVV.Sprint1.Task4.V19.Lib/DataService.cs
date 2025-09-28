using tyuiu.cources.programming.interfaces.Sprint1;
using System;
 
namespace Tyuiu.GalchinskayaVV.Sprint1.Task4.V19.Lib
{
    public class DataService : ISprint1Task4V19
    {
        public DataService()
        {
        }

        public double Calculate(double x, double y)
        {
            double denominator = Math.Abs(x - 2);

            if (denominator == 0)
            {
                throw new DivideByZeroException("Знаменатель не может быть равен нулю");
            }

            double result = (x + y) / denominator;
            return Math.Round(result, 3);
        }
    }
}

