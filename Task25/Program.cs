// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int step = numberOne;

for (int i = 1; i < numberTwo; i++)
{
    step = step * numberOne;
}
if (numberOne<=0 || numberTwo<=0)
{
    Console.WriteLine("Некорретный ввод");
}
else Console.WriteLine($"{numberOne} в степени {numberTwo} равно: {step}"); 
