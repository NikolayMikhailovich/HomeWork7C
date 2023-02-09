// Задача 3. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int m, int n)
{
  int[,] arr = new int[m, n];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1, 5);
    }
  }
  return arr;
}

void DecisionMatrix(int[,] arr)
{
  Console.Write("Среднее арифметическое каждого столбца: ");
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    double average = 0;
    int sum = 0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
      sum += arr[j, i];
    }
    average = Math.Round(((double)sum / arr.GetLength(0)), 1);
    Console.Write($"{average}");
    if (i < arr.GetLength(1) - 1) Console.Write("; ");
    else Console.Write(".");
  }
}

void PrintMatrix(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (j == 0) Console.Write("");
      if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3}");
      else Console.Write($"{arr[i, j],3}");
    }
    Console.WriteLine();
  }
}

Console.WriteLine();
int[,] arrayCreate = CreateMatrixRndInt(7, 7);
PrintMatrix(arrayCreate);
Console.WriteLine();
DecisionMatrix(arrayCreate);