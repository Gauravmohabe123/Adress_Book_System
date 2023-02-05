using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_Book_System
{
    internal class Adress_Book
    {
        List<Contacts> contacts;
        public Adress_Book()
        {
         contacts  = new List<Contacts>();
        }

        public Contacts AddContact()
        {
            Contacts contact = new Contacts();
            Console.WriteLine("Enter your First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address ");
            contact.Adress = Console.ReadLine();
            Console.WriteLine("Enter your City name ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State name");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your zipcode");
            contact.zipCode = Console.ReadLine();
            Console.WriteLine("Enter your Phone number");
            contact.phonenumbur = Console.ReadLine();
            Console.WriteLine("Enter your email ");
            contact.email = Console.ReadLine();
            contacts.Add(contact);

            return contact;
        }
        public void  show()
        {

            if (contacts.Count <= 0)
            {
                Console.WriteLine("No contacts available");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine
                   (@$"
                      Name: {contact.FirstName} {contact.LastName}
                      Address: {contact.Adress} 
                      City: {contact.City}
                      State: {contact.State}
                      Zipcode: {contact.zipCode}
                      PhoneNumber:{contact.phonenumbur}
                      Email: {contact.email}
                  ");

                }

            }
        }
        }
        }
