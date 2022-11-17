// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

// N = 5, получаем массив [1, 2, 5, 7, 19]

// N = 3, получаем массив [6, 1, 33]


Console.WriteLine("Введите длину массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.Write("Полученный массив из N элементов: ");

GenArray(N, array);

void GenArray(int N, int[] array)
{
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(2, 16);
        Console.Write(array[i] + " ");
    }
}
