using tyuiu.cources.programming.interfaces.Sprint1;
using System;
 
namespace Tyuiu.GalchinskayaVV.Sprint1.Task2.V21.Lib
{
    public class DataService : ISprint1Task2V21
    {
        public DataService()
        {
        }

        public int Calculate(int x, int y)
        {
            return x * y;
        }

        public int CalculateRectangleSquare(int value, int valueTwo)
        {
            throw new NotImplementedException();
        }

        public double ConvertAngleToRad(int value)
        {
            throw new NotImplementedException();
        }
    }
}