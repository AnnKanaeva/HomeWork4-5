/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

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
string recursion(int m, int n)
{
    if (n == m)
        return m.ToString();
    else
        return recursion(m, n - 1) + ", " + n;
}
int m = GetNumber("Введите число M:");
int n = GetNumber("Введите число N:");

//Console.WriteLine($"{recursion(m, n)}");
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
PrintSumm(m, n, temp = 0);
void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.WriteLine($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

