// 16.Напишите программу, которая принимает на вход два числа и проверяет, является ли одно чило квадратом другого.
// 5, 25 -> yes
// -4, 16 -> yes
// 8, 9 -> no


bool IsSquareTwoNumbers(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}

Console.WriteLine("Введите первое чило");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило");
int number2 = Convert.ToInt32(Console.ReadLine());

bool myresult = IsSquareTwoNumbers(number1, number2);
Console.WriteLine(myresult ? "Yes" : "No");