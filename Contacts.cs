using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_Book_System
{
    internal class Contacts
    {
        public string FirstName;
        public string LastName;
        public string Adress;
        public string City;
        public string zipCode;
        public string State;
        public string phonenumbur;
        public string email;

        public override string ToString()
        {
            return @$"
          Name: {FirstName} {LastName}
          Address: {this.Adress} 
          City: {this.City}
          State: {this.State}
          Zipcode: {this.zipCode}
          PhoneNumber:{this.phonenumbur}
          Email: {this.email}
                   ";
        }


    }
}
