/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

int a = 0;

Console.WriteLine("Напишите трехзначное число и после нажмите на Enter");

if (int.TryParse(Console.ReadLine(), out a))
{
  if (a >= 100 && a <= 999)
  {
    int GetSecond(int a)
    {
      while (a >= 100) a /= 10;
      int c = a % 10;
      System.Console.Write("Вторая цифра Вашего числа это: ");
      return c;
    }
    Console.WriteLine(GetSecond(a));
  }
  else
  {
    System.Console.WriteLine("Что-то явно не то, возможно Вы ввели не трехзначное число");
  }

}
else
{
  System.Console.WriteLine("Надо было очень постараться чтобы вылезла эта ошибка. Попробуйте все же ввести цифры, для корректной работы программы.");
}


/*Console.WriteLine("Введите трехзначное число");
int.TryParse(Console.ReadLine()!, out int k);

if (k > 999 || k < 100)
{
  Console.WriteLine("Не трехзначное число!!!");
  return;
}
int GetSecond(int k)
{
  while (k >= 100) k /= 10;
  int d = k % 10;
  return d;
}
Console.WriteLine(GetSecond(k));
*/