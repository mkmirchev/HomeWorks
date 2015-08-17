using System;

    class CompanyInfo
    {
        static void Main()
        {
            // Collecting data about the company
            Console.Write("Company name: ");
            string company = Console.ReadLine();
            Console.Write("Company address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string fax = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string manFName = Console.ReadLine();
            Console.Write("Manager second name: ");
            string manSName = Console.ReadLine();
            Console.Write("Manager age: ");
            string manAge = Console.ReadLine();
            Console.Write("Manager phone number: ");
            string manPhoneNumber = Console.ReadLine();
            // Printing information about company
            Console.WriteLine("Company name: " + company);
            Console.WriteLine("Company address: " + address);
            Console.WriteLine("Phone number: " + phoneNumber);
            Console.WriteLine("Fax number: " + fax);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",manFName,manSName,manAge,manPhoneNumber);
        }
    }

