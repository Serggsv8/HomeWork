Console.WriteLine("Введите число numb: ");
int numb = Convert.ToInt32(Console.ReadLine());
string result = "test";

if (numb % 2 == 0)
{
    result = "true";
}
else
{
    result = "false";
}
Console.Write("result = ");
Console.WriteLine(result);