using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 numbers:
            //integer a (0 <= a <= 500)
            // floating - point b
            //floating - point c
            //The program then prints them in 4 virtual columns on the console.
            //Each column should have a width of 10 characters.
            //The number a should be printed in hexadecimal, left aligned
            //Then the number a should be printed in binary form, padded with zeroes
            //The number b should be printed with 2 digits after the decimal point, right aligned
            //The number c should be printed with 3 digits after the decimal point, left aligned.

            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 500) Console.WriteLine("Invalid input!!!");

            double b;
            while (!double.TryParse(Console.ReadLine(), out b)) Console.WriteLine("Invalid input!!!");

            double c;
            while (!double.TryParse(Console.ReadLine(), out c)) Console.WriteLine("Invalid input!!!");

            Console.Write("|{0, -10:X}|{1}|{2}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b.ToString().PadLeft(10, ' '));



            bool check = Convert.ToString(c).IndexOf(".") > 0;
            Console.WriteLine(check ? "{0:0.000}         |" : "{0}", c);

            Console.WriteLine();
        }
    }
}
