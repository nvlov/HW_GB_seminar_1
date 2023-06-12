// Задача 2: Напишите программу, 
//которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2)
        {
            Console.WriteLine("{0} is greater than {1}.", number1, number2);
            Console.WriteLine("{0} is less than {1}.", number2, number1);
        }
        else if (number1 < number2)
        {
            Console.WriteLine("{0} is greater than {1}.", number2, number1);
            Console.WriteLine("{0} is less than {1}.", number1, number2);
        }
        else
        {
            Console.WriteLine("Both numbers are equal.");
        }
    }
}


