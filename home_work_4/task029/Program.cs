/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

System.Console.Write("how long your array would be: ");
int count = int.Parse(Console.ReadLine());
int[] arr = new int[count];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Your number: ");
    arr[i] = int.Parse(Console.ReadLine());
}

System.Console.WriteLine("Your array: ");

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write(arr[i] + " ");
}

