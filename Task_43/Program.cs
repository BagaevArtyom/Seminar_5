/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

void main()
{
    Console.WriteLine("Две прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2");
    Console.WriteLine("Введите значение b1;");
    double b1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение k1;");
    double k1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение b2;");
    double b2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение k2;");
    double k2 = int.Parse(Console.ReadLine()!);
    double x = (b1-b2)/(k1-k2);
    double y = k2*x+b2;
    if (k1 != k2)
    {
    Console.WriteLine($"Прямые пересекаются в точке: {x}  {y}");
    }
    else
    {
        Console.WriteLine("Прямые не пересекаются.");
    }
}

main();