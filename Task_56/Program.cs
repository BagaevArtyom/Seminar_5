/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


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

int[] SumInRow(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)];
    int x = 0;
    int j=0;
    while (j < inArray.GetLength(0))
    {
        for (int i=0; i<inArray.GetLength(1); i++)
        {
            result[x] = result[x] + inArray[j, i];
        }
        
        j++;
        x++;
    }
    return result;
}

int NumberMax(int[] inArray)
{
    int count =0;
    int max =0;
    int i=0;
    while (i<inArray.Length)
    {
        if (max<(inArray[i]))
        {
            max=inArray[i];
            count++;
        }
        else
        {
            i++;
        }      
    }
    Console.WriteLine($"Максимальное значение: {max}");
    Console.WriteLine($"Строка номер: {count}");

   return count;
} 

Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int b = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(a, b);
PrintArray(array);
Console.WriteLine("Сумма в каждой строке:");
int[] total = SumInRow(array);
Console.WriteLine(String.Join(" ", total));
NumberMax(total);

