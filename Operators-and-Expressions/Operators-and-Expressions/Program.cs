using System;


namespace Operators_and_Expressions
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int Number = a % 2;
             if (Number == 0)
              {
                Console.WriteLine("ood"+" "+a);

              }
             else
               {
                Console.WriteLine("even"+" "+a);
               }



        }
    }
}
