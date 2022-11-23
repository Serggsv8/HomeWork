// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] matrix = new int[2,2,2];

Console.Write("Массив из случайных чисел: ");
Console.WriteLine();

RandomArray(matrix);
PrintArray(matrix);

void RandomArray(int[,,] matrix)
{
  int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
  int  number;
  for (int x = 0; x < temp.GetLength(0); x++)
  {
    temp[x] = new Random().Next(10, 100);
    number = temp[x];
    if (x >= 1)
    {
      for (int y = 0; y < x; y++)
      {
        while (temp[x] == temp[y])
        {
          temp[x] = new Random().Next(10, 100);
          y = 0;
          number = temp[x];
        }
          number = temp[x];
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        matrix[i, j, k] = temp[count];
        count++;
      }
    }
  }
}


void PrintArray(int[,,] matr)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
 for (int j = 0; j < matrix.GetLength(1); j++)
 {
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        Console.Write($"{matr [i,j,k]} ");
         Console.Write("({0},{1},{2})\t", i, j, k);
    }
     Console.WriteLine();
 }
}
}