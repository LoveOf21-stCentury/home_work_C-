/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void FillArry(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(-99, 100);
    }
}

void PrintArray(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        System.Console.Write(nums[i] + " ");
    }
    System.Console.WriteLine();
}

int GetPositiveSum(int[] numbers)
{
    int sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) sum += numbers[i];
    }
    return sum;
}

void Task36()
{
    System.Console.WriteLine("How long your array will be?");
    int size = int.Parse(Console.ReadLine());
    int[] numbers = new int[size];
    FillArry(numbers);
    PrintArray(numbers);
    int sum = GetPositiveSum(numbers);
    System.Console.WriteLine($"sum of positive elements {sum}");
}

Task36();