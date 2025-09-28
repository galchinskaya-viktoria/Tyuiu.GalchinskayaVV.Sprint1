using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint1.Task4.V19.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 3.0;
            double y = 2.0;
            var result = ds.Calculate(x, y);
            var wait = 5.0; // (3 + 2) / |3 - 2| = 5 / 1 = 5

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithNegative()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double y = -2.0;
            var result = ds.Calculate(x, y);
            var wait = -1.0; // (1 + (-2)) / |1 - 2| = (-1) / 1 = -1

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithFractions()
        {
            DataService ds = new DataService();

            double x = 2.5;
            double y = 1.5;
            var result = ds.Calculate(x, y);
            var wait = 8.0; // (2.5 + 1.5) / |2.5 - 2| = 4 / 0.5 = 8

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithZeroY()
        {
            DataService ds = new DataService();

            double x = 4.0;
            double y = 0.0;
            var result = ds.Calculate(x, y);
            var wait = 2.0; // (4 + 0) / |4 - 2| = 4 / 2 = 2

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateRounded()
        {
            DataService ds = new DataService();

            double x = 3.7;
            double y = 1.3;
            var result = ds.Calculate(x, y);
            var wait = 2.941; // (3.7 + 1.3) / |3.7 - 2| = 5 / 1.7 ≈ 2.941176 → округляем до 2.941

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void InvalidCalculateDivideByZero()
        {
            DataService ds = new DataService();

            double x = 2.0;
            double y = 5.0;
            ds.Calculate(x, y); // (2 + 5) / |2 - 2| = 7 / 0 → деление на ноль
        }
    }
} 
