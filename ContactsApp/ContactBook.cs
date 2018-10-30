using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	public class ContactBook
	{
		string name;

		public ContactBook()
		{
			Contacts = new List<Contact>();
		}

		public void AddContact()
		{
			Console.WriteLine("Please add a contact name: ");
			string newName = Console.ReadLine();
			Console.WriteLine("Please add a contact phone number: ");
			string newNumber = Console.ReadLine();
			Console.WriteLine("Please add a contact address: ");
			string newAddress = Console.ReadLine();

			Contact newContact = new Contact(newName, newNumber, newAddress);
			Contacts.Add(newContact);
		}

		public void PrintContacts()
		{
			Console.WriteLine(name);

			foreach (Contact contact in Contacts)
			{
				Console.WriteLine(contact.Name);
				Console.WriteLine(contact.PhoneNumber);
				Console.WriteLine(contact.Address);
			}
		} 

		public void NameBook()
		{
			Console.WriteLine("Please enter a name for your contact book: ");
			string newName = Console.ReadLine();
			Name = newName;
		}

		public string Name
		{
			get => name;
			set => name = value;
		}

		public List<Contact> Contacts { get; }
	}
}
