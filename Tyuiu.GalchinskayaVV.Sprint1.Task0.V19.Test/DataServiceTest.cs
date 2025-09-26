using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint1.Task0.V19.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var result = ds.Calculate();
            var wait = 10.0; // 4/2=2, 2*5=10, 10/(3+2)=10/5=2, 2*5=10

            Assert.AreEqual(wait, result);
        }
    }
}