using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint1.Task3.V7.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertVerstToKm()
        {
            DataService ds = new DataService();

            double verst = 100.0;
            var result = ds.ConvertVerstToKm(verst);
            var wait = 106.68; // 100 * 1066.8 / 1000 = 106.68

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidConvertOneVerstToKm()
        {
            DataService ds = new DataService();

            double verst = 1.0;
            var result = ds.ConvertVerstToKm(verst);
            var wait = 1.067; // 1 * 1066.8 / 1000 = 1.0668 → округляем до 1.067

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidConvertZeroVerstToKm()
        {
            DataService ds = new DataService();

            double verst = 0.0;
            var result = ds.ConvertVerstToKm(verst);
            var wait = 0.0; // 0 * 1066.8 / 1000 = 0

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidConvertFractionalVerstToKm()
        {
            DataService ds = new DataService();

            double verst = 2.5;
            var result = ds.ConvertVerstToKm(verst);
            var wait = 2.667; // 2.5 * 1066.8 / 1000 = 2.667

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidConvertLargeVerstToKm()
        {
            DataService ds = new DataService();

            double verst = 1000.0;
            var result = ds.ConvertVerstToKm(verst);
            var wait = 1066.8; // 1000 * 1066.8 / 1000 = 1066.8

            Assert.AreEqual(wait, result);
        }
    }
}