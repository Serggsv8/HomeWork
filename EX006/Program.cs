
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int CheckNum = -1;

CheckNum = ErrorFind(numb, CheckNum);
FindThird(CheckNum);

void FindThird(int CheckNum)
{
    int a = CheckNum;
    while (a > 1000)
    {
        a = a / 10;
    }
    int result = (a % 10);
    Console.Write("Третья цифра введенного числа: ");
    Console.WriteLine(result);
}

int ErrorFind(int numb, int CheckNum)
{
    if (numb < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        CheckNum = numb;
    }

    return CheckNum;
}
