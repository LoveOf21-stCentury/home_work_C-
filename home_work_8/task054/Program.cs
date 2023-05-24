/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

using System;
using System.Linq;

namespace n
{
    internal class Program
    {
        private static void Main(string[] args)
        {
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
                //это решение работает не совсем корректно. Оно сортирует весь массив, а не по строчно  
                /* var arr = array.Cast<int>().OrderByDescending(a => a).ToArray();

                int c = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        array[j, k] = arr[c];
                        Console.Write(array[j, k] + " ");
                        c++;
                    }
                    Console.WriteLine();
                }
                Console.ReadKey(); */

                // это решение тоже работает не совсем корректно, оно перебирает столбцы. Зато построчно. Сломала голову, так и не нашла способа для верного и корректного решения.
                int minRow = 0;
                int temp = 0;
                for (int NumRow = 0; NumRow < row; NumRow++)
                {

                    for (int NumCol = 0; NumCol < column - 1; NumCol++)
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
            }
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
        }
    }
}

