using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public double ConvertVerstToKm(double verst)
        {
            // 1 верста = 1066.8 м = 1.0668 км
            double metersInVerst = 1066.8;
            double kilometers = verst * metersInVerst / 1000;
            return Math.Round(kilometers, 3);
        }

        public double VerstsToKilometers(double verst)
        {
            throw new NotImplementedException();
        }
    }
}