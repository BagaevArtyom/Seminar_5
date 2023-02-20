/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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


int[,] SortedArray(int[,] inArray)
{
    
    
    int[,] newArray = new int[inArray.GetLength(0), inArray.GetLength(1)];   
    int temp;
    int i = 0;     

    while (i<inArray.GetLength(0))
        {
            for(int j = 0; j< inArray.GetLength(1)-1; j++)
            {
                for (int x = j+1; x<inArray.GetLength(1); x++)
                {
                    if (inArray[i, j] < inArray[i, x])
                    {
                        temp = inArray[i, j];
                        inArray[i, j] = inArray[i, x];
                        inArray[i, x] = temp;
                    }
                }

            }
            i++;
        }
        return newArray;
}

Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int b = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(a, b);
PrintArray(array);
Console.WriteLine("Упорядочили строки по убыванию:");
SortedArray(array);
PrintArray(array);