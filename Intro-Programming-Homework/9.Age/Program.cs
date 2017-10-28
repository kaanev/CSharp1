using System;


namespace Age
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("въведи дата на раждане");
            DateTime age = DateTime.Parse(Console.ReadLine());
            int born = age.Year;
            DateTime td = DateTime.Now;
            int moment = td.Year;
            int ageNow = moment - born;
            Console.WriteLine(("В момента сте на " + ageNow + " години"));
            int result = (ageNow + 10);
            Console.Write("След 10 години ще сте на {0} години", result);


        }
    }
}
