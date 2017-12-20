using System;

namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
            //Input:

            //On the first three lines, you will receive the coefficients a, b, and c, each on a separate line in the same order

            //Output:

            // If two different real roots exist, print them on two separate lines
            //    .Print the smaller root on the first line
            //If only one real root exists, print it on the only output line
            // If no real root exists, print the string "no real roots"
            //The roots, should they exist, must be printed with precision exactly two digits after the floating point

            float a = float.Parse(Console.ReadLine());
            float b= float.Parse(Console.ReadLine());
            float c= float.Parse(Console.ReadLine());
            if ((a < -1000) || (a > 1000) || (b < -1000) || (b > 1000) || (c < -1000) || (c > 1000))
            {
                Console.WriteLine("invalid format");
            }
            else
            {

                float discriminant = (b * b) - (4 * a * c);
                if (discriminant > 0)
                {
                    float x2 = ((-b) + (float)Math.Sqrt(discriminant)) / (2 * a);
                    float x1 = ((-b) - (float)Math.Sqrt(discriminant)) / (2 * a);

                    Console.WriteLine("{0:0.00}", x1);
                    Console.WriteLine("{0:0.00}", x2);
                }
                else if (discriminant == 0)
                {
                    double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("{0:0.00}", x1Andx2);

                }
                else if (discriminant < 0)
                {
                    Console.WriteLine("no real roots");
                }
            }

        }
    }
}
