using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint1.Task1.V21.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 5.0;
            double y = 3.0;
            var result = ds.Calculate(x, y);
            var wait = 15.0; // 5 * 3 = 15

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithZero()
        {
            DataService ds = new DataService();

            double x = 0.0;
            double y = 10.0;
            var result = ds.Calculate(x, y);
            var wait = 0.0; // 0 * 10 = 0

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithLargeNumbers()
        {
            DataService ds = new DataService();

            double x = 25.0;
            double y = 40.0;
            var result = ds.Calculate(x, y);
            var wait = 1000.0; // 25 * 40 = 1000

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateSquare()
        {
            DataService ds = new DataService();

            double x = 7.0;
            double y = 7.0;
            var result = ds.Calculate(x, y);
            var wait = 49.0; // 7 * 7 = 49

            Assert.AreEqual(wait, result);
        }
    }
}
