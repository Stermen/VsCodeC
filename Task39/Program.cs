﻿// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
}

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        // int temp = arr[i];
        // arr[i] = arr[arr.Length - 1 - i];
        // arr[arr.Length - 1 - i] = temp;
        Swap(arr, i, arr.Length - 1 - i);
    }
}

void Swap(int[] arr, int elem1, int elem2)
{
    int temp = arr[elem1];
    arr[elem1] = arr[elem2];
    arr[elem2] = temp;
}

int[] array = CreateArrayRndInt(5,0, 9);
PrintArray(array);
Console.WriteLine();
ReverseArray(array);
PrintArray(array);

Console.WriteLine();
Array.Reverse(array);
PrintArray(array);
