// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (number<1)
{
    Console.WriteLine("Некорретный ввод");
}
else while (i <= number)
{
    Console.WriteLine($"{i} ");
    i = i + 2;
}