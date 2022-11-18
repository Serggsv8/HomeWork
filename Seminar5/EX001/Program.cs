// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2



Console.WriteLine("Введите длину массива N: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.Write("Полученный массив из N элементов: ");

GenArray(size, array);
int count = EvenNumber(array);
PrintResult(count);

void GenArray(int size, int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write(array[i] + " ");
    }
}

void PrintResult(int count)
{
    Console.WriteLine();
    Console.WriteLine("Четных чисел в массиве " + $"{count}");
}

int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}