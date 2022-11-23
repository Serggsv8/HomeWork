// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2


int [,] matrix = new int[4,4];

Console.Write("Массив из случайных чисел: ");
Console.WriteLine();
PrintArrayRandom(matrix);
NewArray(matrix);
Console.Write("Массив по убыванию: ");
Console.WriteLine();
PrintArray(matrix);

void PrintArrayRandom(int[,] matr)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
 for (int j = 0; j < matrix.GetLength(1); j++)
 {
    matr[i,j] = new Random().Next(0,10);
    Console.Write($"{matr[i, j]} ");
     }
Console.WriteLine();
}
}

void NewArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] matr)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
 for (int j = 0; j < matrix.GetLength(1); j++)
 {
    Console.Write($"{matr[i, j]} ");
     }
Console.WriteLine();
}
}