using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        public static List<Contact> Info = new List<Contact>();
        public void AddPerson()
        {
            Contact Person = new Contact();

            Console.WriteLine("Enter the First Name :");
            Person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name :");
            Person.LastName = Console.ReadLine();


            Console.WriteLine("Enter the City Name :");
            Person.City = Console.ReadLine();


            Console.WriteLine("Enter the Zip Code :");
            Person.Zip = Console.ReadLine();



            Console.WriteLine("Enter the Email id :");
            Person.Email = Console.ReadLine();


            Console.WriteLine("Enter the Address :");
            Person.Address = Console.ReadLine();

            Info.Add(Person);

        }

        public void Display()
        {
            foreach (var Contact in Info)
            {
                Console.WriteLine("First Name : " + Contact.FirstName);
                Console.WriteLine("Last Name : " + Contact.LastName);
                Console.WriteLine("City Name : " + Contact.City);
                Console.WriteLine("City Zip : " + Contact.Zip);
                Console.WriteLine("Email id : " + Contact.Email);
                Console.WriteLine("Address : " + Contact.Address);



            }
        }

        public void editContact()
        {
            Console.WriteLine("Enter the First Name you Want to edit :");
            string FirstName = Console.ReadLine();
            foreach (var Contact in Info)
            {
                if (Contact.FirstName.ToLower() == FirstName.ToLower())
                {
                    Console.WriteLine("Enter the infromation you want to change");
                    Console.WriteLine("1 for Last name \n 2 for City \n 3 for Zip \n 4 for Email id \n 5 for Address");
                    int Opition = Convert.ToInt32(Console.ReadLine());
                    switch (Opition)
                    {
                        case 1:
                            Console.WriteLine("Enter the Last Name");
                            Contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the City");
                            Contact.City = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the Zip");
                            Contact.Zip = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter Email Id");
                            Contact.Email = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the Address");
                            Contact.Address = Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Contacts is not Found");
                }
            }
        }

        public void deleteContact()
        {
            Console.WriteLine("Enter the First Name you Want to Delete :");
            string Name = Console.ReadLine();
            foreach (var Contact in Info)
            {
                if (Contact.FirstName.ToLower() == Name.ToLower())
                {
                    Info.Remove(Contact);

                }

            }
        }

        //public static void Display()
        //{
        //    foreach (Contact contact in People)
        //    {
        //        Console.WriteLine($"Firstname \t{contact.FirstName}\n Lastname \t {contact.LastName}\n PhoneNumber \t{contact.PhoneNumber}\ncity \t{contact.city}\n zip \t{contact.Zip}\n Email \t{contact.Email}\n Adress \t{contact.Address}\n ");
        //    }
        //}
        public void AddMultipleContact()
        {
            Console.WriteLine("enter number of contact you want to add");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                AddPerson();
                N--;
            }
        }


    }
}
