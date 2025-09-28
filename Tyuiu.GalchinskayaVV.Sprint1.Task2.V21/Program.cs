using Tyuiu.GalchinskayaVV.Sprint1.Task2.V21.Lib;
 
Console.Title = "Спринт #1 | Выполнил: Гальчинская В. В. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Известны длины стороны прямоугольника. Вычислить площадь прямоугольника.*");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите длину первой стороны прямоугольника:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину второй стороны прямоугольника:");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
var result = ds.Calculate(x, y);
Console.WriteLine("Площадь прямоугольника = " + result);
Console.ReadKey();