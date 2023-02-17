/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double GetNumber()  // Создаем псевдослучайное вещественное число в интервале
{
    double number = 0;
    double randomDouble = new Random().NextDouble();
    int randomInt = new Random().Next(0, 10);
    number = randomDouble + randomInt;
    return number;
}

double[,] GetArray(int y, int x)
{
    double[,] result = new double[y, x];
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            result[y, x] = GetNumber();
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);
double[,] newarray = GetArray(m, n);
PrintArray(newarray);