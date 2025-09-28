using Tyuiu.GalchinskayaVV.Sprint1.Task5.V6.Lib;

Console.Title = "Спринт #1 | Выполнил: Гальчинская В. В. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение      *");
Console.WriteLine("* 1,2,...,7 в зависимости от того, на какой день недели приходится k-й   *");
Console.WriteLine("* день невисокосного года, в котором 1 января – понедельник.             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите номер дня года (от 1 до 365):");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
var result = ds.Calculate(k);

string dayOfWeek = result switch
{
    1 => "понедельник",
    2 => "вторник",
    3 => "среда",
    4 => "четверг",
    5 => "пятница",
    6 => "суббота",
    7 => "воскресенье",
    _ => "неизвестно"
};

Console.WriteLine($"{k}-й день года - это {dayOfWeek} (день недели: {result})");
Console.ReadKey();