using System;

namespace AddressBookCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##################Welcome to the Address Book Program################");
            AddressBookBuilder abd = new AddressBookBuilder();
            while (true)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("1. Add Member to Contact list \n2. View Members in Contact List\n3. Edit members Contacts lists\n4. Delete members Contacts list\n5. Search Details\n6. Count\n7. SortEntries\n8. Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        abd.AddContact();
                        break;
                    case 2:
                        abd.ViewContactPerson();
                        break;
                    case 3:
                        abd.editingDetails();
                        break;
                    case 4:
                        abd.DeleteContact();
                        break;
                    case 5:
                        abd.SearchDetails();
                        break;
                    case 6:
                        abd.CountByStateOrCity();
                        break;
                    case 7:
                        abd.SortEntries();
                        break;
                    case 8:
                        Console.WriteLine("Exited");
                        return;
                }

            }

        }
    }
}
