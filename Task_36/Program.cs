/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GetArray(int size,  int minValue, int maxValue)
{
    int[] massiv = new int[size];
    for (int i=0; i<size; i++)
    {
        massiv[i] = new Random().Next(minValue, maxValue+1);
    }
    return massiv;
}

int sum(int[] array)
{
    int sum2 = 0;
    for (int i=1; i<array.Length; i+=2)
    {
    sum2= sum2+array[i];
    }
    return sum2;
}

Console.Clear();
int[] array = GetArray(6, 0, 10);
Console.WriteLine(String.Join(" ", array));
int result = sum(array);
Console.WriteLine($"{result}");