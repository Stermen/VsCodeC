// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Неккоректное число!");
    return;
}
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        checked 
        {
            sum = sum * i;
        }
    }
    return sum;
}