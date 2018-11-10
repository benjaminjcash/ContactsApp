using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

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
            try
            {
                string connStr = "server=localhost;user=root;database=contacts;port=3306;password=root";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT * FROM contacts";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2] + " -- " + rdr[3]);
                }
                rdr.Close();
            }
            catch(Exception err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }
            

   //         Console.WriteLine("CONTACTS");
   //         Console.WriteLine("=====================================================================");
   //         foreach (Contact contact in Contacts)
			//{
   //             Console.WriteLine("\n");
   //             Console.WriteLine("Name: {0}", contact.Name);
			//	Console.WriteLine("Phone Number: {0}", contact.PhoneNumber);
			//	Console.WriteLine("Address: {0}", contact.Address);
   //             Console.WriteLine("\n");
   //             Console.WriteLine("---------------------------------------------------------------------");
   //         }
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
