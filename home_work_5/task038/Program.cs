/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3,21 7,04 22,93 -2,71 78,24] -> 80,95 */

void FillArray(double[] numbers)
{
    Random rnd = new Random();
    System.Console.WriteLine("array is: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.NextDouble(-9, 10);
    }
    /* for (int i = 0; i < nums.Length; i++)
    {
        System.Console.WriteLine($"write {i + 1} element: ");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
    System.Console.WriteLine(); */
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + " ");
    }
    System.Console.WriteLine();
}

double SearchDif(double[] numbers)
{
    double max = numbers[0];
    double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        else if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return numbers.Max() - numbers.Min();
}

void Task38()
{
    System.Console.WriteLine("How long your array will be?");
    double size = Convert.ToDouble(Console.RedLine);
    
    int[] numbers = new double[size];
    FillArray(numbers);
    PrintArray(numbers);
    //System.Console.WriteLine($"difference btw nums is: {SearchDif(numbers)}");
}

Task38();