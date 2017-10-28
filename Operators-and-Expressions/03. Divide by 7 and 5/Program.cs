using System;
 

namespace _03.Divide_by_7_and_5
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool result = (number % 5 == 0 && number % 7 == 0) ? true : false;
            Console.WriteLine(result+" "+number);



        }
    }
}
