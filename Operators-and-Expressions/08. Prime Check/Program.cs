using System;
 

namespace _08.Prime_Check
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads an integer N (which will always be less than 100 or equal)  
            //and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).

            // Note: You should check if the number is positive
            uint N = uint.Parse(Console.ReadLine());
            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(N);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (N % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine( prime);

        }
    }
}
    

