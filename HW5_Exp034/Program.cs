/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Random rnd = new Random();
int[] array = new int[4];
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
    Console.Write($"{array[i]} ");
    if (array[i] % 2 == 0)
    {
        result = result+1;  
    }
}
Console.WriteLine($"Количество четных чисел массива {result} ");

