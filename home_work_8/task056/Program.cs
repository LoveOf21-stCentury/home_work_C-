/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
};

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[] SumNumbAndFindMin(int[,] array, int row, int column)
{
    int[] SumR = new int[row];

    for (int i = 0; i < row; i++)
    {
        SumR[i] = 0;
        for (int j = 0; j < column; j++)
        {
            SumR[i] += array[i, j];
        }
        /* System.Console.Write($"{SumR[i]} "); */

    }

    int index = 0;
    int value = SumR[index];
    for (int x = 1; x < SumR.Length; x++)
    {
        if (SumR[x] < value)
        {
            value = SumR[x];
            index = x;
        }
    }
    System.Console.Write($"Minimum is: {index + 1}-rd row");
    return SumR;
}

void Task056()
{
    int column = 4;
    int row = 4;
    int[,] array = new int[row, column];
    FillArray(array);
    Print(array);
    SumNumbAndFindMin(array, row, column);

}
Task056();