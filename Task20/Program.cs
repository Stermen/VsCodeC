// 20. Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве 

Console.WriteLine("Введите координату x первую");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первую");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x вторую");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y вторую");
int y2 = Convert.ToInt32(Console.ReadLine());



double result = DistanceCor(x1, y1, x2, y2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);


double DistanceCor(int ax, int ay, int bx, int by)
{
    double sumCathetus = (bx - ax)*(bx - ax) + (by - ay)*(by - ay);
    double d = Math.Sqrt(sumCathetus);
    return d;
}