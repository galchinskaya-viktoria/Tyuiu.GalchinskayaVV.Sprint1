using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateFirstDay()
        {
            DataService ds = new DataService();
            int k = 1; // 1 января - понедельник
            var result = ds.Calculate(k);
            var wait = 1;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateSeventhDay()
        {
            DataService ds = new DataService();
            int k = 7; // 7 января - воскресенье
            var result = ds.Calculate(k);
            var wait = 7;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateEighthDay()
        {
            DataService ds = new DataService();
            int k = 8; // 8 января - понедельник
            var result = ds.Calculate(k);
            var wait = 1;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateMiddleYear()
        {
            DataService ds = new DataService();
            int k = 150; // случайный день в середине года
            var result = ds.Calculate(k);
            var wait = (150 - 1) % 7 + 1; // 149 % 7 = 2, +1 = 3 (среда)
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateLastDay()
        {
            DataService ds = new DataService();
            int k = 365; // 31 декабря
            var result = ds.Calculate(k);
            var wait = (365 - 1) % 7 + 1; // 364 % 7 = 0, +1 = 1 (понедельник)
            Assert.AreEqual(wait, result);
        }
    }
}