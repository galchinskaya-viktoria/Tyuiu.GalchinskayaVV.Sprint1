using tyuiu.cources.programming.interfaces.Sprint1;
using System;
using System.Linq;

namespace Tyuiu.GalchinskayaVV.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0 && words[i].Length > 2)
                {
                    int middleIndex = words[i].Length / 2;
                    words[i] = words[i].Remove(middleIndex, 1);
                }
            }

            return string.Join(" ", words);
        }
    }
}