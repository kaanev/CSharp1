﻿using System;


namespace Print_the_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            // Find online more information about ASCII (American Standard Code for Information Interchange)
            //and write a program that prints the visible characters of the ASCII table on the console 
            //(characters from 33 to 126 including).

            //Note: You may need to use for-loops(learn in Internet how).

            //Input None
            //Output The 94 characters on single lin

            for (int i = 33; i < 127; i++)
            {
                Console.WriteLine((char)i);
            }





        }
    }
}
