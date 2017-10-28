using System;
 

namespace Four_digits
{
    class Program
    {
        static void Main()
        {
            //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:

            //Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
            //Prints on the console the number in reversed order: dcba(in our example 1102) and prints the reversed number.
            //Puts the last digit in the first position: dabc(in our example 1201) and prints the result.
            //Exchanges the second and the third digits: acbd(in our example 2101) and prints the result.

            uint abcd = uint.Parse(Console.ReadLine());
            uint a = abcd / 1000;
            uint b = (abcd / 100) % 10;
            uint c = (abcd / 10) % 10;
            uint d = abcd % 10;
            uint sum = a + b + c + d;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}",d,c,b,a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);




        }
    }
}
