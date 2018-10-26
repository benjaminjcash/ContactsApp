using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	public class ContactBook
	{ 
		public ContactBook(string name)
		{
			Name = name;
			Contacts = new List<Contact>();
		}

		public void AddContact(string name, string phoneNumber)
		{
			Contact newContact = new Contact(name, phoneNumber);
			Contacts.Add(newContact);
		}

		public void PrintContacts()
		{
			foreach (Contact contact in Contacts)
			{
				Console.WriteLine(contact.Name);
				Console.WriteLine(contact.PhoneNumber);
			}
		}

		public string Name { get; }

		public List<Contact> Contacts { get; }
	}
}
