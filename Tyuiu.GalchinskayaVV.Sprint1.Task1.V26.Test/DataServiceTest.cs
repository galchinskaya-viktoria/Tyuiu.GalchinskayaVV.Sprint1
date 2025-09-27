using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint1.Task1.V26.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 2.0;
            double y = 3.0;
            var result = ds.Calculate(x, y);
            var wait = 2.0; // 5*2/(2+3) = 10/5 = 2

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithZero()
        {
            DataService ds = new DataService();

            double x = 0.0;
            double y = 1.0;
            var result = ds.Calculate(x, y);
            var wait = 0.0; // 5*0/(2+1) = 0/3 = 0

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithFractions()
        {
            DataService ds = new DataService();

            double x = 1.5;
            double y = 0.5;
            var result = ds.Calculate(x, y);
            var wait = 3.0; // 5*1.5/(2+0.5) = 7.5/2.5 = 3

            Assert.AreEqual(wait, result);
        }
    }
}