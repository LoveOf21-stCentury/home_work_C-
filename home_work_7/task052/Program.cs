/*  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] CreateTwoArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    return array;
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        System.Console.WriteLine();
    }
}

int FindMiddleOfArethMean(int[,] array)
{
    double[] res = { 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            res[i] += array[i, j];

        res[i] /= n;
    }
    return res;
}

Print(CreateTwoArray(3, 4));
FindMiddleOfArethMean(array);
