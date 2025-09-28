using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint1.Task6.V10.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteMiddleLetter()
        {
            DataService ds = new DataService();
            string value = "привет мир программа";
            var result = ds.DeleteMiddleLetter(value);
            var wait = "приет мир программ";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidDeleteMiddleLetterWithOddLength()
        {
            DataService ds = new DataService();
            string value = "слово текст";
            var result = ds.DeleteMiddleLetter(value);
            var wait = "слоо текст";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidDeleteMiddleLetterWithEvenLength()
        {
            DataService ds = new DataService();
            string value = "четные слова остаются";
            var result = ds.DeleteMiddleLetter(value);
            var wait = "четные слова остаются";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidDeleteMiddleLetterShortWords()
        {
            DataService ds = new DataService();
            string value = "а я он";
            var result = ds.DeleteMiddleLetter(value);
            var wait = "а я он";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidDeleteMiddleLetterEmptyString()
        {
            DataService ds = new DataService();
            string value = "";
            var result = ds.DeleteMiddleLetter(value);
            var wait = "";
            Assert.AreEqual(wait, result);
        }
    }
}