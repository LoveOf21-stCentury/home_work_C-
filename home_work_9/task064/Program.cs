/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int UserNumb(int numb)
{
    System.Console.WriteLine($"write element: ");
    numb = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    return numb;
}

void Print(int numb)
{
    if (numb != 1)
    {
        Print(numb - 1);
    }
    System.Console.Write($"{numb} ");
}

void Task64()
{
    int numb = 0;
    Print(UserNumb(numb));
}
Task64();