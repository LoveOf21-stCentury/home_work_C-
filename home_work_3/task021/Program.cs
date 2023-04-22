/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
double Dist()
{
    Console.Write("give me X:\t");
    double x1 = double.Parse(Console.ReadLine());
    Console.Write("give me Y:\t");
    double y1 = double.Parse(Console.ReadLine());
    Console.Write("give me Z:\t");
    double z1 = double.Parse(Console.ReadLine());
    Console.Write("give me X:\t");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("give me Y:\t");
    double y2 = double.Parse(Console.ReadLine());
    Console.Write("give me Z:\t");
    double z2 = double.Parse(Console.ReadLine());
    double r = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return r;
}
Console.Write($"distanse is {Dist()}");

