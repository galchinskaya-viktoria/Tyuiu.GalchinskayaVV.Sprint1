using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            // 1 января - понедельник (день недели = 1)
            // k-й день года, находим день недели
            // (k - 1) % 7 + 1 - так как 1 января = 1 (понедельник)
            return (k - 1) % 7 + 1;
        }
    }
}