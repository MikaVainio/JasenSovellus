﻿using System;
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

        // Method for displaying all properties of an object
        public void showProperties()
        {
            Console.WriteLine("Yhdistyksen nimi on " + this.name);
            Console.WriteLine("Yhdistyksen katuosoite on " + this.street);
            Console.WriteLine("Yhdistyksen postinumero on " + this.zipCode);
            Console.WriteLine("Yhdistyksen postitoimipaikka " + this.city);
            Console.WriteLine("Ja jäsenmäärä on " + this.members.ToString());
        }
    }

    // Class for members
    class Member
    {
        protected string firstName;
        protected string lastname;
        protected string number;
        protected string phone;
        protected string email;

        // Default Constructor, no arguments
        public Member()
        {
            this.firstName = "N/A";
            this.lastname = "N/A";
            this.number = "N/A";
            this.phone = "N/A";
            this.email = "N/A";
        }

        // Constructor with all arguments
        public Member(string givenName, string surname, string memberId, string tel, string mail)
        {
            this.firstName = givenName;
            this.lastname = surname;
            this.number = memberId;
            this.phone = tel;
            this.email = mail;
        }
    }

    // Class for officials, inherits Member class
    class Official : Member
    {
        string role;
        float compensation;

        // Default Constructor for officias
        public Official() : base()
        {
            this.role = "N/A";
            this.compensation = 0f;
        }

        // Constructor with all arguments
        public Official(string givenName, string surname, string memberId, string tel, string mail, string duty, float fee)
        {
            this.role = duty;
            this.compensation = fee;

        }
    }

    // Main program starts here
    class Program
    {
        static void Main(string[] args)
        {
            // Lets type association information
            string inputName;
            string inputStreet;
            string inputZipCode;
            string inputCity;
            string inputMembers;
            uint members;

            Console.Write("Syötä yhdistyksen nimi: ");
            inputName = Console.ReadLine();
            Console.Write("Anna katuosoite: ");
            inputStreet = Console.ReadLine();
            Console.Write("Anna postinumero: ");
            inputZipCode = Console.ReadLine();
            Console.Write("Syötä postitoimipaikka: ");
            inputCity = Console.ReadLine();
            Console.Write("Syötä jäsenmäärä: ");
            inputMembers = Console.ReadLine();
            members = Convert.ToUInt32(inputMembers);


            // Lets create a Association object named association
            Association association = new Association(inputName, inputStreet, inputZipCode, inputCity, members);
            string nimi = association.showName();
            association.showProperties();
            Console.ReadLine();
            
        }
    }
}
