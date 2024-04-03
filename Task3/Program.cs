/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы. */

void Function(int[] arr, int i)
{
    if (i >= 0)
    {
        Console.Write($"{arr[i]} ");
        Function(arr, i - 1);

    }
}

int[] array = { 1, 5, 8, 3, 34, 12, 7, 9 };
Function(array, array.Length - 1);