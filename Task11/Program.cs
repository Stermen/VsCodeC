// 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру это числа.
// 456 -> 46
// 782 -> 98
// 918 -> 98

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit * 10 + secondDigit;
}
int number = new Random().Next(100, 1000);
Console.WriteLine($"Трехзначное число {number}");
int DuoDigit = DeleteSecondDigit(number);
Console.WriteLine($"Двузначное число {DuoDigit} ");
