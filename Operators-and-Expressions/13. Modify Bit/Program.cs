using System;
 

namespace _13.Modify_Bit
{
    class Program
    {
        static void Main()
        {
            //We are given an integer number N (read from the console), 
            // a bit value v (read from the console as well) (v = 0 or 1)  
            //and a position P (read from the console).  
            //Write a sequence of operators (a few lines of C# code) that modifies N 
            // to hold the value v at the position P from the binary representation of N  
            //while preserving all other bits in N. Print the resulting number on the console.


            // The input will consist of exactly 3 lines containing the following:
            //1. First line -the integer number N.
            //2. Second line -the position P.
            //3. Third line -the bit value v.


            //Output a single line containing the value of the number N with the modified bit.

            //Constraints

            //  N will always be a valid 64 - bit unsigned integer.
            // P will always be between in the range[0, 64).
            // v will be always either 0 or 1.

            //Input

            ulong numberN = ulong.Parse(Console.ReadLine());
            int positionP = int.Parse(Console.ReadLine());
            byte bitValueV = byte.Parse(Console.ReadLine());
            ulong mask = 1;
            ulong numberAndMask;

            if (bitValueV == 0)
            {
                numberAndMask = ~(mask << positionP) & numberN;
            }
            else
            {
                numberAndMask = numberN | mask << positionP;
            }

            Console.WriteLine(numberAndMask);








        }
    }
}
