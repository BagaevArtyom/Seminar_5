/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();

Console.WriteLine("Введите количество числел: ");
int countNumbers = int.Parse(Console.ReadLine()!);

int[] GetArray(int size)
{
    int[] array = new int[size]; 
    for (int i=0; i<array.Length; i++)
    {
         Console.WriteLine("Введите число: ");
         array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int UpperNull(int[] array1)
{
    int count = 0;
    int[] array = new int[array1.Length];
    for (int i=0; i<array1.Length; i++)
    if (array1[i]>0)
    {
        count++;
    }
    return count;
}

int[] newArray = GetArray(countNumbers);
Console.WriteLine(String.Join(", ", newArray));
int positivNumber = UpperNull(newArray);
Console.WriteLine($"Количество чисел больше нуля: {positivNumber}");


