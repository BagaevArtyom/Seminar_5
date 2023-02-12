/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GetArray(int size,  int minValue, int maxValue)
{
    int[] massiv = new int[size];
    for (int i=0; i<size; i++)
    {
        massiv[i] = new Random().Next(minValue, maxValue+1);
    }
    return massiv;
}

int Chetnye(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i]) %2 == 0) count++;
    }
    return count;
} 

Console.Clear();
int[] array = GetArray(20, -999, 999);
Console.WriteLine(String.Join(" ", array));
int result = Chetnye(array);
Console.WriteLine($"{result}");
