// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int numbFirst = 0;
int numbSec = 0;
string res = "";

FindNumb(numb, out numbFirst, out numbSec);

res = Comparison(numbFirst, numbSec);

string Comparison(int numbFirst, int numbSec)
{
    string res;
    if (numbFirst != numbSec)
    {
    int numb1 = numbSec % 10;
    int numb2 = numbSec / 10;
    numbSec = numb1 * 10 + numb2;
    if (numbSec == numbFirst)
    {
        res = "да, является палиндромом";
    }
       else
    {
        res = "нет, не является палиндромом";
    }
    }
    else
    {
        res = "нет, не является палиндромом";
    }

    Console.WriteLine(res);
    return res;
}

static void FindNumb(int numb, out int numbFirst, out int numbSec)
{
    numbFirst = numb / 1000;
    numbSec = numb % 100;
}

