﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите начальное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.Write("Числа по убыванию: ");
Result(number, count);

void Result(int N, int count)
{
    if (count > N)
    {
        return;
    }
    else
    {
        Result(N, count + 1);
        Console.Write(count + " ");
    }
}