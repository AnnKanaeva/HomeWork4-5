/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */

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
            Console.WriteLine("Вы ввели символ либо не целое число. Пожалуйста, введите корректное число.");
        }
    }
    return result;
}
double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputVariable(){
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.WriteLine($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b)");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) 
      coeff[i,j] = GetNumber($"Введите коэффициент k: ");
      
      else 
      coeff[i,j] = GetNumber($"Введите коэффициент b: ");
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.WriteLine($"Прямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.WriteLine($"Прямые параллельны");
  }
  else 
  {
    Decision(coeff);
    Console.WriteLine($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputVariable();
OutputResponse(coeff);
