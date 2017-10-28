using System;


namespace Employee_Data
{
    class Program
    {
        static void Main()
        {
            //A marketing company wants to keep record of its employees. Each record would have the following characteristics:

            //First name
            //Last name
            //Age(0...100)
            //Gender(m or f)
            //Personal ID number(e.g. 8306112507)
            //Unique employee number(27560000…27569999)
            //Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names.Print the data at the console.
            string firstName = "Stanko";
            string lastName = "Todorov";
            byte age = 61;
            char gender = 'f';
            long personalIDNumber = 1234567890;
            uint uniqueEmployeeNumber = 12345678;
            Console.WriteLine("name \\" + "{0} {1}",firstName,lastName);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine( personalIDNumber);
            Console.WriteLine(uniqueEmployeeNumber);

        }


    }
}
