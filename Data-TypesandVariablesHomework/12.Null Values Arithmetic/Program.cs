using System;


namespace Null_Values_Arithmetic
{
    class Program
    {
        static void Main()
        {
            //Create a program that assigns null values to an integer and to a double variable.

            // Try to print these variables at the console.
            //Try to add some number or the null literal to these variables and print the result.
            int? a = null;
            double? b = null;
            Console.WriteLine("{0} {1}",a,b);
            a = a + null;
            b = b + null;
            Console.WriteLine("{0} {1}", a, b);
            a = a + 100;
            b = b + 1234;
            Console.WriteLine("{0} {1}", a, b);
            a = a + 100;
            b = b + 1234;
            Console.WriteLine("{0};{1}", a.GetValueOrDefault(), b.GetValueOrDefault());



        }
    }
}
