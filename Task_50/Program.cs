/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 */

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

int NumderByPosition(int[,] inArray)
{
    
    Console.WriteLine("Введите строку элемента: ");
    int k = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите столбец элемента: ");
    int l = int.Parse(Console.ReadLine()!);
        int ourNumber=0;
        if (k>0 && k<(inArray.GetLength(0))+1 && l>0 && l<(inArray.GetLength(1))+1)
        {
            ourNumber = inArray[k-1, l-1];
            
        }
        else
        {
           Console.WriteLine("Нет элемента с таким индексом");
        }
    return ourNumber;
} 

Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);
int[,] newarray = GetArray(m, n);
PrintArray(newarray);
int findnumber = NumderByPosition(newarray);
Console.WriteLine($"Число: {findnumber}");