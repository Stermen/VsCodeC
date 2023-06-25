// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] CreateArrayFibonacci(int size, int first, int second)
{
    int[] array = new int[size];
    array[0] = first;
    array[1] = second;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (length - i > 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] array = CreateArrayFibonacci(10, 0, 1);
PrintArray(array);
