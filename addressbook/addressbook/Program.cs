// See https://aka.ms/new-console-template for more information
//using System;
//using AddressBookSolution;
//class program
//{
//    public static void Main(String[] args)
//    {
//        Console.WriteLine("Enter the Address Details");
//        AddressBook address = new AddressBook();
//        address.FirstName = Console.ReadLine();
//        address.LastName = Console.ReadLine();
//        address.Address = Console.ReadLine();
//        address.State = Console.ReadLine();
//        address.EmailAddress = Console.ReadLine();
//        address.PostalCode = Convert.ToInt32(Console.ReadLine());
//        address.MobileNumber = Convert.ToInt64(Console.ReadLine());
//        Console.WriteLine(address.FirstName + " " + address.LastName + " " + address.Address + " " + address.State + " " + address.EmailAddress + " " + address.PostalCode + " " + address.MobileNumber);

//    }
//}

//using System;
//using AddressBookSolution;
//class program
//{
//    public static void Main(String[] args)
//    {
//        Console.WriteLine("Enter the Address Details");
//        AddressBook addressBook = new AddressBook();
//        addressBook.Display();
//    }
//}

class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Address Details");
        AddressBook addressBook = new AddressBook();
        addressBook.Display();
        Console.WriteLine("Enter the First Name");
        string name = Console.ReadLine();
        Console.WriteLine("Display after Deleting information ");
        addressBook.DeletingContactINAddressBook(name);
    }
}