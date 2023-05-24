using System.Runtime.InteropServices;
/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

void SortMarix(int[,] array, int row, int column)
{
    int minRow = 0;
    int temp = 0;
    for (int NumCol = 0; NumCol < column; NumCol++)
    {
        for (int NumRow = 0; NumRow < row - 1; NumRow++)
        {
            minRow = NumRow;
            for (int j = NumRow + 1; j < row; j++)
                if (array[j, NumCol] > array[minRow, NumCol])
                    minRow = j;
            temp = array[NumRow, NumCol];
            array[NumRow, NumCol] = array[minRow, NumCol];
            array[minRow, NumCol] = temp;
        }
    }

    /* int temp = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column - 1; j++)
        {
            for (int k = 0; k < column; k++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                    //int temp = array[i, j];
                    //array[i, j] = array[i, k];
                    //array[i, k] = temp;

                }
            }

        }
    } */

}

/*  int MinRow, Temp;
    for (int NumCol = 0; NumCol < col; NumCol++) {
        for (int NumRow = 0; NumRow < row - 1; NumRow++) { 
            MinRow = NumRow;
            for (int j = NumRow + 1; j < row; j++)
                if (arr[j][NumCol] > arr[MinRow][NumCol])
                   MinRow = j;
            Temp = arr[NumRow][NumCol];
            arr[NumRow][NumCol] = arr[MinRow][NumCol]; 
            arr[MinRow][NumCol] = Temp;
        }
    } */

/* void SortMarix(int[,] array)
{
    int temp = 0;
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1)-1; j++)
        {
            for (var k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] <= array[i, j + 1]) continue;

                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;

            }

        }
    }

} */

void Task054()
{
    int column = 5;
    int row = 4;
    int[,] array = new int[row, column];
    FillArray(array);
    Print(array);
    SortMarix(array, row, column);
    Print(array);
}
Task054();
/* int[,] array = new int[,] { { 3, 2 }, { 1, 4 }, { 2, 3 } }; */

