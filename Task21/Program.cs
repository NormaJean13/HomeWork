// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки ");
Console.Write ("x: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write ("y: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write ("z: ");
double az = Convert.ToDouble(Console.ReadLine());
Console.Write ("x: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write ("y: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write ("z: ");
double bz = Convert.ToDouble(Console.ReadLine());


double Result (double ax1, double ay1, double bx1, double by1, double az1, double bz1)
{
    return Math.Sqrt((bx1 - ax1)*(bx1 - ax1) + (by1 - ay1)*(by1 - ay1) + (bz1 - az1)*(bz1 - az1));
}
double result = Result (ax, ay, bx, by, az, bz);
Console.WriteLine(Math.Round (result,2, MidpointRounding.ToZero));