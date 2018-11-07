using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    static class Menu
    {
        static public void MainMenu(ContactBooks shelf)
        {
            Console.Clear();
            Console.WriteLine("Welcome to CONTACTS-LIST Application! What would you like to do?");
            Console.WriteLine("=====================================================================");
            Console.WriteLine("0. Home");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("1. Create a new book");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("2. Open an existing book");
            Console.WriteLine("---------------------------------------------------------------------");

            string selection = Console.ReadLine();
            switch (selection)
            {
                case "0":
                    MainMenu(shelf);
                    return;
                case "1":
                    Console.Clear();
                    ContactBook newBook = new ContactBook();
                    newBook.NameBook();
                    shelf.AddContactBook(newBook);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Which book would you like to open?");
                    Console.WriteLine("=====================================================================");
                    ContactBook currentBook = shelf.ChooseContactBook();
                    BookMenu(shelf, currentBook);
                    return;
            }
            Console.Clear();
            MainMenu(shelf);
        }

        static public void BookMenu(ContactBooks shelf, ContactBook book)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the book menu for {0}! What would you like to do?", book.Name);
            Console.WriteLine("=====================================================================");
            Console.WriteLine("0. Home");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("1. List Contacts");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("2. Add a Contact");
            Console.WriteLine("---------------------------------------------------------------------");

            string selection = Console.ReadLine();
            switch (selection)
            {
                case "0":
                    MainMenu(shelf);
                    return;
                case "1":
                    Console.Clear();
                    book.PrintContacts();
                    Console.WriteLine("Press enter to continue..");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    book.AddContact();
                    break;
            }
            BookMenu(shelf, book);
        }
    }
}
