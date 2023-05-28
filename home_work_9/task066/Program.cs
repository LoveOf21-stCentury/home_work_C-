/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void Print(int m, int n)
{
    System.Console.Write($"{m} ");
    if (m != n)
    {
        Print(m + 1, n);
    }
}

void Task066()
{
    int m = 4;
    int n = 8;
    Print(m, n);
}
Task066();