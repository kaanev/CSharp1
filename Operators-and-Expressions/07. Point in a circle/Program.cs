using System;


namespace _07.Point_in_a_circle
{
    class Program
    {
        static void Main()
        {
            // Write a program that reads the coordinates of a point x and y 
            //  and using an expression checks if given point(x, y) 
            // is inside a circle K({ 0, 0}, 2) -the center has coordinates(0, 0) and the circle has radius 2. 
            //The program should then print "yes DISTANCE" if the point is inside the circle  
            //or "no DISTANCE" if the point is outside the circle.
            // In place of DISTANCE print the distance from the beginning of the coordinate system -(0, 0) -to the given point.

            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            byte h = 0;
            byte k = 0;
            byte r = 2;
            if (((x - h) * (x - h) + (y - k) * (y - k)) <= (r * r))
            {
                Console.WriteLine(((x > 5) || (x < -1) || (y > 1) || (y < -1)) ? "YES" : "NO");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("NO");
                Console.WriteLine();
            }
        }
    }
}
