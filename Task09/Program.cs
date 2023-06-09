﻿// 9. Напишите прогграмму, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

//Первый способ
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
int num1 = number / 10;
int num2 = number % 10;
if (num1 > num2)
    Console.WriteLine($"Наибольшие цифра числа -> {num1}");
else
    Console.WriteLine($"Наибольшие цифра числа -> {num2}");

//Второй способ
int firstDigit = number / 10;
int secondDigit = number % 10;
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшие цифра числа -> {maxDigit}");
