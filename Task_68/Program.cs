/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

int Ackerman(int m, int n)
{
    while (n!=0);
    if (m==0) return m = 1;
    else
    {
        m = Ackerman(n, m-1);
        n=m-1;
    }
    return m+1;
}

Console.WriteLine(Ackerman(2, 0));