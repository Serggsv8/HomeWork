// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

int [,] matrix = new int[4,4];

Console.Write("Массив из случайных чисел: ");
Console.WriteLine();

PrintArrayRandom(matrix);
SummRow(matrix);

void SummRow(int[,] matr)
{
    int Elem = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Elem += matrix[0, i];
    }

    int minSum = 0;
    int sumRow = 0;

      for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        
        sumRow += matrix[i, j];
        
        if (sumRow < Elem)
        {
            Elem = sumRow;
            minSum = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSum + 1} - " + "Строка с минмимальной суммой элементов");
}
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