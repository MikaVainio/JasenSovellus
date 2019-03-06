using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasenSovellus
{
    // Classes for assiciations and members

    // Class for the Accociation
    class Accociation
    {
        // Defined fields aka attributes, access level private by default
        string name;
        string street;
        string zipCode;
        string city;
        uint members;

        // Default constructor, no parameters
        public Accociation()
        {
            this.name = "N/A";
            this.street = "N/A";
            this.zipCode = "N/A";
            this.city = "N/A";
            this.members = 0;
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
            // Lets create a Accociation object named accociation
            Accociation accociation = new Accociation();
            string nimi = accociation.showName();
            Console.WriteLine(nimi);
            Console.ReadLine();
            
        }
    }
}
