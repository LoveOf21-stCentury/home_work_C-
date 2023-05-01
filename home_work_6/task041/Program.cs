/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */
string Input(string text)
{
    Console.Write($"{text} ");
    return Console.ReadLine();
}

void FillArray(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        System.Console.WriteLine($"Write {i + 1} element: ");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]} ");
    }
    System.Console.WriteLine();
}

int CheckPositive(int[] numbers)
{
    int posNums = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            posNums += 1;
        }
    }
    return posNums;
}

void Task41()
{
    int size = Convert.ToInt32(Input("How long your array will be? "));
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    System.Console.WriteLine($"Positive numbers in your array is: {CheckPositive(numbers)}");
}

Task41();