//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void WeekEnd()
{
  bool isWorking = true;

  while (isWorking)
  {
    Console.WriteLine("Введите цифру дня недели (Для выхода напишите 'end')"); //эта строка будет выводиться снова после вывода результата, чтобы была возможность не перезапускать код, а продолжить проверку на "рабочий день"

    string day = Console.ReadLine()!;

    switch (day)
    {
      case "end":
        isWorking = false;
        break;
      case "1":
        System.Console.WriteLine("понедельник - нет");
        break;
      case "2":
        System.Console.WriteLine("вторник - нет");
        break;
      case "3":
        System.Console.WriteLine("среда - нет");
        break;
      case "4":
        System.Console.WriteLine("четверг - нет");
        break;
      case "5":
        System.Console.WriteLine("пятница - нет");
        break;
      case "6":
        System.Console.WriteLine("суббота - да");
        break;
      case "7":
        System.Console.WriteLine("воскресенье - да");
        break;
      default:
        System.Console.WriteLine("ошибка, введите цифру от 1 до 7");
        break;
    }
  }
}

WeekEnd();