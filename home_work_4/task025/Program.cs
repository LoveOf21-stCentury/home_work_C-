/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("write your num a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("write your num b: ");
double b = double.Parse(Console.ReadLine());

double Change(double a, double b)
{
    double r = Math.Pow(a, b);
    return r;
}

Console.WriteLine(Change(a, b));

