//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в слечайном порядке

//int [] array = new Random().Next();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);