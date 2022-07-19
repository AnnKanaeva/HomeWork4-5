/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(-9, 10);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int GetOddIndexSumm(int[] arr)
{
    int summ = 0;

    for (int i = 1; i < arr.Length; i = i + 2)
    {
        summ = summ + arr[i];
    }

    return summ;
}

Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());

int[] array = GetArray(dimension);
PrintArray(array);

int result = GetOddIndexSumm(array);

Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции =  {result}");

