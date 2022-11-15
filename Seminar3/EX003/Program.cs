// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

            int aX, aY, aZ;
            int bX, bY, bZ;

            Console.WriteLine("Введите координаты точек A и B: ");
            Console.Write("aX: ");
            aX = Convert.ToInt32(Console.ReadLine());
            Console.Write("aY: ");
            aY = Convert.ToInt32(Console.ReadLine());
            Console.Write("aZ: ");
            aZ = Convert.ToInt32(Console.ReadLine());

            Console.Write("bX: ");
            bX = Convert.ToInt32(Console.ReadLine());
            Console.Write("bY: ");
            bY = Convert.ToInt32(Console.ReadLine());
            Console.Write("bZ: ");
            bZ = Convert.ToInt32(Console.ReadLine());

double Result(double aX, double bX, double aY, double bY, double aZ, double bZ)

{
  return Math.Sqrt(Math.Pow((aX-bX), 2) + Math.Pow((aY-bY), 2) + Math.Pow((aZ-bZ), 2));
}

double Length =  Math.Round (Result(aX, bX, aY, bY, aZ, bZ), 2 );

Console.WriteLine($"Длина отрезка  {Length}");