using System;
 

namespace _10.Point__Circle__Rectangle
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads a pair of coordinates x and y 
            // and uses an expression to checks for given point (x, y)  
            //if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            bool circle = ((((x * x) - (2 * x) + 1) + ((y * y) - (2 * y) + 1)) <= (1.5 * 1.5));
            bool rectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
            if (circle == true && rectangle == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            if(circle==true&&rectangle==false)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            if(circle==false&&rectangle==true)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            if(circle==false&&rectangle==false)
            {
                Console.WriteLine("outside circle outside rectangle");
            }

        }
    }
}
