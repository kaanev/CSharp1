using System;
 


namespace _09.Trapezoids
{
    class Program
    {
        static void Main()
        {
            //  Write an expression that calculates trapezoid's area by given sides a and b and height h. 
            // The three values should be read from the console in the order shown below.  
            //All three value will be floating-point numbers.

            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double heightH = double.Parse(Console.ReadLine());
            double trapezoidArea = ((sideA + sideB) / 2) * heightH;
            Console.WriteLine(trapezoidArea);

        }
    }
}
