using System;


namespace Bank_Acount
{
    class Program
    {
        static void Main()
        {
            //A bank account has a holder name (first name, middle name and last name),
            //available amount of money (balance), bank name, IBAN,
            //3 credit card numbers associated with the account.
            //Declare the variables needed to keep the information for a single bank account
            //using the appropriate data types and descriptive names.

            string holderFirstName;
            string holderMiddleName;
            string holderLastName;
            decimal balance;
            string bankName;
            string IBAN;
            string BIC_Code;
            long creditCardNumber1;
            long creditCardNumber2;
            long creditCardNumber3;

            holderFirstName = "Petar";
            holderMiddleName = "Stoyanov";
            holderLastName = "Yankov";
            balance = 5.77M;
            bankName = "DSK";
            IBAN = "BG85STSA12345678912345";
            BIC_Code = "STSABGSF";
            creditCardNumber1 = 6776030078884332;
            creditCardNumber2 = 1293129091298001;
            creditCardNumber3 = 1209839102309111;

            Console.WriteLine("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}", holderFirstName, holderMiddleName, holderLastName, balance, bankName, IBAN, BIC_Code, creditCardNumber1, creditCardNumber2, creditCardNumber3);


        }
    }
}
