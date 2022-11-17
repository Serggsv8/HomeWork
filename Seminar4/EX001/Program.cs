
   
   
//    Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в целую степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


    Console.WriteLine("Введите значение A: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение B: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int result = numberA;

    Stepen(numberA, numberB);
    void Stepen(int numberA, int numberB)
    {
        for (int i = 1; i < numberB; i++)
        {
            result = result * numberA;
        }
         Console.WriteLine("Значение " + $"{numberA}" + " в степени: " 
         + $"{numberB}" + " = " + $"{result}");

    }
