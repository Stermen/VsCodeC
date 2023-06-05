// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x первую");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первую");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первую");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x вторую");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y вторую");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z вторую");
int z2 = Convert.ToInt32(Console.ReadLine());


double result = DistanceCor(x1, y1, z1, x2, y2, z2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);


double DistanceCor(int ax, int ay, int az, int bx, int by, int bz)
{
    double sumCathetus = (bx - ax)*(bx - ax) + (by - ay)*(by - ay)+(bz - az)*(bz - az);
    double d = Math.Sqrt(sumCathetus);
    return d;
}