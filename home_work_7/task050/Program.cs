/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

string Input(string text)
{
    Console.Write($"{text} ");
    return Console.ReadLine();
}

int[,] FillDoubleArray(int m, int n)
{
    int[,] arr = new int[m, n];

    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
    return arr;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        System.Console.WriteLine();
    }
}

int[,] UserInput(int[,] arr)
{
    int UserNumb = Convert.ToInt32(Input("Your num: "));
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i] == UserNumb && arr[j] == UserNumb)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write($"{arr[i, j]} ");
        }
    System.Console.WriteLine();
    return arr;
}

    Print(FillDoubleArray(3, 4));

void Task050()
{
    UserInput(arr);
}

Task050();

