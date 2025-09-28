using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint1.Task7.V2.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double y = 2.0;
            var result = ds.Calculate(x, y);

            // Проверяем вычисления вручную:
            // sin(1) ≈ 0.8415, cos(2) ≈ -0.4161
            // числитель = 0.8415 + (-0.4161) = 0.4254
            // cos(1) ≈ 0.5403, sin(2) ≈ 0.9093
            // знаменатель = 0.5403 - 0.9093 = -0.369
            // дробь = 0.4254 / (-0.369) ≈ -1.1528
            // tg(1*2) = tg(2) ≈ -2.185
            // результат = -1.1528 * (-2.185) ≈ 2.518
            // округляем до 3 знаков: 2.518

            Assert.AreEqual(2.518, result, 0.001);
        }

        [TestMethod]
        public void ValidCalculateWithZero()
        {
            DataService ds = new DataService();

            double x = 0.0;
            double y = 0.0;
            var result = ds.Calculate(x, y);

            // sin(0)=0, cos(0)=1
            // числитель = 0 + 1 = 1
            // знаменатель = 1 - 0 = 1
            // дробь = 1/1 = 1
            // tg(0) = 0
            // результат = 1 * 0 = 0

            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void ValidCalculateWithFractions()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.5;
            var result = ds.Calculate(x, y);

            // Проверяем что результат округлен до 3 знаков
            Assert.AreEqual(0.279, result, 0.001);
        }

        [TestMethod]
        public void ValidCalculateNegativeValues()
        {
            DataService ds = new DataService();

            double x = -1.0;
            double y = 1.0;
            var result = ds.Calculate(x, y);

            // Проверяем вычисления с отрицательными значениями
            Assert.AreEqual(-0.302, result, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void InvalidCalculateDivideByZero()
        {
            DataService ds = new DataService();

            // Подбираем значения, при которых знаменатель будет равен 0
            // cos(x) - sin(y) = 0
            double x = Math.PI / 4; // 45 градусов
            double y = Math.PI / 4; // 45 градусов
            ds.Calculate(x, y);
        }
    }
}