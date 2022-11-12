﻿        //  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    // 456 -> 5
    // 782 -> 8
    //  918 -> 1


int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 != amount > 3)
{
    Console.WriteLine("Ошибка ввода! ");
}
else
{
    Console.WriteLine(TripleMid(number));
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int TripleMid(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}