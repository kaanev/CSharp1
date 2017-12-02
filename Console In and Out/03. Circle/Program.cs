using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads from the console the radius r of a circle and prints its perimeter and area,
            //rounded and formatted with 2 digits after the decimal point.

            //Input

            // On the only line of the input you will receive the radius of the circle - r

            //Output

            //You should print one line only: the perimeter and the area of the circle, 
            //separated by a whitespace, and with 2 digits precision

            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double perimeter = 2 * pi * r;
            double area = pi * (r * r);
          Console.Write("{0:0.00}"+" ",perimeter);
            Console.WriteLine("{0:0.00}", area);
      

           



        }
    }
}
