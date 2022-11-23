// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] matrixFirst = new int[2,2];
int [,] matrixSecond = new int [2,2];
Console.Write("Первая матрица: ");
Console.WriteLine();
RandomArray(matrixFirst);
RandomArray(matrixSecond);
PrintArray(matrixFirst);
Console.WriteLine("Вторая матрица:");
PrintArray(matrixSecond);
int[,] resultMatr = new int[2,2];
Console.WriteLine("Результат перемножения: ");
MultiplyMatrix(matrixFirst, matrixSecond, resultMatr);
PrintArray(resultMatr);

void MultiplyMatrix(int[,] matrixFirst, int[,] matrixSecond, int[,] resultMatr)
{
  for (int i = 0; i < resultMatr.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatr.GetLength(1); j++)
    {
      int sumElem = 0;
      for (int k = 0; k < matrixFirst.GetLength(1); k++)
      {
        sumElem += matrixFirst[i,k] * matrixSecond[k,j];
      }
      resultMatr[i,j] = sumElem;
    }
  }
}

void PrintArray(int[,] matr)
{
for (int i = 0; i < matrixFirst.GetLength(0); i++)
{
 for (int j = 0; j < matrixFirst.GetLength(1); j++)
 {
    Console.Write($"{matr [i,j]} ");
     }
      Console.WriteLine();
}
}

void RandomArray(int[,] matr)
{
for (int i = 0; i < matrixFirst.GetLength(0); i++)
{
 for (int j = 0; j < matrixFirst.GetLength(1); j++)
 {
    matr[i,j] = new Random().Next(0,10);
     }
}
}