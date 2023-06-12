// Задача 4: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int maxNumber = Math.Max(Math.Max(number1, number2), number3);
        int minNumber = Math.Min(Math.Min(number1, number2), number3);

        Console.WriteLine("{0} is the greatest number.", maxNumber);
        Console.WriteLine("{0} is the smallest number.", minNumber);
    }
}
