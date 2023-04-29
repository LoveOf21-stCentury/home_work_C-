/* 
using System;
using System.Security.Cryptography;
string input(string text)
{
    Console.Write($"{text}");
    return Console.ReadLine();
} */

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3,21 7,04 22,93 -2,71 78,24] -> 80,95 */

void FillArray(double[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round(rnd.NextDouble() * 10 - 5, 1);
    }
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]}   ");
    }
    System.Console.WriteLine();
}

double FindingMax(double[] numbers)
{
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {

        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}

double FindingMin(double[] numbers)
{
    double min = numbers[0];

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}

void Task38()
{
    System.Console.WriteLine("How long your array will be?");
    int size = int.Parse(Console.ReadLine());
    double[] numbers = new double[size];
    FillArray(numbers);
    PrintArray(numbers);
    double max = FindingMax(numbers);
    double min = FindingMin(numbers);
    double result = max - min;
    System.Console.WriteLine($"difference btw nums is: {result}");
}

Task38();


/* double min = numbers[0];
  for (int i = 0; i < numbers.Length; i++)
  {
      if (numbers[i] > max)
      {
          max = numbers[i];
          System.Console.WriteLine($"Max is {max}");
      }
      else if (numbers[i] < min)
      {
          min = numbers[i];
          System.Console.WriteLine($"Min is {min}");
      }
  }*/