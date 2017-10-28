using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Company_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            //A company has name, address, phone number, fax number, web site and manager.
            //The manager has first name, last name, age and a phone number.
            //Write a program that reads the information about a company and its manager 
            //and prints it back on the console.

            // INPUT:
            //You will each piece of information about the company on a separate line, 
            // in the same order as in the example.

            //Company name
            //Company address
            // Phone number
            //           Fax number
            //Web site
            //  Manager first name
            //Manager last name
            //Manager age
            //Manager phone

            //OUTPUT:
            //Print the information the same way as shown in the sample test.
            //Make sure that you print "(no fax)" if an empty line is passed as fax number.

            Console.WriteLine("Company Name ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Company Addres");
            string companyAdres = Console.ReadLine();
            Console.WriteLine("Phone Number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Fax Number");
            string faxNumber = Console.ReadLine();
            Console.WriteLine("Web Site");
            string webSite= Console.ReadLine();
            Console.WriteLine("Manager First Name");
            string firstName= Console.ReadLine();
            Console.WriteLine("Manager Last Name");
            string lastName= Console.ReadLine();
            Console.WriteLine("Manager Age");
            string age = Console.ReadLine();
            Console.WriteLine("Manager Phone");
            string phone = Console.ReadLine();

            Console.WriteLine(companyName);

            Console.WriteLine("Addres "+companyAdres);
            Console.WriteLine("Tel."+phoneNumber);
            Console.WriteLine(faxNumber == "" ? "Fax: (no fax)" : "Fax: {0}", faxNumber);
            Console.WriteLine(webSite);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(phone);




        }
    }
}
