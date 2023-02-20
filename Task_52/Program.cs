/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] GetArray(int y, int x)
{
    int[,] result = new int[y, x];
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] NumberSum(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    int x = 0;
    int j=0;
    while (j < inArray.GetLength(1))
    {
        for (int i=0; i<inArray.GetLength(0); i++)
        {
            result[x] = result[x] + inArray[i, j];
        }
        result[x] = result[x]/inArray.GetLength(0);
        j++;
        x++;
    }
    return result;
}





Console.WriteLine("Введите кол-во строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int b = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(a, b);
PrintArray(array);
double[] total = NumberSum(array);
Console.WriteLine(String.Join(" ", total));
