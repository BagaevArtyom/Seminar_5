/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();

double DoubleRandom(int min, int max) //Случайное дробное число от 0 до 10
{
    double total = 0;
    double randomDouble = new Random().NextDouble();
    int i = new Random().Next(min, max);
    total = randomDouble + i;
    return total;
}

double[] randomArray(int size, int min, int max)  // создаем массив
{
    double[] array= new double[size];
    for (int i=0; i<size; i++) array[i] = DoubleRandom(min, max);
    return array;
}

double diffMaxMin(double[] array) // Находим разницу между макс и мин
{
    double min = array[0], max = array[0], total1 = 0;
    for (int i = 1; i<array.Length; i++)
    {
        if (array[i]<min) min = array[i];
        else if (array[i]>max) max = array[i];
    }
    total1= max - min;
    return total1;
}

double[] TestArray = randomArray(10, 0, 10);
Console.WriteLine(String.Join(" ", TestArray));
double Total2 = diffMaxMin(TestArray);
Console.WriteLine($"Разница макс и мин равна: {Total2}");




