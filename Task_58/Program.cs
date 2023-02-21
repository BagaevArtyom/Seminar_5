/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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




int[,] Array1xArray2(int[,] inArray1, int[,]inArray2)
{
    int row1 = inArray1.GetLength(0);
    int col1 = inArray1.GetLength(1);
    int row2 = inArray2.GetLength(0);
    int col2 = inArray2.GetLength(1);
    int[,] result=new int[row1, col2];
    for (int i=0; i<row1; i++)
    {
        for (int j=0; j<col2; j++)
        {
            for (int h=0; h<row2; h++)
            {
                result[i, j] += inArray1[i, h]*inArray2[h, j];
            }
        }
    }
    return result;
} 

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите кол-во строк M1: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите кол-во столбцов M1: ");
    int b = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите кол-во строк M2: ");
    int c = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите кол-во столбцов M2: ");
    int d = int.Parse(Console.ReadLine()!);
    int[,] array1 = GetArray(a, b);
    PrintArray(array1);
    Console.WriteLine("__________________________");
    int[,] array2 = GetArray(c, d);
    PrintArray(array2);
    if (b != c)
    {
        Console.WriteLine("Невозможно перемножить матрицы. Кол-во столбцов первой не равно кол-ву строк второй.");
        return;
    }
    Console.WriteLine("__________________________");
    int[,] result = Array1xArray2(array1, array2);
    PrintArray(result);
}

Main();




