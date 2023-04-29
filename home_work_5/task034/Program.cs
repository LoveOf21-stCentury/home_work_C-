/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

void FillArry(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(100, 1000);
    }
}

void PrintArray(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        System.Console.Write(nums[i] + " ");
    }
}

int FindingPostiveSign(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count ++;

    }
    System.Console.WriteLine();
    return count;
}

void Task34()
{
    System.Console.WriteLine("How long your array will be?");
    int size = int.Parse(Console.ReadLine());
    int[] numbers = new int[size];
    FillArry(numbers);
    PrintArray(numbers);
    System.Console.WriteLine($"Count of even numbers in your array is: {FindingPostiveSign(numbers)}");
    /* int count = FindingPostiveSign(numbers);
    System.Console.WriteLine($"Count of even numbers in your array is: {count}"); */
}

Task34();