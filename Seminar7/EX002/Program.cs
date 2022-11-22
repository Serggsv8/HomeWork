// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
int rows = FindInt("Ввод индекса строки: ");
int colums = FindInt("Ввод индекса столбца: ");

int [,] matrix = new int[4,4];

Console.Write("Полученный массив: ");
Console.WriteLine();
PrintArray (matrix);

if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) 
{
Console.WriteLine("Искомое число по введенному индексу - " + matrix[rows, colums]);
}
else 
{
Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
}

void PrintArray(int[,] matr)
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

int FindInt(string message)
{
    Console.Write(message);
    return Convert.ToInt16(Console.ReadLine());
}

