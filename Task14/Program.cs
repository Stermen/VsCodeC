﻿// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> no
// 46 -> no
// 161 -> yes

bool DevidedTwoDigit(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}
Console.WriteLine("Введите число");
int number= Convert.ToInt32(Console.ReadLine());
bool myresult = DevidedTwoDigit(number, 7, 23);
Console.WriteLine(myresult ? "Кратно":"Не кратно");