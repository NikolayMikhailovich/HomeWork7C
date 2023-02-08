// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 - > 1

int[,] CreateArray(int a = 3, int b = 4)
{
  int[,] array = new int[a, b];
  Random rnd = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {

      array[i, j] = rnd.Next(1, 10);
    }
  }
  return array;
}


void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    System.Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
  }
}
int InputInt(string msg)
{
  System.Console.Write(msg + " >  ");
  return Convert.ToInt32(Console.ReadLine());
}

int[,] resultArray = CreateArray();
PrintArray(resultArray);
int a = InputInt("Введите номер строки");
int b = InputInt("Введите номер столбца");
if (a < 1 || b < 1 || a > resultArray.GetLength(0) || b > resultArray.GetLength(1))
{
  System.Console.WriteLine("Такого элемента нет в заданном массиве!");
}
else
{
  System.Console.WriteLine($"Значение элемента {a} строки и {b} столбца равно {resultArray[a - 1, b - 1]}");
}
