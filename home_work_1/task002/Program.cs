// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

int a = 0;
int b = 0;

Console.WriteLine("наберите два числа (через Enter) и после снова нажмите на Enter");

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
{

  if (a > b)
  {
    Console.Write(a);
    Console.WriteLine(" больше ");
    Console.WriteLine(b);
    Console.WriteLine(" меньше ");
  }
  else
  {
    Console.Write(b);
    Console.WriteLine(" больше ");
    Console.Write(a);
    Console.Write(" меньше ");
  }
}