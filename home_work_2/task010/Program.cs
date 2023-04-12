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

