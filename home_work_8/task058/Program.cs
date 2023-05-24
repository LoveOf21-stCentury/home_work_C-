/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] MatrixCoordinate(int[,] matrix, int row, int column)
{
    int[,] A = new int[row, column];
    int[,] B = new int[row, column];

    for (int i = 0; i < A.GetLength(0); i++)
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"count of first matrix: ");
            A[i, j] = Convert.ToInt32(Console.ReadLine());
        }

    for (int i = 0; i < B.GetLength(0); i++)
        for (int j = 0; j < B.GetLength(1); j++)
        {
            Console.Write($"count of second matrix: ");
            B[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        int[,] X = new int[A.Length, B.Length];
    for (int i = 0; i < B.GetLength(1); i++)
    {
        for (int j = 0; j < B.GetLength(0); j++)
        {
            X[i, j] = 0;
            for (int k = 0; k < B.GetLength(0); k++)
            {
                X[i, j] += A[i, k] * B[k, j];
            }
                System.Console.Write("{0}\t", X[i, j]);
        }
    }
        return matrix;
}



void Task058()
{
    int row = 2;
    int column = 2;
    int[,] matrix = new int[row, column];
    MatrixCoordinate(matrix, row, column);
}

Task058();