/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
 в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int FindSumMtoN(int m, int n)
{
    
    if (m == n) return m;
    else
    {
        return n+FindSumMtoN(m, n-1);
    }
}
Console.Clear();
Console.WriteLine(FindSumMtoN(1, 15));