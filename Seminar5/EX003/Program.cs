// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива N: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int min = Int32.MaxValue;
int max = Int32.MinValue;

Console.Write("Полученный массив из N элементов: ");

GenArray(size, array);
MaxMinNum(array, max, min);

void GenArray(int size, int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 99);
        Console.Write(array[i] + " ");
    }
}

void MaxMinNum(int[] array, int max, int min)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }

Console.WriteLine();
Console.WriteLine("Разница между минимальным и максимальным = " + $"{max - min}");
}


