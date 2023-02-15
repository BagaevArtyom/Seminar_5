/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();
int input()
{
    Console.WriteLine("Две прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2");
    Console.WriteLine("Введите значение b1;");
    int b1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение k1;");
    int k1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение b2;");
    int b2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение k2;");
    int k2 = int.Parse(Console.ReadLine()!);
    return ;
}


int crossPoint(int b1, int k1, int b2, int k2)
{
    int y=0;
    int x=0;
   if (y-y == (k1*x+b1)-(k2*x+b2))
    {
        y = k1*(y-b2)/k2+b1;   //  y = k1 * x + b1, y = k2 * x + b2
        x = (y-b2)/k2;
        Console.WriteLine($"Прямые пересекаются в точке: {x}, {y}");
    }
    else
    {
        Console.WriteLine("Прямые не пересекаются");
    }
    return y;
}

crossPoint(input);