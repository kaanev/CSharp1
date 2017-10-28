using System;
 

namespace _12.N_th_bit
{
    class Program
    {
        static void Main()
        {
            // Write a program that reads from the console two integer numbers P and N 
            //and prints on the console the value of P's N-th bit.
            //Input -On the first line you will receive the number P.On the second line you will receive the number N.




            //  Output a single value - the value of the N-th bit in P.


            //N will be a positive integer and always smaller than 55.
            //0 <= P <= 255
            
            //Input
            ulong p = ulong.Parse(Console.ReadLine());
            short n = short.Parse(Console.ReadLine());
            ulong pPow = (ulong)Math.Pow(0, 255);
            
            //Output
            if ((p <= pPow) && (n <= 55)) ;

             ulong bit = (p >> n) & 1;
                Console.WriteLine(bit == 0 ? "0" : "1"); 
            
               

                
                 

               
             

            
        }
    }
}
