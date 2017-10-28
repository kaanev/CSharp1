using System;
 
namespace _14.BitExchange
{
    class Program
    {
        static void Main()
        {
            //Description

            // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26
            //of given 32 - bit unsigned integer(read from the console).

            // Input

            //   On the only input line you will receive the unsigned integer number whose bits you must exchange.

            // Output

            //On the only output line print the value of the integer with the exchanged bits.

            uint numberN = uint.Parse(Console.ReadLine());
            uint newN1 = 3 << 24;

            
        }
    }
}
