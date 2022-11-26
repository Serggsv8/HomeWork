// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите начальное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма чисел от " + $"{M} " + "до " + $"{N}: ");
ResultSum(M, N, 0);

void ResultSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.Write($"{sum}"); 
        return;
    }
    sum = sum + (M++);
    ResultSum(M, N, sum);
}
