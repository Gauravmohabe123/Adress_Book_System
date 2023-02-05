using System;

namespace Adress_Book_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            Adress_Book adress = new Adress_Book();
            Console.WriteLine(adress.AddContact());

        }
    }
}
