﻿/*  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

void CreateTwoArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
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

/* void FindMiddleOfArethMean(int[,] array)
{
    double[] res = { 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res+= array[i, j];
            res = res / array[j];

        }
    }
    Console.WriteLine(res);
    System.Console.WriteLine();
} */

void Task52()
{
    int sizeA = 3;
    int sizeB = 4;
    int[,] array = new int[sizeA, sizeB];
    CreateTwoArray(array);
    Print(array);
    //FindMiddleOfArethMean(array);
}

Task52();