// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива N: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.Write("Полученный массив из N элементов: ");

GenArray(size, array);
int sumElem = FinalCheck(size, array);
PrintResult(sumElem);

void GenArray(int size, int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write(array[i] + " ");
    }
}

void PrintResult(int sumElem)
{
    Console.WriteLine();
    Console.WriteLine("Сумма нечетных элементов " + $"{sumElem}");
}

 int FinalCheck(int size, int[] array)
{
    int sumElem = 0;
    for (int i = 0; i < size; i++)
    {

        if (i % 2 != 0)
        {
            sumElem = sumElem + array[i];
        }
    }

    return sumElem;
}