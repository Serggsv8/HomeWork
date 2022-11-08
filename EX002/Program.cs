Console.WriteLine("Введите число numb1: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число numb2: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число numb3: ");
int numb3 = Convert.ToInt32(Console.ReadLine());
int max = numb1;

if(numb2 > max)
{
    max = numb2;
}
if(numb3 > max)
{
    max = numb3;
}
Console.Write("max = ");
Console.WriteLine(max);
