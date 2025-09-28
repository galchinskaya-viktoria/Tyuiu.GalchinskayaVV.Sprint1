using Tyuiu.GalchinskayaVV.Sprint1.Task4.V19.Lib;

Console.Title = "Спринт #1 | Выполнил: Гальчинская В. В. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Сlass Math                                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет результат по формуле (x + y) / |x - 2| и печатает его.        *");
Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение X:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

try
{
    DataService ds = new DataService();
    var result = ds.Calculate(x, y);
    Console.WriteLine($"Результат вычисления по формуле (x + y) / |x - 2| = {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}

Console.ReadKey();