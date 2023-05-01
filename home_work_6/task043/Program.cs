/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
string Input(string text)
{
    Console.Write($"{text} ");
    return Console.ReadLine();
}

void FillCoordinate(double[] numbers)
{
    numbers[0] = Convert.ToInt32(Input($"Write k1: "));
    numbers[1] = Convert.ToInt32(Input($"Write b1: "));
    numbers[2] = Convert.ToInt32(Input($"Write k2: "));
    numbers[3] = Convert.ToInt32(Input($"Write b2: "));
}

void Paralel(double[] coordinate)
{
    if (coordinate[0] == coordinate[2])
    {
        System.Console.WriteLine("it's paralel. Decision doesn't exist.");
    }
    else
    {
        double coordinataX = (coordinate[3] - coordinate[1] / coordinate[0] - coordinate[2]);
        double coordinataY = coordinate[0] * coordinataX + coordinate[1];
        System.Console.WriteLine($"Coordinate strigth of X = {Math.Round(coordinataX, 1)} and Y = {Math.Round(coordinataY, 1)}");

    }
}

void Task43()
{
    double[] coordinate = new double[4];
    FillCoordinate(coordinate);
    Paralel(coordinate);
}

Task43();