using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasenSovellus
{
    // Classes for associations and members

    // Class for the Association
    class Association
    {
        // Defined fields aka attributes, access level private by default
        string name;
        string street;
        string zipCode;
        string city;
        uint members;

        // Default constructor, no parameters
        public Association()
        {
            this.name = "N/A";
            this.street = "N/A";
            this.zipCode = "N/A";
            this.city = "N/A";
            this.members = 0;
        }

        // Constructor with all arguments
        public Association(string name, string street, string zipcode, string city, uint members)
        {
            this.name = name;
            this.street = street;
            this.zipCode = zipcode;
            this.city = city;
            this.members = members;
        }
        // Method to show the name 
        public string showName()
        {
            return this.name;
        }
    }

    // Main program starts here
    class Program
    {
        static void Main(string[] args)
        {
            // Lets create a Association object named association
            Association association = new Association();
            string nimi = association.showName();
            Console.WriteLine(nimi);
            Console.ReadLine();
            
        }
    }
}
