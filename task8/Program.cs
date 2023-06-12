// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Even numbers from 1 to {0}:", N);
        
        for (int i = 2; i <= N; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
