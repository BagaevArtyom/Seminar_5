/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] GetArray(int y, int x, int w)
{
    int[,,] result = new int[y, x, w];
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            for (int z = 0; z < w; z++)
            {                   
                result[i, j, z] = new Random().Next(10, 99);                
                Console.Write($"{result[i,j,z]} ({i}, {j}, {z})   ");
                
            }            
        }
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во ячеек в глубину: ");
int c = int.Parse(Console.ReadLine()!);
GetArray(a, b, c);

