/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.WriteLine("Write number of 5 numbers");
int a = int.Parse(Console.ReadLine());
if (a > 9999 && a < 100000)
{
    char[] arr = a.ToString().ToCharArray();
    if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        System.Console.WriteLine("Polindrome!");
    }
    else
    {
        System.Console.WriteLine("Not polindrome!");
    }
}
else
{
    System.Console.WriteLine("No. Need number of 5 numbers");
}


