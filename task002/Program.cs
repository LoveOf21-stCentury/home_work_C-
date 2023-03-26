int a = 0;
int b = 0;

Console.WriteLine("наберите два числа (через Enter) и после снова нажмите на Enter");

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
{

  if (a > b)
  {
    Console.Write(a);
    Console.WriteLine(" больше ");
    Console.Write(b);
    Console.Write(" меньше ");
  }
  else
  {
    Console.Write(b);
    Console.WriteLine(" больше ");
    Console.Write(a);
    Console.Write(" меньше ");
  }
}