// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1, k1, b2, k2;

EnterArgs(out b1, out k1, out b2, out k2);

CheckPoints(b1, k1, b2, k2);

void FindIntersection(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координата пересечения: ({x};{y})");
}

void CheckPoints(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Эти прямые параллельны");
    }
    else
    {
        FindIntersection(b1, k1, b2, k2);
    }
}

void EnterArgs(out double b1, out double k1, out double b2, out double k2)
{
    Console.WriteLine("Введите переменную b1: ");
    b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите переменную k1: ");
    k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите переменную b2: ");
    b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите переменную k2: ");
    k2 = Convert.ToInt32(Console.ReadLine());
}