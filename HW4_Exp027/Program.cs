/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/* Проверка на корректность введенного числа*/
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }
    }
    return result;
}
/*int number = GetNumber("Введите число: ");
int GetSumm(int number);
{
return result;
}
int number = GetNumber();
int result = GetSumm(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");*/



/*int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }
    }

    return result;
}
int SumNumber(int number)
{
    int counter = Convert.ToString(number).Length;  /*string str = number.ToString();
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;
    }
    return result;
}
int number = GetNumber("Введите число: ");
int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
*/





  int SumNumber(int number)
  {
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }
int number = GetNumber("Введите число: ");
int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);