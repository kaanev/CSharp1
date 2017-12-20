using System;

namespace _07.Sum_of_5_numbers
{
    class Program
    {
        static void Main()
        {
            //Description:

            //Write a program that reads 5 integer numbers from the console and prints their sum.

            //Input:

            //You will receive 5 numbers on five separate lines.

            //Output:

            //Your output should consist only of a single line -the sum of the 5 numbers.

            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d= int.Parse(Console.ReadLine());
            int e= int.Parse(Console.ReadLine());
               if ((a<-1000)||(a>1000)||(b<-1000)||(b>1000)||(c<-1000)||(c>1000)||(d<-1000)||(d>1000)||(e<-1000)||(e>1000))
                 {
                Console.WriteLine("invalid Format");
                 }
               else
                 {
                Console.WriteLine(a + b + c + d + e);

                 }

        }
    }
}
