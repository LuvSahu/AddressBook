namespace AddressBookSystem
{
    class Program
    {
        public static void Main(String[] args)
        {
            string Commit = " ";
            Console.WriteLine("Welcome To Address Book ");


            while (Commit != "Exit")
            {
                // Console.Clear();
                Console.WriteLine("1 for Add Contacts");
                Console.WriteLine("2 for Display ");
                Console.WriteLine("3 for Edit Contacts");
                Console.WriteLine("4 for Delete for Contacts");
                Console.WriteLine("5 for Add Multiple Contacts");



                int Opition = Convert.ToInt32(Console.ReadLine());

                switch (Opition)
                {
                    case 1:
                        AddressBook Address = new AddressBook();
                        Address.AddPerson();
                        break;

                    case 2:
                        AddressBook Disply = new AddressBook();
                        Disply.Display();
                        break;

                    case 3:
                        AddressBook Edit = new AddressBook();
                        Edit.editContact();
                        break;

                    case 4:
                        AddressBook Delete = new AddressBook();
                        Delete.deleteContact();
                        break;

                    case 5:
                        AddressBook AddMultipleContact = new AddressBook();
                        AddMultipleContact.AddMultipleContact();
                        break;

                    default:
                        Console.WriteLine("Enter Vaild Input");
                        Commit = "Exit";
                        break;
                }

            }
        }
    }
}