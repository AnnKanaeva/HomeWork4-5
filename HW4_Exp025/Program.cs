/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
double GetNumber(string message)
{
    double result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result))
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
double Exp(double numberA, double numberB)
{
    double result = 1;
    for (double i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
double numberA = GetNumber("Введите число A: ");
double numberB = GetNumber("Введите число B: ");
double exponentiation = Exp(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно " + exponentiation);
