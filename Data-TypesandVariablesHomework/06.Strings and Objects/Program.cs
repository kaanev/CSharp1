using System;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object hi = (hello +" "+  world);
            string finalWord = (string)hi;
            Console.WriteLine(finalWord);


            
        }
    }
}
