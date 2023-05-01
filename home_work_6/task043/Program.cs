/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

const int coefficient = 0;
const int constant = 1;
const int x_coord = 0;
const int y_coord = 1;
const int line1 = 1;
const int line2 = 2;

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    System.Console.Write($"Dot of intersection of equations y = {lineData1[coefficient]} * x + {lineData1[constant]} and y = {lineData2[coefficient]} * x + {lineData2[constant]} ");
    System.Console.WriteLine($"haave coordinates ({coord[x_coord]}, {coord[y_coord]})");
}

double Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[coefficient] = Prompt($"Enter coefficient for {numberOfLine} straight >");
    lineData[constant] = Prompt($"Enter coefficient for {numberOfLine} straight >");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[x_coord] = (lineData1[constant] - lineData2[constant]) / (lineData2[coefficient] - lineData1[coefficient]);
    coord[y_coord] = lineData1[constant] * coord[x_coord] + lineData1[constant];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[coefficient] == lineData2[coefficient]) 
    {
        if (lineData1[constant] == lineData2[constant])
        {
            System.Console.WriteLine("Straight is completed");
            return false;
        }
        else
        {
            System.Console.WriteLine("Stright is paralel");
            return false;
        }
    }
    return true;
}








/* string Input(string text)
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

Task43(); */