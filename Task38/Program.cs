// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayDouble(int size, int min, int max, int round)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rand.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (length - i > 1)
            Console.Write($"{arr[i]}| ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MaxArrayNumber(double[] arr, double max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

double MinArrayNumber(double[] arr, double min)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

double[] array = CreateArrayDouble(5, 10, 90, 2);
double minn = array[0];
double maxx = array[0];
double difference = MaxArrayNumber(array, maxx) - MinArrayNumber(array, minn);
PrintArrayDouble(array);
Console.WriteLine($"Разница между max = {MaxArrayNumber(array, maxx)} и min = {MinArrayNumber(array, minn)} равна {difference}");