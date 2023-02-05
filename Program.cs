using System;

namespace Adress_Book_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            Adress_Book adress = new Adress_Book();


            while (true)
            {
                Console.WriteLine("Select an option\na - Add a new contact\nb -View all contacts");
                string input = Console.ReadLine();
                char option = input[0];
                switch (option)
                {
                    case 'a':
                        adress.AddContact();
                        break;
                    case 'b':
                        adress.show();
                        break;
                    default: Console.WriteLine("Select write option:");
                        break;
                }
            }



        }
    }
}
