using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	class Program
	{
		static void Main(string[] args)
		{
			ContactBook myContactBook = new ContactBook("Ben's Contacts");

			myContactBook.AddContact("John", "303-718-6299");
			myContactBook.AddContact("Sally", "445-588-7258");


			Console.WriteLine(myContactBook.Name);
			myContactBook.PrintContacts();

			Console.WriteLine("Please add a contact name: ");
			string newName = Console.ReadLine();
			Console.WriteLine("Please add a contact phone number: ");
			string newNumber = Console.ReadLine();

			myContactBook.AddContact(newName, newNumber);
			myContactBook.PrintContacts();

		}
	}
}
