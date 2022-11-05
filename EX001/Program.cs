int a = -9;
int b = -3;
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
