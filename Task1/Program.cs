/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы. */

void F(int m, int n)
{
    if (m != n)
    {
        if (m > n)
        {
            F(m - 1, n);
            System.Console.Write(m + " ");
        }
        else
        {

            F(m + 1, n);
            System.Console.Write(m + " ");

        }

    }
    else
    {
        System.Console.Write(m + " ");
    }

}

Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Результат: ");
F(m, n);