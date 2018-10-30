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
			Console.WriteLine("Welcome to your contacts list application! What would you like to do?");
			Console.WriteLine("=====================================================================");
			Console.WriteLine("1. Create a new book");
			Console.WriteLine("---------------------------------------------------------------------");
			Console.WriteLine("2. Access an existing book");
			Console.WriteLine("---------------------------------------------------------------------");

			string selection = Console.ReadLine();
			switch(selection)
			{
				case "1":
					Console.WriteLine("!");
					break;
				case "2":
					Console.WriteLine("?");
					break;
			}

			//ContactBook myContactBook = CreateBook();
			//myContactBook.NameBook();
			//myContactBook.AddContact();
			//myContactBook.PrintContacts();

		}

		static ContactBook CreateBook()
		{
			return new ContactBook();
		}
	}
}
