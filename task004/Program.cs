// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a = 0;
int b = 0;
int c = 0;

Console.WriteLine("наберите три числа (через Enter) и после снова нажмите на Enter");

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c))
{

  if (a > b && a > c)
  {
    Console.Write(a);
    Console.WriteLine(" больше ");
  }
  else if (b > a && b > c)
  {
    Console.Write(b);
    Console.WriteLine(" больше ");
  }
  else if (c > a && c > b)
  {
    Console.Write(c);
    Console.WriteLine(" больше ");
  }
}