// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num = 0;
Console.Write("Введите любое число: ");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кубы числа от 1 до " + $"{num}");
for (int i = 1; i <= num; i++)
{
    Console.Write($"{i * i * i} ");
}
