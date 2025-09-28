using Tyuiu.GalchinskayaVV.Sprint1.Task2.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Гальчинская В. В. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
        Console.WriteLine("* вычисляет площадь прямоугольника и печатает результат на экране.       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите длину первой стороны прямоугольника (целое число):");
        int side1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите длину второй стороны прямоугольника (целое число):");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        var result = ds.Calculate(side1, side2);
        Console.WriteLine("Площадь прямоугольника = " + (int)result);
        Console.ReadKey();
    }
}