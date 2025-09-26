using Tyuiu.GalchinskayaVV.Sprint1.Task0.V19.Lib;

Console.Title = "Спринт #1 | Выполнил: Гальчинская В. В. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет выражение 4/2*5/(3+2)*5          *");
Console.WriteLine("* и печатает результат на экране.                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Выражение: 4/2*5/(3+2)*5");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
var result = ds.Calculate();
Console.WriteLine("Результат вычисления: " + result);
Console.ReadKey();