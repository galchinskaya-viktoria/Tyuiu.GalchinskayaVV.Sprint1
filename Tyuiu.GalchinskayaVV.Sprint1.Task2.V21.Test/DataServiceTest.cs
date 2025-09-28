using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint1.Task2.V21.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 3;
            var result = ds.Calculate(x, y);
            var wait = 18;
            Assert.AreEqual(wait, result);
        }
    }
}