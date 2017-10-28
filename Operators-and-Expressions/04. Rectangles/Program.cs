using System;

namespace _04.Rectangles
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("width");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("height");
           
            float height = float.Parse(Console.ReadLine());
            float area = (width * height);
            float perimeter = ((width + height) * 2);
            Console.WriteLine(area + " " + perimeter);


        }
    }
}
