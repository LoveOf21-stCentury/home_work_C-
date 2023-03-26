// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("введите любое, после нажмите на Enter ");
int n = 0;

if (int.TryParse(Console.ReadLine(), out n))
{
  for (int i = 2; i <= n; i += 2)
  {
    Console.WriteLine(i);
    Console.Write(" четные числа от 1 до N ");
  }
}
else
{
  Console.Write("что-то пошло не так, возможно Вы ввели не число, попробуйте еще раз ");
}



