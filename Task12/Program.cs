// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если первое число не кратно второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое чило");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе чило");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Remain(num1, num2);
string printLine = result == 0 ? "Кратно" : $"не ркатно, остаток {result}";
Console.WriteLine(printLine);

int Remain(int number1, int number2)
{
    int res = number1 % number2;
    return res;
}

