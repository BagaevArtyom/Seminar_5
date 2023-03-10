/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */



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

Console.WriteLine("Введите кол-во строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int b = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(a, b);
PrintArray(array);
