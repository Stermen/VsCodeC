// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool Weekend(int number)
{
    if (number>5)
    {
        return true;
    }
    return false;
}

bool WeekDay(int number)
{
    if (number>0 && number<=7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}
if  (WeekDay(number))
{
    if (Weekend(number))
    {
        Console.WriteLine("УРА!!!! ВЫХОДНОЙ");
    }
    else
    {
        Console.WriteLine("Опять работать");
    }
}

// Я потом доработаю или вообще переделаю код. Просто пока устраиваюсь на работу(