// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

SpiralMatrix(matrix, ref temp, ref i, ref j);
Console.WriteLine("Полученные спиралевидный массив: ");
PrintMatrix(matrix);

void PrintMatrix (int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (matr[i,j] / 10 <= 0)
      Console.Write("0" + $"{matr[i,j]} ");

      else Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
  }
}

void SpiralMatrix(int[,] matrix, ref int temp, ref int i, ref int j)
{
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}