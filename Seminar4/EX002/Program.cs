// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());
int lenNum = NumberDiv(baseNumber);
SumNumber(baseNumber, lenNum);

int NumberDiv(int baseNumber) // Делим число на цифры
{
    int index = 0;
    while (baseNumber > 0)
    {
        baseNumber = baseNumber / 10;
        index++;
    }
    return index;
}
void SumNumber(int baseNumber, int lenNum) // Складываем цифры между собой
{
    int sumNum = 0;
    for (int i = 1; i <= lenNum; i++)
    {
        sumNum += baseNumber % 10;
        baseNumber = baseNumber / 10;
    }
    Console.WriteLine(sumNum);
}