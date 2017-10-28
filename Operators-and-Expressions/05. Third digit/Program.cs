using System;

namespace _05.Third_digit
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads an integer N from the console and prints true
            //if the third digit of N is 7, or "false THIRD_DIGIT", where you should print the third digits of N.

            //The counting is done from right to left, meaning 123456's third digit is 4.
            long N = long.Parse(Console.ReadLine());

            long dividedByaHundred = N / 100;
            long remainder = dividedByaHundred % 10;
            if (remainder == 7) 
            {
                Console.WriteLine("true");
            }      
            else 
                    {
                Console.WriteLine("false" +" "+ remainder);
                    }   



        }
    }
}
