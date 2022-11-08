Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;

if (a < b)
{
    min = a;
    max = b;
}
else
{
    min = b;
    max = a;
}
Console.Write("min = ");
Console.WriteLine(min);
Console.Write("max = ");
Console.WriteLine(max);
