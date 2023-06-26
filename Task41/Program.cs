// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3




int ConvertedString(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ConvertedString("Введите элемент ");
    }
    return arr;
}

int PositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) count++;
    }
    return count;
}

int lenght= ConvertedString("Введите количество элементов: ");
int[] array;
array=InputArray(lenght);
Console.WriteLine($"Количество чисел больше 0 - {PositiveNumber(array)}");
