using System;
 
 

namespace _01.Sum_of_3_numbers
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads 3 real numbers from the console and prints their sum.

            // Input
            // On the first line, you will receive the number a
            //On the second line, you will receive the number b
            //On the third line, you will receive the number c
            //Output
            //Your output should consist only of a single line - the sum of the three numbers.

            double a = double.Parse(Console.ReadLine());
            double b= double.Parse(Console.ReadLine());
            double c= double.Parse(Console.ReadLine());
            Console.WriteLine(a + b + c);







        }
    }
}
