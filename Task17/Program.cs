// 17. Напишите программу, которая принимает на вход координаты точки X и Y, причем X не равно 0 и Y не равно 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координаты точки");
Console.Write("X:");
int xCor = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int yCor = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCor,yCor);
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти -> {quarter}" 
                : "Введены некорректные координаты";
Console.WriteLine(result);
int Quarter(int x, int y)
{
    if (x > 0 && y > 0 ) return 1;
    if (x < 0 && y > 0 ) return 2;
    if (x < 0 && y < 0 ) return 3;
    if (x > 0 && y < 0 ) return 4;
    return 0;
}
