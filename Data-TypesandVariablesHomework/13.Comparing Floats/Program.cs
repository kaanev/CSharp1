using System;


namespace Comparing_Floats
{
    class Program
    {
        static void Main()
        {
            // Write a program that safely compares two floating-point numbers(double) with precision eps = 0.000001.

            //Note: Two floating-point numbers a and b cannot be compared directly by a == b 
            //because of the nature of the floating - point arithmetic.
            //Therefore, we assume two numbers are equal if they are more closely to each other
            //than a fixed constant eps.

            //     Input

            //   On the first line you will receive the first floating - point number
            //On the second line you will receive the second floating - point number
            //Hint: Use double.Parse(Console.ReadLine()) to read input

            double a = (double.Parse(Console.ReadLine()));
            double b= (double.Parse(Console.ReadLine()));
            bool equal = Math.Abs(a - b) < 0.000001;
            Console.WriteLine(equal);





        }
    }
}
