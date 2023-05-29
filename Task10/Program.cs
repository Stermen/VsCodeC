// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) < 100 || Math.Abs(number) >= 1000)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    Console.WriteLine($"Число {number}");
    int secondDigital = number / 10 % 10;
    Console.WriteLine($"Второе число {secondDigital}");
}