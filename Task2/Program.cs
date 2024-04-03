/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. */

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return A(m - 1, 1);
    }
    else
    {
        return A(m - 1, A(m, n - 1));
    }
}

Console.WriteLine("Введите значение m для функции Аккермана: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n для функции Аккермана: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Значение функции Аккермана: ");
Console.WriteLine(A(m, n));