// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] ArrayCopy(int[] arr)
{
    int[] newArr=new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i]=arr[i];
    }
    return newArr;
}

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
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

int[] array = CreateArray(8, 0, 9);
PrintArray(array);
int[] newArray=ArrayCopy(array);
newArray[0]=33;
PrintArray(newArray);
