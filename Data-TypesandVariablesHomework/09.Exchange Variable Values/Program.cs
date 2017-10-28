using System;


namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before exchange \t a={0}\tb={1}", a, b);
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After exchange \t a={0}\tb+{1}",a, b);




        }
    }
}
