// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

Console.WriteLine("Введите длину массива m: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите длину массива n: ");
int n = Convert.ToInt16(Console.ReadLine());
double [,] matrix = new double[m,n];

void PrintArray(double[,] matr)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
 for (int j = 0; j < matrix.GetLength(1); j++)
 {
    Console.Write($"{matrix[i, j]} ");
     }
Console.WriteLine();
}
}

void FillArray(double[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 matr[i,j] = new Random().Next(-100,100) / 10.0;
 }
 }
}
PrintArray (matrix);
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Полученная матрица: ");
PrintArray(matrix);

