using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Number_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Description

            //Write a program that gets two numbers from the console and prints the greater of them.

            // Input

            //On the first two lines you will receive the two numbers, A and B
            //Output

            //On the only line print the larger of the two numbers
            //*Try implementing it without using if-statements

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? a : b);

            
            

        }
    }
}
