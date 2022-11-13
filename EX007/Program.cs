// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int [] alldays = {1,2,3,4,5,6,7};
Console.WriteLine("Введите порядковый номер дня: ");
int day = Convert.ToInt32(Console.ReadLine());

HollyDay(alldays, day);

 void HollyDay(int[] alldays, int day)
{
    if (day == alldays[6] || day == alldays[5])
    {
        Console.WriteLine("Ура! Выходной день! ");
    }
}

WorkDay(alldays, day);

 void WorkDay(int[] alldays, int day)

{
    if (day <= alldays[4])
    {
        Console.WriteLine("Рабочий день, продолжаем работать!");
    }
}
ErrorDay(alldays, day);

 void ErrorDay(int[] alldays, int day)

{
    if (day > alldays[6])
    {
        Console.WriteLine("Ошибка, внимательнее!");
    }
}
