using System;
 

namespace _11._3rd_Bit
{
    class Program
    {
        static void Main()
        {
            // Using bitwise operators, write a program that uses an expression
            //to find the value of the bit at index 3 of an unsigned integer read from the console.

            //.The bits are counted from right to left, starting from bit 0.
            //The result of the expression should be either 1 or 0.Print it on the console.

            uint integer = uint.Parse(Console.ReadLine());
            uint bit = integer >> 3;
            uint bitAndone = bit & 1;
            Console.WriteLine(bitAndone);



        }
    }
}
